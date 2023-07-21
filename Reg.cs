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
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void Reg_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var row = new DataGridViewRow();

            double? Id = null;
            DateTime currentDate = DateTime.Now.Date;
            currentDate.ToString("yyyy-MM-dd");

            if (!string.IsNullOrEmpty(textId.Text) && double.TryParse(textId.Text, out double radiiValue))
            {
                Id = radiiValue;
                row.Cells.Add(new DataGridViewTextBoxCell { Value = Id.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = textName.Text });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = currentDate });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = textEmail.Text });


            }
            else
            {
                MessageBox.Show("input Id");
            }

           

            if (row.Cells.Count > 0)
            {
                dataGridView2.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }
    }
}
