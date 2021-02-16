using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int PasswordStrength = 0;

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            InputBox.ReadOnly = true;

            string password;
            password = InputBox.Text;

            if (password.Length < 8)
            {
                PasswordStrength += 1;
            }

            bool IntSearch = password.Any(char.IsDigit);
            if (IntSearch == false)
            {
                PasswordStrength += 1;
            }

            bool UpperSearch = password.Any(char.IsUpper);
            if (UpperSearch == false)
            {
                PasswordStrength += 1;
            }

            bool LowerSearch = password.Any(char.IsLower);
            if (LowerSearch == false)
            {
                PasswordStrength += 1;
            }

            bool SymbolSearch = password.All(char.IsLetterOrDigit);
            if (SymbolSearch == true)
            {
                PasswordStrength += 1;
            }

            else
            {
                PasswordStrength += 0;
            }


            if (PasswordStrength >= 3)
            {
                StrengthLabel.Text = "Your password is very weak";
                StrengthLabel.ForeColor = Color.Red;
            }

            if (PasswordStrength <3 && PasswordStrength > 0)
            {
                StrengthLabel.Text = "Your password is weak";
                StrengthLabel.ForeColor = Color.Orange;
            }

            if (PasswordStrength == 0)
            {
                StrengthLabel.Text = "Your password is strong";
                StrengthLabel.ForeColor = Color.Lime;
            }

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            InputBox.Text = "";
            PasswordStrength = 0;
            StrengthLabel.Text = "";
            InputBox.ReadOnly = false;
        }

    }   
}
