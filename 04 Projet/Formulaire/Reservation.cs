using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Projet.Formulaire
{
    public partial class Reservation : UserControl
    {
        public Reservation()
        {
            InitializeComponent();
        }
        private static Reservation rsr;
        public static Reservation rsrs
        {
            get
            {
                if (rsr == null)
                {
                    rsr = new Reservation();

                }
                return rsr;
            }
        }
        private void Reservation_Load(object sender, EventArgs e)
        {

        }
    }
}
