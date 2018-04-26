namespace WindowsFormsApp2
{
    partial class sheduleweek
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
            this.sheduleday1 = new WindowsFormsApp2.sheduleday();
            this.sheduleday2 = new WindowsFormsApp2.sheduleday();
            this.sheduleday3 = new WindowsFormsApp2.sheduleday();
            this.sheduleday4 = new WindowsFormsApp2.sheduleday();
            this.sheduleday5 = new WindowsFormsApp2.sheduleday();
            this.sheduleday6 = new WindowsFormsApp2.sheduleday();
            this.SuspendLayout();
            // 
            // sheduleday1
            // 
            this.sheduleday1.AllowDrop = true;
            this.sheduleday1.Location = new System.Drawing.Point(4, 3);
            this.sheduleday1.Name = "sheduleday1";
            this.sheduleday1.Size = new System.Drawing.Size(391, 393);
            this.sheduleday1.TabIndex = 0;
            // 
            // sheduleday2
            // 
            this.sheduleday2.AllowDrop = true;
            this.sheduleday2.Location = new System.Drawing.Point(414, 2);
            this.sheduleday2.Name = "sheduleday2";
            this.sheduleday2.Size = new System.Drawing.Size(391, 393);
            this.sheduleday2.TabIndex = 1;
            // 
            // sheduleday3
            // 
            this.sheduleday3.AllowDrop = true;
            this.sheduleday3.Location = new System.Drawing.Point(827, 3);
            this.sheduleday3.Name = "sheduleday3";
            this.sheduleday3.Size = new System.Drawing.Size(391, 393);
            this.sheduleday3.TabIndex = 2;
            // 
            // sheduleday4
            // 
            this.sheduleday4.AllowDrop = true;
            this.sheduleday4.Location = new System.Drawing.Point(8, 402);
            this.sheduleday4.Name = "sheduleday4";
            this.sheduleday4.Size = new System.Drawing.Size(391, 392);
            this.sheduleday4.TabIndex = 3;
            // 
            // sheduleday5
            // 
            this.sheduleday5.AllowDrop = true;
            this.sheduleday5.Location = new System.Drawing.Point(418, 403);
            this.sheduleday5.Name = "sheduleday5";
            this.sheduleday5.Size = new System.Drawing.Size(391, 392);
            this.sheduleday5.TabIndex = 4;
            // 
            // sheduleday6
            // 
            this.sheduleday6.AllowDrop = true;
            this.sheduleday6.Location = new System.Drawing.Point(831, 402);
            this.sheduleday6.Name = "sheduleday6";
            this.sheduleday6.Size = new System.Drawing.Size(391, 392);
            this.sheduleday6.TabIndex = 5;
            // 
            // sheduleweek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sheduleday6);
            this.Controls.Add(this.sheduleday5);
            this.Controls.Add(this.sheduleday4);
            this.Controls.Add(this.sheduleday3);
            this.Controls.Add(this.sheduleday2);
            this.Controls.Add(this.sheduleday1);
            this.Name = "sheduleweek";
            this.Size = new System.Drawing.Size(1225, 798);
            this.Load += new System.EventHandler(this.sheduleweek_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private sheduleday sheduleday1;
        private sheduleday sheduleday2;
        private sheduleday sheduleday3;
        private sheduleday sheduleday4;
        private sheduleday sheduleday5;
        private sheduleday sheduleday6;
    }
}
