namespace WindowsFormsApp1.UI.QLTable
{
    partial class QLTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.dgv_table = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_bill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tablestatus = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_nametable = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.btn_edit = new DevComponents.DotNetBar.ButtonX();
            this.btn_delete = new DevComponents.DotNetBar.ButtonX();
            this.btn_add = new DevComponents.DotNetBar.ButtonX();
            this.btn_last = new DevComponents.DotNetBar.ButtonX();
            this.btn_next = new DevComponents.DotNetBar.ButtonX();
            this.btn_prev = new DevComponents.DotNetBar.ButtonX();
            this.btn_first = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.panelEx4.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelEx3);
            this.panel1.Controls.Add(this.panelEx2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 681);
            this.panel1.TabIndex = 0;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx3.Controls.Add(this.dgv_table);
            this.panelEx3.Controls.Add(this.panelEx1);
            this.panelEx3.Controls.Add(this.panelEx4);
            this.panelEx3.Controls.Add(this.label2);
            this.panelEx3.Controls.Add(this.label1);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(1259, 619);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 2;
            this.panelEx3.Text = "panelEx3";
            // 
            // dgv_table
            // 
            this.dgv_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.status,
            this.id_bill});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_table.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_table.Location = new System.Drawing.Point(0, 103);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.Size = new System.Drawing.Size(810, 516);
            this.dgv_table.TabIndex = 33;
            this.dgv_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_table_CellContentClick_1);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã Bàn";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên Bàn";
            this.name.Name = "name";
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Trạng Thái";
            this.status.Name = "status";
            // 
            // id_bill
            // 
            this.id_bill.DataPropertyName = "id_bill";
            this.id_bill.HeaderText = "Mã Bill";
            this.id_bill.Name = "id_bill";
            this.id_bill.Visible = false;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.label3);
            this.panelEx1.Controls.Add(this.textBoxX1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(810, 103);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tìm Kiếm :";
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
            this.textBoxX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX1.Location = new System.Drawing.Point(31, 52);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(750, 30);
            this.textBoxX1.TabIndex = 24;
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx4.Controls.Add(this.groupPanel1);
            this.panelEx4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx4.Location = new System.Drawing.Point(810, 0);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(449, 619);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.TabIndex = 30;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.label6);
            this.groupPanel1.Controls.Add(this.txt_tablestatus);
            this.groupPanel1.Controls.Add(this.txt_nametable);
            this.groupPanel1.Controls.Add(this.label5);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.txt_id);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(449, 619);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 36;
            this.groupPanel1.Text = "Thông Tin";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Trạng Thái :";
            // 
            // txt_tablestatus
            // 
            this.txt_tablestatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_tablestatus.Border.Class = "TextBoxBorder";
            this.txt_tablestatus.Enabled = false;
            this.txt_tablestatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tablestatus.Location = new System.Drawing.Point(20, 255);
            this.txt_tablestatus.Name = "txt_tablestatus";
            this.txt_tablestatus.Size = new System.Drawing.Size(414, 30);
            this.txt_tablestatus.TabIndex = 40;
            // 
            // txt_nametable
            // 
            this.txt_nametable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_nametable.Border.Class = "TextBoxBorder";
            this.txt_nametable.Enabled = false;
            this.txt_nametable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nametable.Location = new System.Drawing.Point(20, 187);
            this.txt_nametable.Name = "txt_nametable";
            this.txt_nametable.Size = new System.Drawing.Size(414, 30);
            this.txt_nametable.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 38;
            this.label5.Text = "Mã bàn :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Tên Bàn :";
            // 
            // txt_id
            // 
            this.txt_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_id.Border.Class = "TextBoxBorder";
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(20, 119);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(414, 30);
            this.txt_id.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(783, -33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tên Danh Mục :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, -42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tìm Kiếm ";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx2.Controls.Add(this.btn_last);
            this.panelEx2.Controls.Add(this.btn_next);
            this.panelEx2.Controls.Add(this.btn_prev);
            this.panelEx2.Controls.Add(this.btn_first);
            this.panelEx2.Controls.Add(this.btn_edit);
            this.panelEx2.Controls.Add(this.btn_delete);
            this.panelEx2.Controls.Add(this.btn_add);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEx2.Location = new System.Drawing.Point(0, 619);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1259, 62);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            this.panelEx2.Text = "\'";
            // 
            // btn_edit
            // 
            this.btn_edit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_edit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(985, 15);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(114, 32);
            this.btn_edit.TabIndex = 38;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(1127, 15);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(114, 32);
            this.btn_delete.TabIndex = 37;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(822, 15);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(114, 32);
            this.btn_add.TabIndex = 36;
            this.btn_add.Text = "Thêm";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_last
            // 
            this.btn_last.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_last.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_last.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last.Location = new System.Drawing.Point(210, 18);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(46, 32);
            this.btn_last.TabIndex = 50;
            this.btn_last.Text = ">>";
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_next
            // 
            this.btn_next.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_next.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_next.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(154, 18);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(46, 32);
            this.btn_next.TabIndex = 49;
            this.btn_next.Text = ">";
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_prev.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_prev.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev.Location = new System.Drawing.Point(87, 18);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(46, 32);
            this.btn_prev.TabIndex = 48;
            this.btn_prev.Text = "<";
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_first
            // 
            this.btn_first.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_first.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_first.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_first.Location = new System.Drawing.Point(31, 18);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(46, 32);
            this.btn_first.TabIndex = 47;
            this.btn_first.Text = "<<";
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // QLTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 681);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLTable";
            this.Text = "<";
            this.panel1.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            this.panelEx3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.panelEx4.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.panelEx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ButtonX btn_edit;
        private DevComponents.DotNetBar.ButtonX btn_delete;
        private DevComponents.DotNetBar.ButtonX btn_add;
        private DevComponents.DotNetBar.PanelEx panelEx4;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_bill;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_nametable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_id;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tablestatus;
        private DevComponents.DotNetBar.ButtonX btn_last;
        private DevComponents.DotNetBar.ButtonX btn_next;
        private DevComponents.DotNetBar.ButtonX btn_prev;
        private DevComponents.DotNetBar.ButtonX btn_first;
    }
}