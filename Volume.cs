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
    public partial class Volume : Form
    {
        public Volume()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var row = new DataGridViewRow();
            
            double? radii = null;

            if (!string.IsNullOrEmpty(textRadii.Text) && double.TryParse(textRadii.Text, out double radiiValue))
            {
                radii = radiiValue * radiiValue * Math.PI * 4/3;

            }

            row.Cells.Add(new DataGridViewTextBoxCell { Value = textRadii.Text });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = radii });
            
            if (row.Cells.Count > 0)
            {
                dataGridView3.Rows.Add(row);
            }
        }
    }
}
