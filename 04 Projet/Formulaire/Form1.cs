using _04_Projet.Formulaire;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Projet
{
    public partial class Hotel : Form
    {
        public Hotel()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (!winmean.Controls.Contains(Clients.cls))
            {
                winmean.Controls.Add(Clients.cls);
                Clients.cls.Dock = DockStyle.Fill;
                Clients.cls.BringToFront();
            }
            else
            {
                Clients.cls.BringToFront();
            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (!winmean.Controls.Contains(Employe.emps))
            {
                winmean.Controls.Add(Employe.emps);
                Employe.emps.Dock = DockStyle.Fill;
                Employe.emps.BringToFront();
            }
            else
            {
                Employe.emps.BringToFront();
            }
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            if (!winmean.Controls.Contains(Chambre.chms))
            {
                winmean.Controls.Add(Chambre.chms);
                Chambre.chms.Dock = DockStyle.Fill;
                Chambre.chms.BringToFront();
            }
            else
            {
                Chambre.chms.BringToFront();
            }
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            if (!winmean.Controls.Contains(Reservation.rsrs))
            {
                winmean.Controls.Add(Reservation.rsrs);
                Reservation.rsrs.Dock = DockStyle.Fill;
                Reservation.rsrs.BringToFront();
            }
            else
            {
                Reservation.rsrs.BringToFront();
            }
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            if (!winmean.Controls.Contains(Transaction.trs))
            {
                winmean.Controls.Add(Transaction.trs);
                Transaction.trs.Dock = DockStyle.Fill;
                Transaction.trs.BringToFront();
            }
            else
            {
                Transaction.trs.BringToFront();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            if (!winmean.Controls.Contains(maitre.mtrs))
            {
                winmean.Controls.Add(maitre.mtrs);
                maitre.mtrs.Dock = DockStyle.Fill;
                maitre.mtrs.BringToFront();
            }
            else
            {
                maitre.mtrs.BringToFront();
            }
        }
    }
}
