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
    public partial class maitre : UserControl
    {
        public maitre()
        {
            InitializeComponent();
        }
        private static maitre mtr;
        public static maitre mtrs
        {
            get
            {
                if (mtr == null)
                {
                    mtr = new maitre();

                }
                return mtr;
            }
        }
        private void maitre_Load(object sender, EventArgs e)
        {

        }
    }
}
