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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            TimeSpan time = dataFinish.Value - dataStart.Value;
            SumDay.Text = time.Days.ToString();
            sqlQuery sql = new sqlQuery();
            sql.getEmployes(listEmployes);
            average();
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddEmployes add = new AddEmployes();
            add.ShowDialog();
            sqlQuery sql = new sqlQuery();
            sql.getEmployes(listEmployes);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeleteEmployes del = new DeleteEmployes();
            del.ShowDialog();
            sqlQuery sql = new sqlQuery();
            sql.getEmployes(listEmployes);
        }

        private void dataFinishChanged(object sender, EventArgs e)
        {
            TimeSpan time = dataFinish.Value - dataStart.Value;
            SumDay.Text = time.Days.ToString();
            average();
        }

        private void listEmployes_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlQuery sql = new sqlQuery();
            sql.openList(listEmployes, salary, experience);
            average();
        }

        public void average()
        {
            try
            {
                double mrotBy = 239.42;
                double proc = 0;
                double sd = mrotBy * 24 / 730;
                double sp = 0;
                if (int.Parse(experience.Text) == 0)
                    sp = sd * proc * int.Parse(SumDay.Text);
                else
                {
                    if (int.Parse(experience.Text) >= 1 && int.Parse(experience.Text) < 5)
                        proc = 0.6;
                    else
                    if (int.Parse(experience.Text) >= 5 && int.Parse(experience.Text) < 8)
                        proc = 0.8;
                    else
                    if (int.Parse(experience.Text) > 8)
                        proc = 1;
                    sd = double.Parse(salary.Text) * 24 / 730;
                    sp = sd * proc * int.Parse(SumDay.Text);
                }
                averageDay.Text = Math.Round(sd, 2).ToString();
                averageMonth.Text = Math.Round((sp + (30 - int.Parse(SumDay.Text)) * double.Parse(salary.Text) / 30), 2).ToString();
                disability.Text = Math.Round(sp, 2).ToString();
            }
            catch
            {
                averageDay.Text = "";
                averageMonth.Text = "";
                disability.Text = "";
                experience.Text = "";
                salary.Text = "";
            }
        }
    }
}
