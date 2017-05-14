using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayDisability
{
    class sqlQuery
    {
        public void deleteUser(DataGridView dgv)
        {
            try
            {
                ConnectionString connect = new ConnectionString();
                using (SqlConnection con = new SqlConnection(connect.connect))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand("delete from [Employes] where name = @name", con))
                    {
                        com.Parameters.AddWithValue("@name", dgv.Rows[dgv.CurrentRow.Index].Cells[dgv.CurrentCell.ColumnIndex].Value);
                        com.ExecuteNonQuery();
                        dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
                    }
                }
                MessageBox.Show("Работник успешно удалён.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void addUser(TextBox name, TextBox salary, TextBox experience)
        {
            try
            {
                ConnectionString connect = new ConnectionString();
                using (SqlConnection con = new SqlConnection(connect.connect))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand("insert into [Employes]([name], [salary], [experience]) values(@name, @salary, @experience)", con))
                    {
                        com.Parameters.AddWithValue("@name", name.Text);
                        com.Parameters.AddWithValue("@salary", salary.Text);
                        com.Parameters.AddWithValue("@experience", experience.Text);
                        com.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Пользователь успешно добавлен.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void openList(ComboBox listEmployes, Label salary, Label experience)
        {
            try
            {
                for (int i = 1; i < listEmployes.Items.Count; i++)
                {
                    if (listEmployes.Text == listEmployes.Items[i].ToString())
                    {
                        ConnectionString connect = new ConnectionString();
                        using (SqlConnection SqlCon = new SqlConnection(connect.connect))
                        {
                            SqlCon.Open();
                            using (SqlCommand SqlCom = new SqlCommand("SELECT [salary], [experience] FROM Employes WHERE name='" + listEmployes.Items[i] + "'", SqlCon))
                            {
                                SqlDataReader r = SqlCom.ExecuteReader();
                                while (r.Read())
                                {
                                    salary.Text = r.GetDouble(0).ToString();
                                    experience.Text = r.GetInt32(1).ToString();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getEmployes(ComboBox combo)
        {
            try
            {
                ConnectionString connect = new ConnectionString();
                using (SqlConnection con = new SqlConnection(connect.connect))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand("select [name] from [Employes]", con))
                    {
                        SqlDataReader r = com.ExecuteReader();
                        combo.Items.Clear();
                        combo.Items.Add("выбрать сотрудника");
                        while (r.Read())
                        {
                            combo.Items.Add(r.GetString(0));
                        }
                        r.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void addEmployes(Employes emp)
        {
            try
            {
                ConnectionString connect = new ConnectionString();
                using (SqlConnection con = new SqlConnection(connect.connect))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand("insert into [Employes]([name], [salary], [experience]) values(@name, @salary, @experience)", con))
                    {
                        com.Parameters.AddWithValue("@name", emp.name);
                        com.Parameters.AddWithValue("@salary", emp.salary);
                        com.Parameters.AddWithValue("@experience", emp.experience);
                        com.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Пользователь успешно добавлен.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
