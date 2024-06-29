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
    public partial class Chambre : UserControl
    {
        private static Chambre chm;
        public static Chambre chms
        {
            get
            {
                if (chm == null)
                {
                    chm = new Chambre();

                }
                return chm;
            }
        }
        public Chambre()
        {
            InitializeComponent();
        }

        private void Chambre_Load(object sender, EventArgs e)
        {

        }
    }
}
