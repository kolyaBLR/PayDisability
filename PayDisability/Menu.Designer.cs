namespace PayDisability
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SumDay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataFinish = new System.Windows.Forms.DateTimePicker();
            this.dataStart = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listEmployes = new System.Windows.Forms.ComboBox();
            this.salary = new System.Windows.Forms.Label();
            this.experience = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.averageDay = new System.Windows.Forms.Label();
            this.averageMonth = new System.Windows.Forms.Label();
            this.disability = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.21053F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.28674F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 213);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.delete, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.add, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(540, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.68421F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.31579F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(95, 207);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // delete
            // 
            this.delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete.Location = new System.Drawing.Point(3, 103);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(89, 101);
            this.delete.TabIndex = 1;
            this.delete.Text = "Удалить сотрудника";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add.Location = new System.Drawing.Point(3, 3);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(89, 94);
            this.add.TabIndex = 0;
            this.add.Text = "Добавить сотрудника";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 207);
            this.panel1.TabIndex = 2;
            // 
            // SumDay
            // 
            this.SumDay.AutoSize = true;
            this.SumDay.Location = new System.Drawing.Point(317, 33);
            this.SumDay.Name = "SumDay";
            this.SumDay.Size = new System.Drawing.Size(40, 13);
            this.SumDay.TabIndex = 7;
            this.SumDay.Text = "0 дней";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "———";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Период нетрудоспособности";
            // 
            // dataFinish
            // 
            this.dataFinish.Location = new System.Drawing.Point(187, 27);
            this.dataFinish.Name = "dataFinish";
            this.dataFinish.Size = new System.Drawing.Size(124, 20);
            this.dataFinish.TabIndex = 4;
            this.dataFinish.ValueChanged += new System.EventHandler(this.dataFinishChanged);
            // 
            // dataStart
            // 
            this.dataStart.Location = new System.Drawing.Point(7, 27);
            this.dataStart.Name = "dataStart";
            this.dataStart.Size = new System.Drawing.Size(143, 20);
            this.dataStart.TabIndex = 3;
            this.dataStart.ValueChanged += new System.EventHandler(this.dataFinishChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "Меню";
            // 
            // listEmployes
            // 
            this.listEmployes.FormattingEnabled = true;
            this.listEmployes.Location = new System.Drawing.Point(3, 28);
            this.listEmployes.Name = "listEmployes";
            this.listEmployes.Size = new System.Drawing.Size(143, 21);
            this.listEmployes.TabIndex = 8;
            this.listEmployes.SelectedIndexChanged += new System.EventHandler(this.listEmployes_SelectedIndexChanged);
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Location = new System.Drawing.Point(118, 57);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(0, 13);
            this.salary.TabIndex = 9;
            // 
            // experience
            // 
            this.experience.AutoSize = true;
            this.experience.Location = new System.Drawing.Point(118, 84);
            this.experience.Name = "experience";
            this.experience.Size = new System.Drawing.Size(0, 13);
            this.experience.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataFinish);
            this.panel2.Controls.Add(this.dataStart);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.SumDay);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(9, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 66);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.listEmployes);
            this.panel3.Controls.Add(this.salary);
            this.panel3.Controls.Add(this.experience);
            this.panel3.Location = new System.Drawing.Point(9, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 123);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.disability);
            this.panel4.Controls.Add(this.averageMonth);
            this.panel4.Controls.Add(this.averageDay);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(268, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 120);
            this.panel4.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Сотрудник";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Итоговый результат:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Средняя дневная зп:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Итоговая зп за месяц:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Сумма пособия:";
            // 
            // averageDay
            // 
            this.averageDay.AutoSize = true;
            this.averageDay.Location = new System.Drawing.Point(127, 21);
            this.averageDay.Name = "averageDay";
            this.averageDay.Size = new System.Drawing.Size(0, 13);
            this.averageDay.TabIndex = 4;
            // 
            // averageMonth
            // 
            this.averageMonth.AutoSize = true;
            this.averageMonth.Location = new System.Drawing.Point(137, 39);
            this.averageMonth.Name = "averageMonth";
            this.averageMonth.Size = new System.Drawing.Size(0, 13);
            this.averageMonth.TabIndex = 5;
            // 
            // disability
            // 
            this.disability.AutoSize = true;
            this.disability.Location = new System.Drawing.Point(105, 58);
            this.disability.Name = "disability";
            this.disability.Size = new System.Drawing.Size(0, 13);
            this.disability.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Средняя зарплата:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Стаж (в годах):";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 237);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dataFinish;
        private System.Windows.Forms.DateTimePicker dataStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SumDay;
        private System.Windows.Forms.ComboBox listEmployes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.Label experience;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label disability;
        private System.Windows.Forms.Label averageMonth;
        private System.Windows.Forms.Label averageDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

