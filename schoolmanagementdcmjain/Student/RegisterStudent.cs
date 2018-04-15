using System;
using System.Windows.Forms;
using schoolmanagementdcmjain.Utility;

namespace schoolmanagementdcmjain.Student
{
    public partial class RegisterStudent : Form
    {
        CommonUtility ui = new CommonUtility();
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void checkString(object sender, KeyPressEventArgs e) => ui.checkIsStringOrNot(e);

        private void checkDigit(object sender, KeyPressEventArgs e) => ui.checkIsDigitOrNot(e);

        private void Cancel_Click(object sender, EventArgs e) => Close();

        private void save_Click(object sender, EventArgs e)
        {

        }
    }
}
