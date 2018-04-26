namespace WindowsFormsApp2
{
    partial class boxpara
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Disciplinelist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Disciplinelist
            // 
            this.Disciplinelist.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Disciplinelist.FormattingEnabled = true;
            this.Disciplinelist.Location = new System.Drawing.Point(12, 12);
            this.Disciplinelist.Name = "Disciplinelist";
            this.Disciplinelist.Size = new System.Drawing.Size(398, 264);
            this.Disciplinelist.TabIndex = 14;
            this.Disciplinelist.SelectedIndexChanged += new System.EventHandler(this.Disciplinelist_SelectedIndexChanged);
            this.Disciplinelist.DoubleClick += new System.EventHandler(this.Disciplinelist_DoubleClick);
            // 
            // boxpara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 290);
            this.Controls.Add(this.Disciplinelist);
            this.Name = "boxpara";
            this.Text = "boxpara";
            this.Load += new System.EventHandler(this.boxpara_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Disciplinelist;
    }
}