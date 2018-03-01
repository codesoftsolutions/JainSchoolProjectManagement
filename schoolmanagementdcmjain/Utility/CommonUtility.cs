using System;
using System.Windows.Forms;

namespace schoolmanagementdcmjain.Utility
{
    class CommonUtility
    {
        public void openFileDialog(string openDirectory, bool restoreCurrentDirectory, string dialogTitle, string defaultExtension,
            bool filterExtension, string filterExtensionTypes, bool checkPathExistsOrNot, bool checkFileExistsOrNot)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @Constants.ConstantStrings.emptyString + openDirectory;
            openFileDialog.RestoreDirectory = restoreCurrentDirectory;
            openFileDialog.Title = dialogTitle;
            openFileDialog.DefaultExt = defaultExtension;
            if (filterExtension)
                openFileDialog.Filter = filterExtensionTypes;
            openFileDialog.CheckFileExists = checkFileExistsOrNot;
            openFileDialog.CheckPathExists = checkPathExistsOrNot;
        }

        public void checkIsStringOrNot(KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void checkIsDigitOrNot(KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
