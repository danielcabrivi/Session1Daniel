using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Session1Daniel.Classes;

namespace Session1Daniel
{
    public partial class UserControlHotelUnt : UserControl
    {
        public UserControlHotelUnt(HotelClass hotelUnt)
        {
            InitializeComponent();

            lblNomeHotel.Text = hotelUnt.Nome;
            lblEndereco.Text = hotelUnt.Endereco;
            pbUhotel.ImageLocation = "C:\\Users\\danie\\source\\repos\\Session1Daniel\\Session1Daniel\\Resources\\" + hotelUnt.Imagem;

        }
    }
}
