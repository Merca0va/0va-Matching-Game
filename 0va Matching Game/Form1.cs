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
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DataOk())
            {
                this.Hide();
                MatchingGame mg = new MatchingGame(FirstName.Text);
                mg.ShowDialog();
            }
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            Salutations.SelectedIndex = 0;
            FirstName.Text = null;
            First_Name_Error.Text = null;
            LastName.Text = null;
            Last_Name_Error.Text = null;
            First_Name_Error.ForeColor = Color.Black;
            Last_Name_Error.ForeColor = Color.Black;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Salutations.SelectedIndex = 0;
            FirstName.Text = null;
            First_Name_Error.Text = null;
            LastName.Text = null;
            Last_Name_Error.Text = null;
            First_Name_Error.ForeColor = Color.Black;
            Last_Name_Error.ForeColor = Color.Black;
        }

        public bool DataOk()
        {
            bool rv = true;

            if (FirstName.Text.Length == 0 || FirstName.Text is null)
            {
                First_Name_Error.Text = "You must enter your first name.";
                First_Name_Error.ForeColor = Color.Red;
                rv = false;
            }

                if (LastName.Text.Length == 0 || LastName is null)
                {
                    Last_Name_Error.Text = "You must enter your last name.";
                    Last_Name_Error.ForeColor = Color.Red;
                    rv = false;
                }

                return rv;
            
        }
    }
}
