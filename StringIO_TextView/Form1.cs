using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringIO_TextView
{
    public partial class Form1 : Form //' : ' => extends
    {
        string OrgStr = ""; // "결과 : " 문자열 저장

        private bool TextCheck()
        {
            if (this.txtEdit.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("텍스트를 입력하세요!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtEdit.Focus(); //사용자가 다시 입력할 수 있도록 txtEdit에 focus를 준다
                return false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.OrgStr = this.lblResult.Text;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(TextCheck())
            {
                this.lblResult.Text = this.OrgStr + this.txtEdit.Text;
            }
            
        }

        private void txtEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // //엔터 키를 누를 때
            {// 아스키코드
                e.Handled = true;//엔터칠때 소리가 나는데 나지 않게 하는 것
                if (TextCheck())
                {
                    this.lblResult.Text = this.OrgStr + this.txtEdit.Text;
                }
            }
        }
    }
}

