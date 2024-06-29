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
    public partial class Transaction : UserControl
    {
        public Transaction()
        {
            InitializeComponent();
        }
        private static Transaction tr;
        public static Transaction trs
        {
            get
            {
                if (tr == null)
                {
                    tr = new Transaction();

                }
                return tr;
            }
        }
        private void Transaction_Load(object sender, EventArgs e)
        {

        }
    }
}
