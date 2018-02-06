using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolmanagementdcmjain.Student
{
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void studentname_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkIsStringOrNot(e);
        }

        private void phno_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkIsDigitOrNot(e);
        }

        private void mbno_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkIsDigitOrNot(e);
        }

        private void state_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkIsStringOrNot(e);
        }

        private void city_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkIsStringOrNot(e);
        }

        private void area_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkIsStringOrNot(e);
        }

        private void redgfee_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkIsDigitOrNot(e);
        }

        private void age_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkIsDigitOrNot(e);
        }

        private void fathername_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkIsStringOrNot(e);
        }

        private void mothername_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkIsStringOrNot(e);
        }

        private void checkIsStringOrNot(KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkIsDigitOrNot(KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
