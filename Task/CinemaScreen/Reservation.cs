using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaScreen
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
            
            foreach (Button item in CinemaSeats.ReservSeats)
            {
                SelectedSeats.Text += item.Text + ". ";
            }
            SelectedSeats.Enabled = false;
             
        }
        
        private void SelectedSeats_TextChanged(object sender, EventArgs e)
        {

        }

        public void Seanslar_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
