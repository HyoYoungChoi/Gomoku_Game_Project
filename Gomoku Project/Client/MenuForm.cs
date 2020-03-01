using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void singlePlayButton_Click(object sender, EventArgs e) // 싱글플레이 버튼 클릭시
        {
            Hide(); // 현재 창 숨기기
            SinglePlayForm singlePlayForm = new SinglePlayForm();   // 싱글플레이창 생성
            singlePlayForm.FormClosed += new FormClosedEventHandler(childForm_Closed);  // 싱글플레이창 소멸시 함수설정.
            singlePlayForm.Show();  // 싱글플레이창 보이기.
        }

        private void exitButton_Click(object sender, EventArgs e)   // 닫기버튼 클릭시
        {
            // 프로그램 종료.
            System.Windows.Forms.Application.Exit();
        }

        void childForm_Closed(object sender, FormClosedEventArgs e) // 싱글플레이창 소멸
        {
            Show(); // 현재 창 보이기
        }

        private void multiPlayButton_Click(object sender, EventArgs e)
        {
            Hide(); // 현재 창 숨기기
            MultiPlayForm multiPlayForm = new MultiPlayForm();   // 멀티플레이창 생성
            multiPlayForm.FormClosed += new FormClosedEventHandler(childForm_Closed);  // 멀티플레이창 소멸시 함수설정.
            multiPlayForm.Show();  // 멀티플레이창 보이기.
        }
    }
}
