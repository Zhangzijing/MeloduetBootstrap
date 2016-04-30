using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MSPDT.Windows
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }
        public static string Show(string title,string content)
        {
            var inform = new InputForm();
            inform.Text = title;
            inform.txtContents.Text = content;
            inform.ShowDialog();
            inform.StartPosition = FormStartPosition.CenterScreen;
            var rtn = inform.txtInputed.Text;          
            inform.Close();
            return rtn;
        }
        private void InputForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
