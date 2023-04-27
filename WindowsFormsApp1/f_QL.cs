using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.Models;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Policy;
using Newtonsoft.Json;
using WindowsFormsApp1.DAL.Sqlserver;
using WindowsFormsApp1.DAL.APIController.Food;
using WindowsFormsApp1.Models.Food;

namespace WindowsFormsApp1
{
    public partial class f_QL : Form
    {
        int count;
        private  void LoaddatastaffAsync()
        {

            //clearbindings();
            //txt_idstaff.DataBindings.Add("text", dgv_staff.DataSource, "idstaff");
            //txt_staffname.DataBindings.Add("text", dgv_staff.DataSource, "staffname");
            //txt_staffbirthday.DataBindings.Add("text", dgv_staff.DataSource, "birthday");
            //cbn_staffsex.DataBindings.Add("text", dgv_staff.DataSource, "sex");
            //txt_staffnumber.DataBindings.Add("text", dgv_staff.DataSource, "number");
            //txt_staffaddress.DataBindings.Add("text", dgv_staff.DataSource, "address");


        }
        private void Loaddatafood()
        {
            MyData myData = APIFood.Instance.GetAll();
            dgv_food.DataSource = myData.data.data;


            //clearbindings();
            txt_foodname.DataBindings.Add("text", dgv_food.DataSource, "name");
            txt_foodprice.DataBindings.Add("text", dgv_food.DataSource, "price");
            //cbn_categoryfood.DataBindings.Add("text", dgv_food.DataSource, "categoryname");
            //cbn_categoryfood.ValueMember = "idcategory";
            //cbn_categoryfood.DisplayMember = "categoryname";
            //cbn_categoryfood.DataSource = category.Instance.getcategory();
            txt_discountfood.DataBindings.Add("text", dgv_food.DataSource, "discount");



        }
        private void EnabledTxt(bool type)
        {
            txt_staffaddress.Enabled = type;
            txt_staffbirthday.Enabled = type;
            txt_staffname.Enabled = type;
            txt_staffnumber.Enabled = type;
            cbn_staffsex.Enabled = type;
        }
        private void cleartxt(string text)
        {
            clearbindings();
            txt_idstaff.Text = text;
            txt_staffaddress.Text = text;
            txt_staffbirthday.Text = text;
            txt_staffname.Text = text;
            txt_staffnumber.Text = text;
            cbn_staffsex.Text = text;
        }
        private void clearbindings()
        {
            txt_idstaff.DataBindings.Clear();
            txt_staffname.DataBindings.Clear();
            txt_staffbirthday.DataBindings.Clear();
            txt_staffnumber.DataBindings.Clear();
            txt_staffaddress.DataBindings.Clear();
            cbn_staffsex.DataBindings.Clear();

        }

        private void Chonse(string text)
        {
            switch (text)
            {
                case "Thêm":
                    EnabledTxt(true);
                    if (staff.Instance.ClickAdd == true)
                    {
                        if (MessageBox.Show("Bạn Có Muốn Lưu Lại Không ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
                        {

                            LoaddatastaffAsync();
                            EnabledTxt(false);
                            btnAddNV.Text = "Thêm NV";
                            staff.Instance.ClickAdd = false;


                        }

                        else
                        {
                            staff.Instance.ClickAdd = false;
                            btnAddNV.Text = "Thêm NV";
                            EnabledTxt(false);
                            count = insertstaff(new staffDao("", txt_staffname.Text, txt_staffbirthday.Value.ToString(), cbn_staffsex.Text, txt_staffnumber.Text, txt_staffaddress.Text, ""));
                            if (count > 0)
                            {
                                MessageBox.Show("Thêm Thành Công");
                                LoaddatastaffAsync();
                            }
                            else
                            {
                                MessageBox.Show("erro");

                            }
                        }



                    }
                    else
                    {
                        cleartxt("");
                        staff.Instance.ClickAdd = true;
                        btnAddNV.Text = "Đồng Ý";
                    }

                    break;
                case "sửa":
                    EnabledTxt(true);
                    if (staff.Instance.ClickEdit == true)
                    {
                        staff.Instance.ClickEdit = false;
                        btnEditTT.Text = "Sửa TT";
                        EnabledTxt(false);
                        if (MessageBox.Show("Bạn Có Muốn Lưu Lại Không ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
                        {

                        }
                        else
                        {
                            MessageBox.Show("lưu thành công");

                        }



                    }
                    else
                    {
                        staff.Instance.ClickEdit = true;
                        btnEditTT.Text = "Đồng Ý";
                    }

                    break;
                case "Xóa":
                    count = staff.Instance.deletestaff(txt_idstaff.Text);
                    if (count > 0)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        LoaddatastaffAsync();

                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất Bại");
                    }


                    break;
                case "lưu":
                    break;
            }
        }

        private int insertstaff(staffDao staffDao)
        {
            return staff.Instance.Insertstaff(staffDao);
        }

        public f_QL()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog uploadFileSteam = new OpenFileDialog();

            uploadFileSteam.InitialDirectory = "c:\\";
            uploadFileSteam.Filter = "picture|*.jpg;*.png";
            uploadFileSteam.FilterIndex = 2;

            if (uploadFileSteam.ShowDialog() == DialogResult.OK)
            {
                /*                File.Copy(uploadFileSteam.FileName, Directory.GetCurrentDirectory() + "\\Data\\" + uploadFileSteam.SafeFileName);
                */
            }
        }


        private void f_QL_Load(object sender, EventArgs e)
        {
            LoaddatastaffAsync();
            Loaddatafood();
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            Chonse("Thêm");


        }

        private void btnEditTT_Click(object sender, EventArgs e)
        {
            Chonse("sửa");

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Lưu Lại Không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel)
            {

            }
            else
            {
                EnabledTxt(false);
                LoaddatastaffAsync();
            }
        }

        private void dgv_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            Chonse("Xóa");

        }

        private void cbn_categoryfood_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("" + cbn_categoryfood.SelectedValue.ToString());

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
