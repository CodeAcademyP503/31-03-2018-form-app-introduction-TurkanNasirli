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
    public partial class CinemaSeats : Form
    {
        Button[,] btnSeat = new Button[100, 100];
        public int SeatRow;
        public int SeatColumn;
        public int Seatnumber = 1;
        public static List<Button> ReservSeats = new List<Button>();
        public static List<int> seanslar = new List<int>();  

        public CinemaSeats()
        {
            this.Hide();
            
            InitializeComponent();
            
           
            Seans1.Click += new EventHandler(Seans1_Click);
           Reservebtn.Click += new EventHandler(Reservebtn_Click);
            int offset;
            int seatMax = 17;
            for (int j = 1; j <= 4; j++)
            {
                if (j == 1) seatMax = 11;
                if (j == 2) seatMax = 12;
                if (j == 3) seatMax = 14;
                if (j == 4) seatMax = 17;

                for (int i = 1; i <= seatMax; i++)
                {

                    offset = 0;
                    if (j == 1) offset = 8;
                    if (j == 2) offset = 7;
                    if (j == 3) offset = 5;
                    if (j == 4) offset = 2;
                    btnSeat[i, j] = new Button();
                    btnSeat[i, j].Width = 30;
                    btnSeat[i, j].Height = 30;
                    btnSeat[i, j].Left = ((30 * i) + (15 * offset) - 10);
                    btnSeat[i, j].Top = 120 + (30 * j);
                    btnSeat[i, j].Text = Seatnumber.ToString();
                    btnSeat[i, j].Click += new EventHandler(Button_Click);
                    Seatnumber++;
                    Controls.Add(btnSeat[i, j]);


                }

            }
        }
       
        public void Seans1_Click(object sender, EventArgs e)
        {
            var Seansst = sender as Button;
            Seansst.BackColor = Color.DarkRed;
            Controls.Add(Seans1);
            Seans2.Enabled = false;
            
           
        }
        public void Seans2_Click(object sender, EventArgs e)
        {
            Button Seansnd = sender as Button;
            Seansnd.BackColor = Color.DarkRed;
            Controls.Add(Seans2);
            foreach  (int item in seanslar)
            {
             
            }
            Seans1.Enabled = false;

           }
         
        
        public void Button_Click(object sender, EventArgs e)
        {
            
                Button btn = sender as Button;
                btn.BackColor = Color.DarkRed;
                ReservSeats.Add(btn);
                btn.Click -= Button_Click;
        }

        private void Reservebtn_Click(object sender, EventArgs e)
        {
            foreach (Button item in ReservSeats)
            {
                item.Enabled = false;
            }
            var rezervation = new Reservation();
            rezervation.Show();


        }

        private void Exit2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Exit1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
