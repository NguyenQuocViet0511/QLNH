﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL.APIService;

namespace WindowsFormsApp1.DAL
{
    public class Const
    {
        private static Const instance;


        public static string URL = "http://127.0.0.1:8000/api/";

        public static Const Instance
        {
            get
            {
                if (instance == null)
                    instance = new Const();
                return instance;

            }
            set => instance = value;
        }

       
        public void CheckExistingTab(DevComponents.DotNetBar.TabControl TabControl, string Text, Form From)
        {

            int Index = CheckTabAlready(TabControl, Text);
            if (Index >= 0)
            {
                TabControl.SelectedTab = TabControl.Tabs[Index];
                TabControl.SelectedTab.Text = Text;

            }
            else
            {


                DevComponents.DotNetBar.TabItem TabPage = TabControl.CreateTab(Text);
                From.Dock = DockStyle.Fill;
                From.TopLevel = false;
                TabPage.AttachedControl.Controls.Add(From);
                //  Form.MdiParent = this;
                From.Show();
                TabControl.SelectedTabIndex = TabControl.Tabs.Count - 1;


            }

        }
        private int CheckTabAlready(DevComponents.DotNetBar.TabControl TabControl, String TabName)
        {
            int temp = -1;
            for (int i = 0; i < TabControl.Tabs.Count; i++)
            {
                if (TabControl.Tabs[i].Text == TabName)
                {
                    temp = i;
                    break;
                }
            }
            return temp;
        }
        //end
        //remove Tab
        public void RemoveTab(DevComponents.DotNetBar.TabControl TabControlName)
        {
            for (int i = 1; i < TabControlName.Tabs.Count; i++)
            {
                TabControlName.Tabs.RemoveAt(i);
                return;
            }
        }
    }
}
