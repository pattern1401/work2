using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string std, op2, op3, op4;

            //  คุณใช้บริการคาเฟ่อะเมซอน บ่อยเพียงใด
            if (radioButton1.Checked == true)
            {
                std = "ทุกวัน";
            }
            else if (radioButton2.Checked == true)
            {
                std = "อาทิตย์ละ 2-3 ครั้ง";
            }
            else if (radioButton3.Checked == true)
            {
                std = "เดือนละ 2-3 ครั้ง";
            }
            else if (radioButton4.Checked == true)
            {

                std = "เดือนละครั้ง";
            }
            else
            {
                std = "ไม่แน่นอน";
            }
            // "คุณทราบข่าวโปรโมชั่นหรือสินค้าใหม่ๆของคาเฟ่อะเมซอนจากที่ใด : ";
            if (radioButton6.Checked == true)
            {
                op2 = "TV / วิทยุ";
            }
            else if (radioButton7.Checked == true)
            {
                op2 = "Magazine / สื่อโฆษณา";
            }
            else if (radioButton8.Checked == true)
            {
                op2 = "สถานีน้ำมัน ปตท";
            }
            else if (radioButton9.Checked == true)
            {
                op2 = "ครอบครัว / เพื่อนฝูง";

            }
            else if (radioButton10.Checked == true)
            {
                op2 = "พบเห้นด้วยตัวเอง";
            }
            else
            {
                op2 = "Website";
            }
            // "คุณชอบสินค้าประเภทใดมากที่สุด? : ";
            if (radioButton12.Checked == true)
            {
                op3 = "กาแฟ";
            }
            else if (radioButton13.Checked == true)
            {
                op3 = "Smoothies ";

            }
            else if (radioButton14.Checked == true)
            {
                op3 = "เบเกอรี่";

            }
            else if (radioButton15.Checked == true)
            {
                op3 = "เครื่องดื่มอื่นๆ";
            }
            else if (radioButton16.Checked == true)
            {
                op3 = "ไอศกรีม";
            }
            else
            {
                op3 = "ของสมนาคุณ";
            }
            // "คุณชอบสิ่งอำนวยความสะดวกใดมากที่สุด ? : 
            if (radioButton18.Checked == true)
            {
                op4 = "Internet";
            }
            else if (radioButton19.Checked == true)
            {
                op4 = "นิตยสาร";
            }
            else if (radioButton20.Checked == true)
            {
                op4 = "ข้อมูลเกี่ยวกับสาขาต่างๆ";
            }
            else
            {
                op4 = "บรรยากาศ/การตกแต่งร้าน";
            }
            Form2 frm = new Form2(std, op2, op3, op4);
            frm.Show();
        }
    }
}
