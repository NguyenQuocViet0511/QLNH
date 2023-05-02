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
using WindowsFormsApp1.DAL.Sqlserver;
using WindowsFormsApp1.Models.Category;
using WindowsFormsApp1.Models.Food;

namespace WindowsFormsApp1.UI.QLMenu
{
    public partial class QLMenu : Form
    {

        private FoodData food;
        private CategoryData category;
        public QLMenu()
        {
            InitializeComponent();
        }
        public async Task loadData()
        {
            // load data food to view
            food = await APIFood.Instance.GetAll();
            if (food != null)
            {
                dgv_food.DataSource = food.data.data;
                // add value to textbox
                txt_foodid.DataBindings.Clear();
                txt_foodid.DataBindings.Add("text", food.data.data, "id");
                txt_foodname.DataBindings.Clear();
                txt_foodname.DataBindings.Add("text", food.data.data, "name");
                txt_foodprice.DataBindings.Clear();
                txt_foodprice.DataBindings.Add("text", food.data.data, "price");
                cbn_categoryfood.DataBindings.Clear();
                cbn_categoryfood.DataBindings.Add("text", food.data.data, "category_name");
                txt_discountfood.DataBindings.Clear();
                txt_discountfood.DataBindings.Add("text", food.data.data, "discount");
                // convert data to combobox category                                       
                category = APICategory.Instance.GetAll();
                cbn_categoryfood.DataSource = category.data.data;
                cbn_categoryfood.DisplayMember = "name";
                cbn_categoryfood.ValueMember = "id";
            }

        }

        private void Add()
        {
            if (APIFood.Instance.ClickAdd)
            {
                clearText("");
                APIFood.Instance.ClickAdd = false;
                txt_foodname.Enabled = true;
                txt_foodprice.Enabled = true;
                txt_discountfood.Enabled = true;
                cbn_categoryfood.Enabled = true;
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
                        string Result = APIFood.Instance.Add(txt_foodname.Text, txt_foodprice.Text, txt_discountfood.Text, cbn_categoryfood.SelectedValue.ToString()).ToString();
                        MessageBox.Show(Result);
                        APIFood.Instance.ClickAdd = true;
                        txt_foodname.Enabled = false;
                        txt_foodprice.Enabled = false;
                        txt_discountfood.Enabled = false;
                        cbn_categoryfood.Enabled = false;
                        loadData();
                    }
                    else
                    {
      
                        MessageBox.Show(" Vui Lòng Nhập đầy đủ");
                    }
                }else
                {
                    APIFood.Instance.ClickAdd = true;
                    txt_foodname.Enabled = false;
                    txt_foodprice.Enabled = false;
                    txt_discountfood.Enabled = false;
                    cbn_categoryfood.Enabled = false;
                    loadData();

                }



            }

        }

        private void Edit()
        {
            if (APIFood.Instance.ClickAdd)
            {
                APIFood.Instance.ClickAdd = false;
                txt_foodname.Enabled = true;
                txt_foodprice.Enabled = true;
                txt_discountfood.Enabled = true;
                cbn_categoryfood.Enabled = true;
                btn_edit.Text = "Đồng Ý";
                //event add
            }
            else
            {

                //envent
                if (MessageBox.Show("Bạn có muôn Sửa Sản Phẩm  Không", "thông báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                {
                    APIFood.Instance.ClickAdd = true;
                    txt_foodname.Enabled = false;
                    txt_foodprice.Enabled = false;
                    txt_discountfood.Enabled = false;
                    cbn_categoryfood.Enabled = false;
                    btn_edit.Text = "Sửa";
                    //add new 
                    if (Checkempty())
                    {
                        string Result = APIFood.Instance.Edit(txt_foodid.Text, txt_foodname.Text, txt_foodprice.Text, txt_discountfood.Text, cbn_categoryfood.SelectedValue.ToString());
                        MessageBox.Show(Result.ToString());
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show(" Vui Lòng Nhập đầy đủ");

                    }

                }else
                {
                    APIFood.Instance.ClickAdd = true;
                    txt_foodname.Enabled = false;
                    txt_foodprice.Enabled = false;
                    txt_discountfood.Enabled = false;
                    cbn_categoryfood.Enabled = false;
                    btn_edit.Text = "Thêm";
                    loadData();
                }    

  

            }
        }
        private void clearText(string text)
            {
                txt_foodname.Text = text;
                txt_foodprice.Text = text;
                txt_discountfood.Text = text;
            }
            private bool Checkempty()
            {
                if(string.IsNullOrEmpty(txt_foodname.Text) || string.IsNullOrEmpty(txt_discountfood.Text) || string.IsNullOrEmpty(txt_foodprice.Text))
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

                    string Result = APIFood.Instance.delete(txt_foodid.Text).ToString();
                    MessageBox.Show(Result);
                    loadData();

                }
                else
                {
                    loadData();

                }
            }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            delete();
        }
    }

   
    }

