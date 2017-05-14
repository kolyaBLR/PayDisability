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
    public partial class DeleteEmployes : Form
    {
        public DeleteEmployes()
        {
            InitializeComponent();
            dgv.ColumnCount = 1;
            ConnectionString connect = new ConnectionString();
            using (SqlConnection SqlCon = new SqlConnection(connect.connect))
            {
                SqlCon.Open();
                using (SqlCommand SqlCom = new SqlCommand("select [name] from [Employes]", SqlCon))
                {
                    SqlDataReader r = SqlCom.ExecuteReader();
                    int index = 0;
                    while (r.Read())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[index].Cells[0].Value = r.GetString(0);
                        index++;
                    }
                    r.Close();
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            sqlQuery sql = new sqlQuery();
            sql.deleteUser(dgv);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
