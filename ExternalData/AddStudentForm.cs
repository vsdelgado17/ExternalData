using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExternalData
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        public int ID
        {
            get { return int.Parse(nudID.Value.ToString()); }
        }

        public string FirstName
        {
            get { return tbFirstName.Text; }
        }

        public string LastName
        {
            get { return tbLastName.Text; }
        }
        public string Major
        {
            get { return tbMajor.Text; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
