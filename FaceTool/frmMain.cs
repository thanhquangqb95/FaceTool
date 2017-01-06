using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using System.Net;
using System.IO;



namespace FaceTool
{
   
    public delegate void id(string id);
    public partial class frmMain : Form
    {


        public frmMain()
        {
            InitializeComponent();

        }

        private class TaiKhoan
        {
            private dynamic id;
            private dynamic name;
            private dynamic url;
            private dynamic birthday;

            public TaiKhoan(dynamic name, dynamic id, dynamic url, dynamic birthday)
            {
                this.name = name;
                this.id = id;
                this.url = url;
                this.birthday = birthday;
            }


        }
        private class Page
        {
            private dynamic name;
            private dynamic category;
            public Page(dynamic name, dynamic category)
            {
                this.name = name;
                this.category = category;
            }
        }
        public class Group
        {
            public string id { get; set; }
            public string name { get; set; }
            public string icon { get; set; }            
            public Group(string id, string name, string icon)
            {
                this.id = id;
                this.name = name;
                this.icon = icon;
               
            }
        }
        public string token;

        public void LayToken()
        {
            token = txtToken.Text;
        }
        private void kiemtratoken(string Token)
        {
            if(Token=="")
            {
                MessageBox.Show("access token không được để trống", "Thông báo");
                return;
            }
            try
            {
                FacebookClient fb = new FacebookClient(Token);
                dynamic info = fb.Get("me?fields=id,name,picture,birthday");
                TaiKhoan taikhoan = new TaiKhoan(info.name, info.id, info.picture.data.url, info.birthday);
                txtNgaySinh.Text = info.birthday;
                lblName.Text = info.name;
                picAvatar.ImageLocation = info.picture.data.url;
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Token nhập không đúng",ex.Message);


            }
        }

        private void DSNhom(string Token)
        {
            
            
           

        }
            


        private void frmMain_Load(object sender, EventArgs e)
        {


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {


        }

        private void boxNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            LayToken();
            kiemtratoken(token);   
        }

        private void btnDSNhom_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DSNhom(token);
        }
    }
}
