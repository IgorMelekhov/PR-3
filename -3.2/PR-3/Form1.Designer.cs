namespace PR_3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button3Exit = new System.Windows.Forms.Button();
            this.groupBoxMatrix = new System.Windows.Forms.GroupBox();
            this.CreateAMatrixWithDoubles = new System.Windows.Forms.Button();
            this.CreateAMatrixWithIntegers = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Summ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lines = new System.Windows.Forms.TextBox();
            this.columns = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.referenceToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(434, 24);
            this.menuStrip2.TabIndex = 21;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cleanToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // cleanToolStripMenuItem
            // 
            this.cleanToolStripMenuItem.Name = "cleanToolStripMenuItem";
            this.cleanToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.cleanToolStripMenuItem.Text = "Очистить";
            this.cleanToolStripMenuItem.Click += new System.EventHandler(this.cleanToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // referenceToolStripMenuItem
            // 
            this.referenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
            this.referenceToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.referenceToolStripMenuItem.Text = "Справка";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button3Exit
            // 
            this.button3Exit.Location = new System.Drawing.Point(342, 59);
            this.button3Exit.Name = "button3Exit";
            this.button3Exit.Size = new System.Drawing.Size(62, 21);
            this.button3Exit.TabIndex = 25;
            this.button3Exit.Text = "Выйти";
            this.button3Exit.UseVisualStyleBackColor = true;
            this.button3Exit.Click += new System.EventHandler(this.button3Exit_Click);
            // 
            // groupBoxMatrix
            // 
            this.groupBoxMatrix.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxMatrix.Location = new System.Drawing.Point(5, 64);
            this.groupBoxMatrix.Name = "groupBoxMatrix";
            this.groupBoxMatrix.Size = new System.Drawing.Size(417, 150);
            this.groupBoxMatrix.TabIndex = 22;
            this.groupBoxMatrix.TabStop = false;
            this.groupBoxMatrix.Text = "Значения:";
            // 
            // CreateAMatrixWithDoubles
            // 
            this.CreateAMatrixWithDoubles.Location = new System.Drawing.Point(241, 11);
            this.CreateAMatrixWithDoubles.Name = "CreateAMatrixWithDoubles";
            this.CreateAMatrixWithDoubles.Size = new System.Drawing.Size(166, 34);
            this.CreateAMatrixWithDoubles.TabIndex = 37;
            this.CreateAMatrixWithDoubles.Text = "Создать матрицу\r\nс вещественными цифрами\r\n\r\n";
            this.CreateAMatrixWithDoubles.UseVisualStyleBackColor = true;
            this.CreateAMatrixWithDoubles.Click += new System.EventHandler(this.CreateAMatrixWithDoubles_Click);
            // 
            // CreateAMatrixWithIntegers
            // 
            this.CreateAMatrixWithIntegers.Location = new System.Drawing.Point(241, 51);
            this.CreateAMatrixWithIntegers.Name = "CreateAMatrixWithIntegers";
            this.CreateAMatrixWithIntegers.Size = new System.Drawing.Size(166, 34);
            this.CreateAMatrixWithIntegers.TabIndex = 6;
            this.CreateAMatrixWithIntegers.Text = "Создать матрицу\r\nс целыми цифрами \r\n\r\n";
            this.CreateAMatrixWithIntegers.UseVisualStyleBackColor = true;
            this.CreateAMatrixWithIntegers.Click += new System.EventHandler(this.CreateAMatrixWithIntegers_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.Summ);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button3Exit);
            this.groupBox2.Location = new System.Drawing.Point(6, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 86);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.CreateAMatrixWithIntegers);
            this.groupBox1.Controls.Add(this.CreateAMatrixWithDoubles);
            this.groupBox1.Controls.Add(this.columns);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lines);
            this.groupBox1.Location = new System.Drawing.Point(6, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 87);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // Summ
            // 
            this.Summ.Location = new System.Drawing.Point(6, 60);
            this.Summ.Name = "Summ";
            this.Summ.ReadOnly = true;
            this.Summ.Size = new System.Drawing.Size(257, 20);
            this.Summ.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Сумма модулей элементов после первого отрицательного\r\n";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(361, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "Программа генерирует прямоугольную матрицу с цифрами от -9 до 9\r\n\r\n";
            // 
            // lines
            // 
            this.lines.Location = new System.Drawing.Point(132, 19);
            this.lines.Name = "lines";
            this.lines.Size = new System.Drawing.Size(82, 20);
            this.lines.TabIndex = 38;
            // 
            // columns
            // 
            this.columns.Location = new System.Drawing.Point(132, 59);
            this.columns.Name = "columns";
            this.columns.Size = new System.Drawing.Size(82, 20);
            this.columns.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Количество строк \r\n(максимум 5)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 40;
            this.label2.Text = "Количество столбцов \r\n(максимум 5)";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBoxMatrix);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.MaximumSize = new System.Drawing.Size(450, 450);
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "Form1";
            this.Text = "Матричное приложение";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cleanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button3Exit;
        private System.Windows.Forms.GroupBox groupBoxMatrix;
        private System.Windows.Forms.Button CreateAMatrixWithIntegers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Summ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button CreateAMatrixWithDoubles;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox columns;
        private System.Windows.Forms.TextBox lines;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

