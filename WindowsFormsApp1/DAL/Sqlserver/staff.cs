using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WindowsFormsApp1.DAL.Sqlserver
{
    internal class staff
    {
        private static staff instance;
        public static staff Instance
        {
            get
            {
                if (instance == null)
                    instance = new staff();
                return instance;
            }
            set { instance = value; }
        }
        private bool clickAdd = false;
        private bool clickEdit = false;
        public bool ClickAdd { get => clickAdd; set => clickAdd = value; }
        public bool ClickEdit { get => clickEdit; set => clickEdit = value; }

        public DataTable Getstaff()
        {
            DataTable dt = Query.Instance.ExecuteQuery("Getstaff");
            if(dt == null)
            {
                MessageBox.Show("no data");
            }
            return dt;
        }

        //public int Getlaststaff()
        //{
        //    int Idstaff = 0;
        //    string text = "";
        //    DataTable dt = Query.Instance.ExecuteQuery("SELECT TOP 1 * FROM staff ORDER BY idstaff DESC");
        //    foreach (DataRow item in dt.Rows)
        //    {
        //        text = item["idstaff"].ToString();
        //    }

        //    Idstaff = separation(text);
        //    return Idstaff;
        //}

        //public int separation(string text)
        //{
        //    int i = 1;
        //    string[] numbers = Regex.Split(text, @"\D+");
        //    foreach (string value in numbers)
        //    {
        //        if (!string.IsNullOrEmpty(value))
        //        {
        //            i = int.Parse(value);
        //        }
        //    }
        //    return i;
        //}

        public int Insertstaff(staffDao staffDao)
        {
            int count = 0;
            count = Query.Instance.Querys("insertstaff  @namestaff , @birthday , @sex , @number , @address",new object[]
            {
                staffDao.StaffName,staffDao.Birthday,staffDao.Sex,staffDao.Number,staffDao.Address
            });
            return count;
        }

      public int deletestaff(string id)
        {
            int count = 0;
            count = Query.Instance.Querys("deletestaff  @namestaff", new object[]
            {
                id
            });
            return count;
        }

        public int updatestaff(string id)
        {
            int count = 0;
            count = Query.Instance.Querys("deletestaff  @namestaff", new object[]
            {
                id
            });
            return count;
        }
    }
}
