namespace WindowsFormsApp2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Grouplist = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.sheduleweek1 = new WindowsFormsApp2.sheduleweek();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Teacherlist = new System.Windows.Forms.ListBox();
            this.Disciplinelist = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Audiencelist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(44, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.Location = new System.Drawing.Point(44, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(44, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Отправить на сайт";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Grouplist
            // 
            this.Grouplist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Grouplist.FormattingEnabled = true;
            this.Grouplist.Location = new System.Drawing.Point(54, 94);
            this.Grouplist.Name = "Grouplist";
            this.Grouplist.Size = new System.Drawing.Size(121, 21);
            this.Grouplist.TabIndex = 3;
            this.Grouplist.SelectedIndexChanged += new System.EventHandler(this.Grouplist_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.Brown;
            this.button4.Location = new System.Drawing.Point(44, 443);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 31);
            this.button4.TabIndex = 4;
            this.button4.Text = "Отчистить поля";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(54, 113);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.Brown;
            this.button5.Location = new System.Drawing.Point(44, 473);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 31);
            this.button5.TabIndex = 9;
            this.button5.Text = "Баг трекер";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Количество часов:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthCalendar1.Location = new System.Drawing.Point(34, 143);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // sheduleweek1
            // 
            this.sheduleweek1.AllowDrop = true;
            this.sheduleweek1.Location = new System.Drawing.Point(210, 20);
            this.sheduleweek1.Name = "sheduleweek1";
            this.sheduleweek1.Size = new System.Drawing.Size(1255, 791);
            this.sheduleweek1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1219, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Предподаватели";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1219, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Дисциплины";
            // 
            // Teacherlist
            // 
            this.Teacherlist.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Teacherlist.FormattingEnabled = true;
            this.Teacherlist.Location = new System.Drawing.Point(1215, 38);
            this.Teacherlist.Name = "Teacherlist";
            this.Teacherlist.Size = new System.Drawing.Size(250, 186);
            this.Teacherlist.TabIndex = 0;
            // 
            // Disciplinelist
            // 
            this.Disciplinelist.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Disciplinelist.FormattingEnabled = true;
            this.Disciplinelist.Location = new System.Drawing.Point(1215, 243);
            this.Disciplinelist.Name = "Disciplinelist";
            this.Disciplinelist.Size = new System.Drawing.Size(250, 147);
            this.Disciplinelist.TabIndex = 13;
            this.Disciplinelist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Disciplinelist_MouseDown);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1219, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Аудитории";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Audiencelist
            // 
            this.Audiencelist.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Audiencelist.FormattingEnabled = true;
            this.Audiencelist.Location = new System.Drawing.Point(1215, 409);
            this.Audiencelist.Name = "Audiencelist";
            this.Audiencelist.Size = new System.Drawing.Size(250, 173);
            this.Audiencelist.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1477, 847);
            this.Controls.Add(this.sheduleweek1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Audiencelist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Disciplinelist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Teacherlist);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Grouplist);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox Grouplist;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private sheduleweek sheduleweek1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Teacherlist;
        private System.Windows.Forms.ListBox Disciplinelist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Audiencelist;
    }
}

