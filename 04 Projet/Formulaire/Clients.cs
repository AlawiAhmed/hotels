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
    public partial class Clients : UserControl
    {
        public Clients()
        {
            InitializeComponent();
        }
        private static Clients cl;
        public static Clients cls
        {
            get
            {
                if (cl == null)
                {
                    cl = new Clients();

                }
                return cl;
            }
        }
        private void Clients_Load(object sender, EventArgs e)
        {

        }
    }
}
