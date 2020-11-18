namespace Lab5
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
            this.Teacher = new System.Windows.Forms.TextBox();
            this.textSubj = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TeacherOn = new System.Windows.Forms.Button();
            this.SubjectOn = new System.Windows.Forms.Button();
            this.textSubject = new System.Windows.Forms.TextBox();
            this.textTeacher = new System.Windows.Forms.TextBox();
            this.Remove = new System.Windows.Forms.Button();
            this.textIndex = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Teacher
            // 
            this.Teacher.Location = new System.Drawing.Point(634, 84);
            this.Teacher.Name = "Teacher";
            this.Teacher.Size = new System.Drawing.Size(100, 20);
            this.Teacher.TabIndex = 0;
            // 
            // textSubj
            // 
            this.textSubj.Location = new System.Drawing.Point(634, 134);
            this.textSubj.Name = "textSubj";
            this.textSubj.Size = new System.Drawing.Size(100, 20);
            this.textSubj.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(647, 199);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.subject});
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(491, 197);
            this.dataGridView1.TabIndex = 3;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // subject
            // 
            this.subject.HeaderText = "Subject";
            this.subject.Name = "subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Преподаватель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Предмет";
            // 
            // TeacherOn
            // 
            this.TeacherOn.Location = new System.Drawing.Point(31, 316);
            this.TeacherOn.Name = "TeacherOn";
            this.TeacherOn.Size = new System.Drawing.Size(75, 23);
            this.TeacherOn.TabIndex = 6;
            this.TeacherOn.Text = "Добавить";
            this.TeacherOn.UseVisualStyleBackColor = true;
            this.TeacherOn.Click += new System.EventHandler(this.TeacherOn_Click);
            // 
            // SubjectOn
            // 
            this.SubjectOn.Location = new System.Drawing.Point(31, 378);
            this.SubjectOn.Name = "SubjectOn";
            this.SubjectOn.Size = new System.Drawing.Size(75, 23);
            this.SubjectOn.TabIndex = 7;
            this.SubjectOn.Text = "Добавить";
            this.SubjectOn.UseVisualStyleBackColor = true;
            this.SubjectOn.Click += new System.EventHandler(this.SubjectOn_Click);
            // 
            // textSubject
            // 
            this.textSubject.Location = new System.Drawing.Point(159, 319);
            this.textSubject.Name = "textSubject";
            this.textSubject.Size = new System.Drawing.Size(100, 20);
            this.textSubject.TabIndex = 8;
            // 
            // textTeacher
            // 
            this.textTeacher.Location = new System.Drawing.Point(159, 381);
            this.textTeacher.Name = "textTeacher";
            this.textTeacher.Size = new System.Drawing.Size(100, 20);
            this.textTeacher.TabIndex = 9;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(340, 317);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 10;
            this.Remove.Text = "Добавить";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // textIndex
            // 
            this.textIndex.Location = new System.Drawing.Point(445, 320);
            this.textIndex.Name = "textIndex";
            this.textIndex.Size = new System.Drawing.Size(100, 20);
            this.textIndex.TabIndex = 11;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(634, 378);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 12;
            this.Save.Text = "Добавить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(31, 12);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 13;
            this.Start.Text = "Добавить";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.textIndex);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.textTeacher);
            this.Controls.Add(this.textSubject);
            this.Controls.Add(this.SubjectOn);
            this.Controls.Add(this.TeacherOn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.textSubj);
            this.Controls.Add(this.Teacher);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Teacher;
        private System.Windows.Forms.TextBox textSubj;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TeacherOn;
        private System.Windows.Forms.Button SubjectOn;
        private System.Windows.Forms.TextBox textSubject;
        private System.Windows.Forms.TextBox textTeacher;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.TextBox textIndex;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button button1;
    }
}

