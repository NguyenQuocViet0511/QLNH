using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL.APIService.Table;
using WindowsFormsApp1.Models.Tables;
using WindowsFormsApp1.UI.Oder;

namespace WindowsFormsApp1.UI.Map
{
    public partial class Map : Form
    {
        bool ClickChonseTable = false;
        Button button;
        TableData Table;
        Table table;
        public Map()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            Table = await APITable.Instance.GetAll();
            foreach (var item in Table.data.data)
            {
                button = new Button();
                button.Width = 280;
                button.Height = 150;
                button.Tag = item.id;
                button.Text = item.name;
                button.BackColor = Color.White;
                button.ForeColor = Color.Black;
                button.Click += Button_Click;
                switch (item.status)
                {
                    case "Đang Ăn":
                        button.Image = global::WindowsFormsApp1.Properties.Resources.dish;
                        break;
                    case "No":
                        button.Image = global::WindowsFormsApp1.Properties.Resources.round_table;

                        break;
                }
                    

                layout_map.Controls.Add(button);
            }
        }
        private void SetClickButton(object sender , EventArgs e)
        {
            foreach (Control c in layout_map.Controls)
            {
                c.BackColor = Color.White;
                c.ForeColor = Color.Black;
            }
            Control Click = sender as Control;
            Click.BackColor = Color.Gray;
            Click.ForeColor = Color.White;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            table = new Table();
            Button button = sender as Button;
            table.id = button.Tag.ToString();
            table.name = button.Text;
            SetClickButton(button, null);
            ClickChonseTable = true;
        }

        private void btn_oder_Click(object sender, EventArgs e)
        {
            if(ClickChonseTable)
            {
                OderFood oder = new OderFood(table);
                oder.ShowDialog();
            }

            else
            {
                MessageBox.Show("Vui Lòng Chọn Bàn Rồi Hãy Oder");
            }
        
    
        }
    }
}
