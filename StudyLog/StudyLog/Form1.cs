using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool isStudying = false;
        private void StudyBtn_Click(object sender, EventArgs e)
        {
            isStudying = !isStudying;
            if (isStudying)
            {
                this.studyBtn.TextString = "공부 끝";
            }
            else
            {
                this.studyBtn.TextString = "공부 시작";
            }
        }
    }
}
