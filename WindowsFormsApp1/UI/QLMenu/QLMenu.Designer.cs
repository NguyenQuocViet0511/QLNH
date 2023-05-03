namespace WindowsFormsApp1.UI.QLMenu
{
    partial class QLMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_food = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_foodid = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX11 = new DevComponents.DotNetBar.ButtonX();
            this.txt_foodname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbn_categoryfood = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txt_discountfood = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_last = new DevComponents.DotNetBar.ButtonX();
            this.btn_next = new DevComponents.DotNetBar.ButtonX();
            this.btn_prev = new DevComponents.DotNetBar.ButtonX();
            this.btn_first = new DevComponents.DotNetBar.ButtonX();
            this.btn_delete = new DevComponents.DotNetBar.ButtonX();
            this.btn_edit = new DevComponents.DotNetBar.ButtonX();
            this.btn_add = new DevComponents.DotNetBar.ButtonX();
            this.txt_foodprice = new WindowsFormsApp1.Customer.numbertextbox();
            this.idFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countfood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.images = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_food)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_food
            // 
            this.dgv_food.AllowUserToAddRows = false;
            this.dgv_food.AllowUserToDeleteRows = false;
            this.dgv_food.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(208)))), ((int)(((byte)(243)))));
            this.dgv_food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_food.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFood,
            this.foodname,
            this.price,
            this.discount,
            this.countfood,
            this.images,
            this.status,
            this.category_name,
            this.id_category});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_food.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_food.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_food.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_food.Location = new System.Drawing.Point(0, 85);
            this.dgv_food.Name = "dgv_food";
            this.dgv_food.ReadOnly = true;
            this.dgv_food.Size = new System.Drawing.Size(798, 480);
            this.dgv_food.TabIndex = 50;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Controls.Add(this.textBoxX1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(798, 85);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Kiếm :";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX1.Location = new System.Drawing.Point(14, 37);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(765, 27);
            this.textBoxX1.TabIndex = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.txt_foodid);
            this.groupPanel2.Controls.Add(this.txt_foodprice);
            this.groupPanel2.Controls.Add(this.buttonX11);
            this.groupPanel2.Controls.Add(this.txt_foodname);
            this.groupPanel2.Controls.Add(this.cbn_categoryfood);
            this.groupPanel2.Controls.Add(this.txt_discountfood);
            this.groupPanel2.Controls.Add(this.labelX7);
            this.groupPanel2.Controls.Add(this.labelX8);
            this.groupPanel2.Controls.Add(this.labelX9);
            this.groupPanel2.Controls.Add(this.labelX10);
            this.groupPanel2.Controls.Add(this.pictureBox1);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupPanel2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel2.Location = new System.Drawing.Point(798, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(645, 565);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 48;
            this.groupPanel2.Text = "Thông Tin";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(246, 42);
            this.labelX1.Name = "labelX1";
            this.labelX1.SingleLineColor = System.Drawing.SystemColors.Control;
            this.labelX1.Size = new System.Drawing.Size(43, 31);
            this.labelX1.TabIndex = 26;
            this.labelX1.Text = "ID :";
            // 
            // txt_foodid
            // 
            // 
            // 
            // 
            this.txt_foodid.Border.Class = "TextBoxBorder";
            this.txt_foodid.Enabled = false;
            this.txt_foodid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_foodid.Location = new System.Drawing.Point(246, 79);
            this.txt_foodid.Name = "txt_foodid";
            this.txt_foodid.Size = new System.Drawing.Size(380, 35);
            this.txt_foodid.TabIndex = 25;
            // 
            // buttonX11
            // 
            this.buttonX11.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX11.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX11.Location = new System.Drawing.Point(15, 284);
            this.buttonX11.Name = "buttonX11";
            this.buttonX11.Size = new System.Drawing.Size(200, 35);
            this.buttonX11.TabIndex = 22;
            this.buttonX11.Text = "Thêm Ảnh";
            // 
            // txt_foodname
            // 
            // 
            // 
            // 
            this.txt_foodname.Border.Class = "TextBoxBorder";
            this.txt_foodname.Enabled = false;
            this.txt_foodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_foodname.Location = new System.Drawing.Point(246, 157);
            this.txt_foodname.Name = "txt_foodname";
            this.txt_foodname.Size = new System.Drawing.Size(380, 35);
            this.txt_foodname.TabIndex = 20;
            // 
            // cbn_categoryfood
            // 
            this.cbn_categoryfood.DisplayMember = "Text";
            this.cbn_categoryfood.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbn_categoryfood.Enabled = false;
            this.cbn_categoryfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbn_categoryfood.FormattingEnabled = true;
            this.cbn_categoryfood.ItemHeight = 29;
            this.cbn_categoryfood.Location = new System.Drawing.Point(389, 284);
            this.cbn_categoryfood.Name = "cbn_categoryfood";
            this.cbn_categoryfood.Size = new System.Drawing.Size(241, 35);
            this.cbn_categoryfood.TabIndex = 16;
            // 
            // txt_discountfood
            // 
            // 
            // 
            // 
            this.txt_discountfood.Border.Class = "TextBoxBorder";
            this.txt_discountfood.Enabled = false;
            this.txt_discountfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discountfood.Location = new System.Drawing.Point(389, 344);
            this.txt_discountfood.Name = "txt_discountfood";
            this.txt_discountfood.Size = new System.Drawing.Size(241, 35);
            this.txt_discountfood.TabIndex = 14;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.labelX7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(246, 194);
            this.labelX7.Name = "labelX7";
            this.labelX7.SingleLineColor = System.Drawing.SystemColors.Control;
            this.labelX7.Size = new System.Drawing.Size(128, 38);
            this.labelX7.TabIndex = 10;
            this.labelX7.Text = "Giá Tiền :";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.labelX8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(246, 344);
            this.labelX8.Name = "labelX8";
            this.labelX8.SingleLineColor = System.Drawing.SystemColors.Control;
            this.labelX8.Size = new System.Drawing.Size(126, 39);
            this.labelX8.TabIndex = 9;
            this.labelX8.Text = "Giảm Giá :";
            // 
            // labelX9
            // 
            this.labelX9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(246, 284);
            this.labelX9.Name = "labelX9";
            this.labelX9.SingleLineColor = System.Drawing.SystemColors.Control;
            this.labelX9.Size = new System.Drawing.Size(128, 37);
            this.labelX9.TabIndex = 8;
            this.labelX9.Text = "Danh Mục :";
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.labelX10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(246, 120);
            this.labelX10.Name = "labelX10";
            this.labelX10.SingleLineColor = System.Drawing.SystemColors.Control;
            this.labelX10.Size = new System.Drawing.Size(155, 31);
            this.labelX10.TabIndex = 7;
            this.labelX10.Text = "Tên Món Ăn :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.btn_last);
            this.panel2.Controls.Add(this.btn_next);
            this.panel2.Controls.Add(this.btn_prev);
            this.panel2.Controls.Add(this.btn_first);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 565);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1443, 60);
            this.panel2.TabIndex = 47;
            // 
            // btn_last
            // 
            this.btn_last.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_last.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_last.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last.Location = new System.Drawing.Point(193, 16);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(46, 32);
            this.btn_last.TabIndex = 46;
            this.btn_last.Text = ">>";
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_next
            // 
            this.btn_next.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_next.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_next.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(137, 16);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(46, 32);
            this.btn_next.TabIndex = 45;
            this.btn_next.Text = ">";
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_prev.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_prev.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev.Location = new System.Drawing.Point(70, 16);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(46, 32);
            this.btn_prev.TabIndex = 44;
            this.btn_prev.Text = "<";
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_first
            // 
            this.btn_first.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_first.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_first.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_first.Location = new System.Drawing.Point(14, 16);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(46, 32);
            this.btn_first.TabIndex = 43;
            this.btn_first.Text = "<<";
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(1295, 16);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(105, 32);
            this.btn_delete.TabIndex = 28;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_edit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_edit.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(1147, 16);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(101, 32);
            this.btn_edit.TabIndex = 27;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(982, 16);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(110, 32);
            this.btn_add.TabIndex = 26;
            this.btn_add.Text = "Thêm";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_foodprice
            // 
            this.txt_foodprice.Enabled = false;
            this.txt_foodprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_foodprice.Location = new System.Drawing.Point(246, 228);
            this.txt_foodprice.Name = "txt_foodprice";
            this.txt_foodprice.Size = new System.Drawing.Size(380, 35);
            this.txt_foodprice.TabIndex = 24;
            // 
            // idFood
            // 
            this.idFood.DataPropertyName = "id";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idFood.DefaultCellStyle = dataGridViewCellStyle1;
            this.idFood.HeaderText = "Mã Món Ăn";
            this.idFood.Name = "idFood";
            this.idFood.ReadOnly = true;
            // 
            // foodname
            // 
            this.foodname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.foodname.DataPropertyName = "name";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodname.DefaultCellStyle = dataGridViewCellStyle2;
            this.foodname.HeaderText = "Tên Món Ăn";
            this.foodname.Name = "foodname";
            this.foodname.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // discount
            // 
            this.discount.DataPropertyName = "discount";
            this.discount.HeaderText = "Giảm Giá";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // countfood
            // 
            this.countfood.DataPropertyName = "count";
            this.countfood.HeaderText = "Số Lượng Bán";
            this.countfood.Name = "countfood";
            this.countfood.ReadOnly = true;
            // 
            // images
            // 
            this.images.DataPropertyName = "images";
            this.images.HeaderText = "Hình ảnh";
            this.images.Name = "images";
            this.images.ReadOnly = true;
            this.images.Visible = false;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Trạng thái";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Visible = false;
            // 
            // category_name
            // 
            this.category_name.DataPropertyName = "category_name";
            this.category_name.HeaderText = "Danh Mục";
            this.category_name.Name = "category_name";
            this.category_name.ReadOnly = true;
            // 
            // id_category
            // 
            this.id_category.DataPropertyName = "id_category";
            this.id_category.HeaderText = "id_category";
            this.id_category.Name = "id_category";
            this.id_category.ReadOnly = true;
            this.id_category.Visible = false;
            // 
            // QLMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 625);
            this.Controls.Add(this.dgv_food);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLMenu";
            this.Text = "QLMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_food)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_food;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_foodid;
        private Customer.numbertextbox txt_foodprice;
        private DevComponents.DotNetBar.ButtonX buttonX11;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_foodname;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbn_categoryfood;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_discountfood;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX btn_last;
        private DevComponents.DotNetBar.ButtonX btn_next;
        private DevComponents.DotNetBar.ButtonX btn_prev;
        private DevComponents.DotNetBar.ButtonX btn_first;
        private DevComponents.DotNetBar.ButtonX btn_delete;
        private DevComponents.DotNetBar.ButtonX btn_edit;
        private DevComponents.DotNetBar.ButtonX btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodname;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn countfood;
        private System.Windows.Forms.DataGridViewTextBoxColumn images;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_category;
    }
}