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
    public partial class Employe : UserControl
    {
        public Employe()
        {
            InitializeComponent();
        }
        private static Employe emp;
        public static Employe emps
        {
            get
            {
                if (emp == null)
                {
                    emp = new Employe();
                }
                return emp;
            }
        }
        private void Employe_Load(object sender, EventArgs e)
        {

        }
    }
}
