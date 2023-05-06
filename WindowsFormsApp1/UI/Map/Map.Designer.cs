namespace WindowsFormsApp1.UI.Map
{
    partial class Map
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
            this.layout_map = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxEx2 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_oder = new DevComponents.DotNetBar.ButtonX();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout_map
            // 
            this.layout_map.AutoScroll = true;
            this.layout_map.BackColor = System.Drawing.Color.Silver;
            this.layout_map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layout_map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_map.Location = new System.Drawing.Point(0, 56);
            this.layout_map.Margin = new System.Windows.Forms.Padding(10);
            this.layout_map.Name = "layout_map";
            this.layout_map.Padding = new System.Windows.Forms.Padding(20);
            this.layout_map.Size = new System.Drawing.Size(1118, 592);
            this.layout_map.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_oder);
            this.panel2.Controls.Add(this.comboBoxEx2);
            this.panel2.Controls.Add(this.textBoxX2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 56);
            this.panel2.TabIndex = 4;
            // 
            // comboBoxEx2
            // 
            this.comboBoxEx2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEx2.DisabledBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxEx2.DisplayMember = "Text";
            this.comboBoxEx2.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.comboBoxEx2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEx2.FormattingEnabled = true;
            this.comboBoxEx2.ItemHeight = 23;
            this.comboBoxEx2.Location = new System.Drawing.Point(749, 12);
            this.comboBoxEx2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.comboBoxEx2.Name = "comboBoxEx2";
            this.comboBoxEx2.Size = new System.Drawing.Size(222, 31);
            this.comboBoxEx2.TabIndex = 1;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxX2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            // 
            // 
            // 
            this.textBoxX2.Border.BackColorBlend.AddRange(new DevComponents.DotNetBar.BackgroundColorBlend[] {
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.Empty, 0F)});
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerDiameter = 5;
            this.textBoxX2.Border.PaddingBottom = 2;
            this.textBoxX2.Border.PaddingLeft = 2;
            this.textBoxX2.Border.PaddingRight = 2;
            this.textBoxX2.Border.PaddingTop = 2;
            this.textBoxX2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX2.Location = new System.Drawing.Point(10, 12);
            this.textBoxX2.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(726, 31);
            this.textBoxX2.TabIndex = 0;
            this.textBoxX2.WatermarkText = "Nhập vào tên bàn cần tìm";
            // 
            // btn_oder
            // 
            this.btn_oder.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btn_oder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_oder.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_oder.Location = new System.Drawing.Point(1000, 12);
            this.btn_oder.Name = "btn_oder";
            this.btn_oder.Size = new System.Drawing.Size(105, 30);
            this.btn_oder.TabIndex = 2;
            this.btn_oder.Text = "Oder";
            this.btn_oder.Click += new System.EventHandler(this.btn_oder_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 648);
            this.Controls.Add(this.layout_map);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Map";
            this.Text = "Map";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layout_map;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.ButtonX btn_oder;
    }
}