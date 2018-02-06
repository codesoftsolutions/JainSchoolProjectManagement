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

        private void keyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Name.Equals(mb_no.Name))
            {
                checkIsDigitOrNot(e);
            }
            else if (textBox.Name.Equals(phone_no.Name))
            {
                checkIsDigitOrNot(e);
            }
            else if (textBox.Name.Equals(state.Name))
            {
                checkIsStringOrNot(e);
            }
            else if (textBox.Name.Equals(city.Name))
            {
                checkIsStringOrNot(e);
            }
            else if (textBox.Name.Equals(area.Name))
            {
                checkIsStringOrNot(e);
            }
            else if (textBox.Name.Equals(studentName.Name))
            {
                checkIsStringOrNot(e);
            }
            else if (textBox.Name.Equals(fatherName.Name))
            {
                checkIsStringOrNot(e);
            }
            else if (textBox.Name.Equals(motherName.Name))
            {
                checkIsStringOrNot(e);
            }
            else if (textBox.Name.Equals(state.Name))
            {
                checkIsStringOrNot(e);
            }
            else if (textBox.Name.Equals(state.Name))
            {
                checkIsStringOrNot(e);
            }
            else if (textBox.Name.Equals(age.Name))
            {
                checkIsDigitOrNot(e);
            }
        }
    }
}
