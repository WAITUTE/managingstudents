using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engineeringmanagement2
{
    public partial class GetAllFile : Form
    {
        public GetAllFile()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void GetAllFile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.modelDataSet.Students);

        }

        private void genderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(genderCheckBox.CheckState == CheckState.Checked)
            {
                genderCheckBox.Text = "Male";

            }else if(genderCheckBox.CheckState == CheckState.Unchecked)
            {
                genderCheckBox.Text = "Female";

            }
            else
            {
                genderCheckBox.Text = "??";
            }
        }
    }
}
