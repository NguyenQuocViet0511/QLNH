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
using WindowsFormsApp1.Models.Category;

namespace WindowsFormsApp1.UI.QLCategory
{
    public partial class QLCategory : Form
    {
        CategoryData Category;
        public QLCategory()
        {
            InitializeComponent();
            loadData();
        }

        public async void loadData()
        {
            Category =  APICategory.Instance.GetAll();

            if (Category != null)
            {
                dgv_category.DataSource = Category.data.data;
                txt_id.DataBindings.Clear();
                txt_id.DataBindings.Add("text", Category.data.data, "id");
                txt_categoryname.DataBindings.Clear();
                txt_categoryname.DataBindings.Add("text", Category.data.data, "name");
                //txt_status.DataBindings.Clear();
                //txt_status.DataBindings.Add("text", Category.data.data, "status");
            }

        }
        private void Add()
        {
            if (APICategory.Instance.ClickAdd)
            {
                clearText("");
                APICategory.Instance.ClickAdd = false;
                txt_categoryname.Enabled = true;
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
                        string Result = APITable.Instance.Add(txt_categoryname.Text);
                        MessageBox.Show(Result);
                        APICategory.Instance.ClickAdd = true;
                        txt_status.Enabled = false;
                        loadData();
                    }
                    else
                    {

                        MessageBox.Show(" Vui Lòng Nhập đầy đủ");
                    }
                }
                else
                {
                    APICategory.Instance.ClickAdd = true;
                    txt_categoryname.Enabled = false;
                    loadData();

                }



            }

        }

        private void Edit()
        {
            if (APIFood.Instance.ClickAdd)
            {
                APIFood.Instance.ClickAdd = false;
                txt_categoryname.Enabled = true;
                btn_edit.Text = "Đồng Ý";
                //event add
            }
            else
            {

                //envent
                if (MessageBox.Show("Bạn có muôn Sửa Sản Phẩm  Không", "thông báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                {
                    APIFood.Instance.ClickAdd = true;
                    txt_categoryname.Enabled = false;
                    btn_edit.Text = "Sửa";
                    //add new 
                    if (Checkempty())
                    {
                        string Result = APITable.Instance.Edit(txt_id.Text, txt_categoryname.Text);
                        MessageBox.Show(Result.ToString());
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show(" Vui Lòng Nhập đầy đủ");

                    }

                }
                else
                {
                    APIFood.Instance.ClickAdd = true;
                    txt_categoryname.Enabled = false;
                    btn_edit.Text = "Thêm";
                    loadData();
                }



            }
        }
        private void clearText(string text)
        {
            txt_categoryname.Text = text;
            txt_id.Text = text;
        }
        private bool Checkempty()
        {
            if (string.IsNullOrEmpty(txt_categoryname.Text))
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

        private void btn_first_Click(object sender, EventArgs e)
        {
            this.BindingContext[Category.data.data].Position = 0;

        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            this.BindingContext[Category.data.data].Position--;

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.BindingContext[Category.data.data].Position++;

        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            int ViTri = this.BindingContext[Category.data.data].Count - 1;
            this.BindingContext[Category.data.data].Position = ViTri;
        }
    }
}
