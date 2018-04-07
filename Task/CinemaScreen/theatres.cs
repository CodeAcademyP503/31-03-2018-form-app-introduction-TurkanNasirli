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
    public partial class theatres : Form
    {
        public theatres()
        {
            InitializeComponent();
            
        }

        private void ProPrice_Click(object sender, EventArgs e)
        {

        }

        private void Inception_Click(object sender, EventArgs e)
        {
            var cnm = new CinemaSeats();
            cnm.Show();
        
        }

        private void Interstellar_Click(object sender, EventArgs e)
        {
            var cnm = new CinemaSeats();
            cnm.Show();
        }

        private void Whiplash_Click(object sender, EventArgs e)
        {
            var cnm = new CinemaSeats();
            cnm.Show();
        }

        private void ProjectX_Click(object sender, EventArgs e)
        {
            var cnm = new CinemaSeats();
            cnm.Show();
        }

        private void DosTiposPeligrosos_Click(object sender, EventArgs e)
        {
            var cnm = new CinemaSeats();
            cnm.Show();

        }
    }
}
