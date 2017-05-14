using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayDisability
{
    public partial class AddEmployes : Form
    {
        public AddEmployes()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            sqlQuery sql = new sqlQuery();
            sql.addUser(name, salary, experience);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
