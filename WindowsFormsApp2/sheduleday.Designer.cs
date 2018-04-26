namespace WindowsFormsApp2
{
    partial class sheduleday
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paraday5 = new WindowsFormsApp2.paraday();
            this.paraday4 = new WindowsFormsApp2.paraday();
            this.paraday3 = new WindowsFormsApp2.paraday();
            this.paraday2 = new WindowsFormsApp2.paraday();
            this.paraday1 = new WindowsFormsApp2.paraday();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paraday5);
            this.groupBox1.Controls.Add(this.paraday4);
            this.groupBox1.Controls.Add(this.paraday3);
            this.groupBox1.Controls.Add(this.paraday2);
            this.groupBox1.Controls.Add(this.paraday1);
            this.groupBox1.Location = new System.Drawing.Point(0, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 391);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "День недели";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // paraday5
            // 
            this.paraday5.Location = new System.Drawing.Point(3, 313);
            this.paraday5.Name = "paraday5";
            this.paraday5.Size = new System.Drawing.Size(556, 73);
            this.paraday5.TabIndex = 4;
            this.paraday5.Load += new System.EventHandler(this.paraday5_Load);
            // 
            // paraday4
            // 
            this.paraday4.Location = new System.Drawing.Point(3, 244);
            this.paraday4.Name = "paraday4";
            this.paraday4.Size = new System.Drawing.Size(556, 73);
            this.paraday4.TabIndex = 3;
            this.paraday4.Load += new System.EventHandler(this.paraday4_Load);
            // 
            // paraday3
            // 
            this.paraday3.Location = new System.Drawing.Point(1, 166);
            this.paraday3.Name = "paraday3";
            this.paraday3.Size = new System.Drawing.Size(556, 73);
            this.paraday3.TabIndex = 2;
            this.paraday3.Load += new System.EventHandler(this.paraday3_Load);
            // 
            // paraday2
            // 
            this.paraday2.Location = new System.Drawing.Point(2, 88);
            this.paraday2.Name = "paraday2";
            this.paraday2.Size = new System.Drawing.Size(556, 73);
            this.paraday2.TabIndex = 1;
            this.paraday2.Load += new System.EventHandler(this.paraday2_Load);
            // 
            // paraday1
            // 
            this.paraday1.AllowDrop = true;
            this.paraday1.Location = new System.Drawing.Point(3, 19);
            this.paraday1.Name = "paraday1";
            this.paraday1.Size = new System.Drawing.Size(556, 73);
            this.paraday1.TabIndex = 0;
            this.paraday1.Load += new System.EventHandler(this.paraday1_Load);
            // 
            // sheduleday
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "sheduleday";
            this.Size = new System.Drawing.Size(568, 398);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private paraday paraday5;
        private paraday paraday4;
        private paraday paraday3;
        private paraday paraday2;
        private paraday paraday1;
    }
}
