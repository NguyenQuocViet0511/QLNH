namespace WindowsFormsApp1.UI.Itemoder
{
    partial class billitem
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
            this.layout_oder = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // layout_oder
            // 
            this.layout_oder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_oder.Location = new System.Drawing.Point(0, 0);
            this.layout_oder.Name = "layout_oder";
            this.layout_oder.Padding = new System.Windows.Forms.Padding(20);
            this.layout_oder.Size = new System.Drawing.Size(941, 494);
            this.layout_oder.TabIndex = 0;
            // 
            // billitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 494);
            this.Controls.Add(this.layout_oder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "billitem";
            this.Text = "Itemoder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layout_oder;
    }
}