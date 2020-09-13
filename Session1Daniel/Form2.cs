using Session1Daniel.Classes;
using Session1Daniel.dbSession1DanielDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Session1Daniel
{
    public partial class Form2 : Form
    {
        private int qtdAdultos;
        private DateTime dtCheckIn;
        private DateTime dtCheckOut;
        public Form2(int qtdAdultos, DateTime dtCheckIn, DateTime dtCheckOut)
        {
            InitializeComponent();

            this.qtdAdultos = qtdAdultos;
            this.dtCheckIn = dtCheckIn;
            this.dtCheckOut = dtCheckOut;

            textBox1.Text = "Pesquise com um endereço, bairro ou o hotel";
            dateTimePicker1.Value = this.dtCheckIn;
            dateTimePicker2.Value = this.dtCheckOut;

            atualizaHoteisIni();
        }

        private void adicionaHotel(HotelClass hotel, int id, int y)
        {
            UserControlHotelUnt userControlHotelUnt = new UserControlHotelUnt(hotel);
            userControlHotelUnt.Location = new System.Drawing.Point(0, y);
            userControlHotelUnt.Name = "userControlHotelUnt"+id;
            userControlHotelUnt.TabIndex = 14;

            pnlPrincipal.Controls.Add(userControlHotelUnt);

        }

        private void atualizaHoteisIni()
        {
            List<int> listHotelDisponivel = new List<int>();
            listHotelDisponivel = getHoteisDisponiveis();
            int y = 0;

            foreach (int id in listHotelDisponivel)
            {
                HotelClass hotel = new HotelClass();
                
                hotel = buscaHotelById(id);

                adicionaHotel(hotel, id, y);

                y = y + 200;
            }
        }

        private HotelClass buscaHotelById(int id)
        {
            HotelClass hotel = new HotelClass();

            HotelTableAdapter hotelTableAdapter = new HotelTableAdapter();
            dbSession1DanielDataSet.HotelDataTable dados = hotelTableAdapter.GetHotelById(id);

            foreach (DataRow item in dados)
            {
                hotel.Id = int.Parse(item["HOTCODIGO"].ToString());
                hotel.Nome = item["HOTNOME"].ToString();
                hotel.Endereco = item["HOTENDERECO"].ToString();
                hotel.Imagem = item["HOTFOTO"].ToString();
            }

            return hotel;
        }

        private List<int> getHoteisDisponiveis()
        {
            List<int> listAllHotel = new List<int>();
            List<int> listHotelDisponivel = new List<int>();

            listAllHotel = getAllHotelId();
            listHotelDisponivel = getAllHotelId();

            int qtdDiaria = (dtCheckOut - dtCheckIn).Days;
            
            Boolean disponivel = false;

            foreach (int idHotel in listAllHotel)
            {
                DateTime dateTemp = dtCheckIn;

                for (int i = 0; i <= qtdDiaria; i++)
                {
                    
                    disponivel = buscarPorIdData(idHotel,dateTemp);

                    if(!disponivel)
                    {
                        listHotelDisponivel.Remove(idHotel);
                        break;
                    }

                    dateTemp = dateTemp.AddDays(1);
                }
            }

            return listHotelDisponivel;
        }

        private List<int> getAllHotelId()
        {
            HotelTableAdapter hotelTableAdapter = new HotelTableAdapter();
            dbSession1DanielDataSet.HotelDataTable dados = hotelTableAdapter.GetData();

            List<int> listHoteis = new List<int>();

            foreach (DataRow item in dados)
            {
                listHoteis.Add(int.Parse(item["HOTCODIGO"].ToString()));
            }

            return listHoteis;
        }


        private Boolean buscarPorIdData(int idHotel, DateTime dtReserva)
        {
            DispPorDataAdultoTableAdapter dispPorDataAdultoTableAdapter = new DispPorDataAdultoTableAdapter();
            dbSession1DanielDataSet.DispPorDataAdultoDataTable dados = dispPorDataAdultoTableAdapter.GetData(dtReserva.ToString(), this.qtdAdultos, "", idHotel);

            if (dados.Count > 0)
            {
                //Console.WriteLine(idHotel+" - "+dtReserva+" - Disponível");
                return true;
            }
            else
            {
                //Console.WriteLine(idHotel + " - " + dtReserva + " - Não disponível");
                return false;
            }
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (textBox1.Text == "Pesquise com um endereço, bairro ou o hotel")
            {
                textBox1.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                textBox1.Text = "Pesquise com um endereço, bairro ou o hotel";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataChekIn = dateTimePicker1.Value; 

            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = dataChekIn.AddDays(1);
           
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
