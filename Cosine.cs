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
    public partial class Cosine : Form
    {
        public Cosine()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Cosine_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 360; i++)
            {
                double cosine = Math.Cos(i * Math.PI / 90);
                double sine = Math.Sin(i * Math.PI / 90);
                double tangent = Math.Tan(i * Math.PI / 90);

                var row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = i });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = cosine });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = sine });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = tangent });
                if (i % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue; 
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral; 
                }

                dataGridView1.Rows.Add(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var row = new DataGridViewRow();
            double? cosine = null, sine = null, tangent = null;


            int i = 0;
            
            
                row.Cells.Add(new DataGridViewTextBoxCell { Value = i });
            
                if (!string.IsNullOrEmpty(textCosine.Text) && double.TryParse(textCosine.Text, out double cosineValue))
            {
                cosine = Math.Cos(cosineValue * Math.PI / 90);
                
            }
            row.Cells.Add(new DataGridViewTextBoxCell { Value = cosine });

            if (!string.IsNullOrEmpty(textSine.Text) && double.TryParse(textSine.Text, out double sineValue))
            {
                sine = Math.Sin(sineValue * Math.PI / 90);
               
            }
            row.Cells.Add(new DataGridViewTextBoxCell { Value = sine });

            if (!string.IsNullOrEmpty(textTan.Text) && double.TryParse(textTan.Text, out double tanValue))
            {
                tangent = Math.Tan(tanValue * Math.PI / 90);
                
            }
            row.Cells.Add(new DataGridViewTextBoxCell { Value = tangent });

            if (row.Cells.Count > 0) 
            {
                dataGridView1.Rows.Add(row);
            }
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
