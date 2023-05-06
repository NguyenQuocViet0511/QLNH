namespace WindowsFormsApp1.Customer
{
    partial class Food
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.lbl_name = new DevComponents.DotNetBar.LabelX();
            this.images_food = new System.Windows.Forms.PictureBox();
            this.lbl_sum = new DevComponents.DotNetBar.LabelX();
            this.ribbonClientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.images_food)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Controls.Add(this.lbl_sum);
            this.ribbonClientPanel1.Controls.Add(this.images_food);
            this.ribbonClientPanel1.Controls.Add(this.lbl_name);
            this.ribbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonClientPanel1.Location = new System.Drawing.Point(0, 0);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(225, 215);
            // 
            // 
            // 
            this.ribbonClientPanel1.Style.Class = "RibbonClientPanel";
            this.ribbonClientPanel1.Style.CornerDiameter = 5;
            this.ribbonClientPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ribbonClientPanel1.TabIndex = 0;
            this.ribbonClientPanel1.Text = "ribbonClientPanel1";
            // 
            // lbl_name
            // 
            this.lbl_name.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_name.BackColor = System.Drawing.Color.White;
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(0, 171);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(225, 44);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Bò Né";
            this.lbl_name.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // images_food
            // 
            this.images_food.Dock = System.Windows.Forms.DockStyle.Fill;
            this.images_food.Image = global::WindowsFormsApp1.Properties.Resources.foody_upload_api_foody_mobile_ne_jpg_180504170627;
            this.images_food.Location = new System.Drawing.Point(0, 0);
            this.images_food.Name = "images_food";
            this.images_food.Size = new System.Drawing.Size(225, 171);
            this.images_food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.images_food.TabIndex = 5;
            this.images_food.TabStop = false;
            // 
            // lbl_sum
            // 
            this.lbl_sum.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lbl_sum.BackgroundStyle.CornerDiameter = 15;
            this.lbl_sum.BackgroundStyle.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.lbl_sum.BackgroundStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.lbl_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sum.Location = new System.Drawing.Point(131, 3);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(91, 37);
            this.lbl_sum.TabIndex = 6;
            this.lbl_sum.Text = "190k";
            this.lbl_sum.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonClientPanel1);
            this.Name = "Food";
            this.Size = new System.Drawing.Size(225, 215);
            this.ribbonClientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.images_food)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private DevComponents.DotNetBar.LabelX lbl_sum;
        private System.Windows.Forms.PictureBox images_food;
        private DevComponents.DotNetBar.LabelX lbl_name;
    }
}
