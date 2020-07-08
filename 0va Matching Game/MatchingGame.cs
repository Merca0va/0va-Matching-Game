using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0va_Matching_Game
{
    public partial class MatchingGame : Form
    {
        Label first = null;
        Label second = null;
        static Random Rd = new Random();
        List<String> mySymbol = new List<string>() { "a","a","i","i","l","l","m", "m", "o", "o", "q", "q", "r", "r", "s", "s" };

        private void AssignSymbol()
        {
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                Label label = control as Label;
                int ran = Rd.Next(mySymbol.Count);
                label.Text = mySymbol[ran];
                label.ForeColor = label.BackColor; // Hide the symbols.
                mySymbol.RemoveAt(ran);
            }
        }
        public MatchingGame(string myString)
        {
            InitializeComponent();
            label1.Text = myString;
            AssignSymbol();
            progressBar1.Value = 40;
            label19.Text = "40";
        }

      private void label_click(object sender, EventArgs e)
        {
            // If timer running ignore any clicks.
            if (timer1.Enabled == true)
            {
                return;
            }

            Label label = sender as Label;

            if (label.ForeColor == Color.Orange) // The user clicks an exposed image. Is ignored.
            {
                return;
            }
            if (first == null)
            {
                label.ForeColor = Color.Orange; // Expose the image.
                first = label; // Assign sender to global first label var.
                return;
            }

            //If the code get this far, this is for a second click.
            second = label;
            second.ForeColor = Color.Orange;

            CheckForWin();

            if (first.Text == second.Text)
            {
                first = null;
                second = null;
                return;
            }
            else
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            first.ForeColor = first.BackColor;
            first = null;
            second.ForeColor = second.BackColor;
            second = null;
        }

       private void CheckForWin()
        {
            foreach(Control c in tableLayoutPanel1.Controls)
            {
                if (c.ForeColor == c.BackColor)
                {
                    return;
                }
            }

            timer2.Stop();
            MessageBox.Show("Congratulations!!! You matched all the pairs", "Congrats!!!");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                progressBar1.Value = progressBar1.Value - 1;
                label19.Text = progressBar1.Value.ToString();

                if (progressBar1.Value == 0)
                {
                    MessageBox.Show("The time has expired!", "Time's up!");
                }
            }
            
         
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            progressBar1.Value = 40;
            label19.Text = "40";
            timer2.Start();

            foreach (Control control in tableLayoutPanel1.Controls)
            {

                Label label = control as Label;
                label.ForeColor = label.BackColor; // Hide the symbols.
                

            }
        }
    }
}
