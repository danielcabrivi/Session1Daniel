using Session1Daniel.dbSession1DanielDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1Daniel
{
    public partial class Form1 : Form
    {
        private int qtdAdultos;
        private DateTime dtCheckIn;
        private DateTime dtCheckOut;
        
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Pesquise com um endereço, bairro ou o hotel";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today.AddDays(1);
            
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
            String diaDaSemana = dataChekIn.DayOfWeek.ToString();
            label5.Text = diaDaSemana;

            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = dataChekIn.AddDays(1);
            calculaQtdDiarias();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataChekOut = dateTimePicker2.Value;
            String diaDaSemana = dataChekOut.DayOfWeek.ToString();
            label6.Text = diaDaSemana;
                        
            calculaQtdDiarias();
        }

        private void calculaQtdDiarias()
        {
            DateTime dataChekIn = dateTimePicker1.Value;
            DateTime dataChekOut = dateTimePicker2.Value;

            int qtdDiarias = (dataChekOut - dataChekIn).Days;
            if (qtdDiarias == 1)
            {
                label4.Text = qtdDiarias + " diária";
            }
            else
            {
                label4.Text = qtdDiarias + " diárias";
            }
            
        }

        private void listarHoteis(String pNomeEndereco)
        {

            HoteisEncontradosTableAdapter hotel1TableAdapter = new HoteisEncontradosTableAdapter();
            dbSession1DanielDataSet.HoteisEncontradosDataTable dados = hotel1TableAdapter.GetData(pNomeEndereco);
                    
            dataGridView1.Rows.Clear();

            foreach (DataRow item in dados)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["HOTNOME"];
                dataGridView1.Rows[n].Cells[1].Value = item["HOTENDERECO"];
            }          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String parametro = textBox1.Text;

            listarHoteis(parametro);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qtdAdultos = int.Parse(comboBox1.SelectedItem.ToString());
            dtCheckIn = dateTimePicker1.Value;
            dtCheckOut = dateTimePicker2.Value;

            Form2 frm2 = new Form2(qtdAdultos, dtCheckIn, dtCheckOut);

            frm2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
