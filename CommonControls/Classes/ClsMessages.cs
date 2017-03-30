using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonControls.Classes
{
    public class ClsMessages
    {
        public DialogResult warningMessage(string message, string header)
        {
            DialogResult rst = MessageBox.Show(message, header, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            return rst;
        }

        public DialogResult informationMessage(string message, string header)
        {
            DialogResult rst = MessageBox.Show(message, header, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            return rst;
        }

        public DialogResult errorMessage(string message, string header)
        {
            DialogResult rst = MessageBox.Show(message, header, MessageBoxButtons.OK, MessageBoxIcon.Error);

            return rst;
        }

        public DialogResult exceptionMessage(string message)
        {
            DialogResult rst = MessageBox.Show(message, "Exception Handler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return rst;
        }

        public DialogResult validationMessage(string validation)
        {
            DialogResult rst = MessageBox.Show(validation, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Question);

            return rst;
        }

        public DialogResult successfullMessage(string message)
        {
            DialogResult rst = MessageBox.Show(message, "!!SUCCESSFULL!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            return rst;
        }

        public DialogResult permissionMessage(String message)
        {
            DialogResult rst = MessageBox.Show(message, "!! PERMISSION ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            return rst;
        }
    }
}
