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
    public partial class AccessDataBase : Form
    {
        public AccessDataBase()
        {
            InitializeComponent();
        }

        private void AccessDataBase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Attendees' table. You can move, or remove it, as needed.
            this.attendeesTableAdapter.Fill(this.appData.Attendees);

        }
    }
}
