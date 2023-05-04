using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL.APIService.Category;
using WindowsFormsApp1.DAL.APIService.Food;
using WindowsFormsApp1.DAL.APIService.Table;
using WindowsFormsApp1.DAL.Sqlserver;
using WindowsFormsApp1.Models.Tables;

namespace WindowsFormsApp1.UI.QLTable
{
    public partial class QLTable : Form
    {
        TableData Table;
        public QLTable()
        {
            InitializeComponent();
            loadData();
        }

        public async void loadData()
        {
            Table = await APITable.Instance.GetAll();

            if (Table != null)
            {
                dgv_table.DataSource = Table.data.data;
                txt_id.DataBindings.Clear();
                txt_id.DataBindings.Add("text", Table.data.data, "id");
                txt_nametable.DataBindings.Clear();
                txt_nametable.DataBindings.Add("text", Table.data.data, "name");
                txt_tablestatus.DataBindings.Clear();
                txt_tablestatus.DataBindings.Add("text", Table.data.data, "status");
            }

        }
        private void Add()
        {
            if (APIFood.Instance.ClickAdd)
            {
                clearText("");
                txt_nametable.DataBindings.Clear();
                APIFood.Instance.ClickAdd = false;
                txt_nametable.Enabled = true;
                btn_add.Text = "Đồng Ý";
                //event add
            }
            else
            {

                //envent
                if (MessageBox.Show("Bạn có muôn Thêm Sản Phẩm Mới Không", "thông báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                {

                    btn_add.Text = "Thêm";
                    //add new 
                    if (Checkempty())
                    {
                        if(CheckName(txt_nametable.Text))
                        {
                            string Result = APITable.Instance.Add(txt_nametable.Text);
                            MessageBox.Show(Result);
                            APIFood.Instance.ClickAdd = true;
                            txt_tablestatus.Enabled = false;
                            loadData();
                        }    
                           else
                        {
                            MessageBox.Show("Tên Này đã Có Trong Danh Sách Vui Lòng Thử Lại Tên Khác");
                        }
                    }
                    else
                    {

                        MessageBox.Show(" Vui Lòng Nhập đầy đủ");
                    }
                }
                else
                {
                    APIFood.Instance.ClickAdd = true;
                    txt_nametable.Enabled = false;
                    loadData();

                }



            }

        }

        private void Edit()
        {
            if (APIFood.Instance.ClickAdd)
            {
                txt_nametable.DataBindings.Clear();
                APIFood.Instance.ClickAdd = false;
                txt_nametable.Enabled = true;
                btn_edit.Text = "Đồng Ý";
                //event add
            }
            else
            {

                //envent
                if (MessageBox.Show("Bạn có muôn Sửa Sản Phẩm  Không", "thông báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                {
                 
                    btn_edit.Text = "Sửa";
                    //add new 
                    if (Checkempty())
                    {
                        if(CheckName(txt_nametable.Text))
                        {
                            string Result = APITable.Instance.Edit(txt_id.Text, txt_nametable.Text);
                            MessageBox.Show(Result.ToString());
                            APIFood.Instance.ClickAdd = true;
                            txt_nametable.Enabled = false;
                            loadData();
                        }
                        else
                        {
                            MessageBox.Show("Tên Này đã Có Trong Danh Sách Vui Lòng Thử Lại Tên Khác");
                        }
                   
                    }
                    else
                    {
                        MessageBox.Show(" Vui Lòng Nhập đầy đủ");

                    }

                }
                else
                {
                    APIFood.Instance.ClickAdd = true;
                    txt_nametable.Enabled = false;
                    btn_edit.Text = "Thêm";
                    loadData();
                }



            }
        }
        private void clearText(string text)
        {
            txt_nametable.Text = text;
            txt_id.Text = text;
            txt_tablestatus.Text = text;
        }
        private bool Checkempty()
        {
            if (string.IsNullOrEmpty(txt_nametable.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void delete()
        {
            if (MessageBox.Show("Bạn có muôn Xóa Không", "thông báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
            {

                string Result = APITable.Instance.delete(txt_id.Text).ToString();
                MessageBox.Show(Result);
                loadData();

            }
            else
            {
                loadData();

            }
        }

        private bool CheckName(String text)
        {
            foreach (var item in Table.data.data)
            {
                if (item.name.Equals(text))
                {
                    return false;
                }

            }
            return true;
        }
        private void dgv_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void dgv_table_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            this.BindingContext[Table.data.data].Position = 0;

        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            this.BindingContext[Table.data.data].Position--;

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.BindingContext[Table.data.data].Position++;

        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            int ViTri = this.BindingContext[Table.data.data].Count - 1;
            this.BindingContext[Table.data.data].Position = ViTri;
        }
    }
}
