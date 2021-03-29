using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float a = 0, b = 0, r = 0;
        int ch = 0, chh= 0;

        private void clivk9(object sender, EventArgs e)
        {
            t1.Text = t1.Text + "9"; chh = 1;
        }
        private void clivk8(object sender, EventArgs e)
        {
            t1.Text = t1.Text + "8"; chh = 0;
        }
        private void clivk7(object sender, EventArgs e)
        {
            t1.Text = t1.Text + "7"; chh = 0;
        }
        private void clivk6(object sender, EventArgs e)
        {
            t1.Text = t1.Text + "6"; chh = 0;
        }
        private void clivk5(object sender, EventArgs e)
        {
            t1.Text = t1.Text + "5"; chh = 0;
        }
        private void clivk4(object sender, EventArgs e)
        {
            t1.Text = t1.Text + "4"; chh = 0;
        }
        private void clivk3(object sender, EventArgs e)
        {
            t1.Text = t1.Text + "3"; chh = 0;
        }
        private void clivk2(object sender, EventArgs e)
        {
            t1.Text = t1.Text + "2"; chh = 0;
        }
        private void clivk1(object sender, EventArgs e)
        {
            t1.Text = t1.Text + "1"; chh = 0;
        }
        private void clivk0(object sender, EventArgs e)
        {
            t1.Text = t1.Text + "0"; chh = 0;
        }
        private void clivkP(object sender, EventArgs e)
        {
            int z=0;
            string p = t1.Text;
            for(int i =0; i<p.Length; i++){
            if(p[i] == '.'){z++;}
            }
            if (z == 0) { t1.Text = t1.Text + "."; chh = 0; }
        }


        private void clivkAdd(object sender, EventArgs e) {
            if (t1.Text == "")
            {
                MessageBox.Show("No value to add");
                Form1 ob = new Form1();
                ob.Show();
                this.Hide();
            }
            else
            {
                if (a == 0)
                {


                    a = float.Parse(t1.Text);
                    t1.Clear();
                    t2.Text = a + "";

                }
                else if (a != 0)
                {
                    b = float.Parse(t1.Text);
                    t1.Clear();
                    r = a + b;
                    t2.Text = a + " + " + b + "=" + r;
                    a = r; b = 0;
                }
                ch = 1; chh = 1;
            }
        }
        private void clivkSub(object sender, EventArgs e)
        {
            if (t1.Text == "")
            {
                MessageBox.Show("No value to subtract");
                Form1 ob = new Form1();
                ob.Show();
                this.Hide();
            }
            else
            {
                if (a == 0)
                {

                    a = float.Parse(t1.Text);
                    t1.Clear();
                    t2.Text = a + "";

                }

                else if (a != 0)
                {
                    b = float.Parse(t1.Text);
                    t1.Clear();
                    r = a - b;
                    t2.Text = a + " - " + b + "=" + r;
                    a = r; b = 0;
                }
                ch = 2; chh = 1;
            }
        }
        private void clivkDiv(object sender, EventArgs e)
        {
            if (t1.Text == "")
            {
                MessageBox.Show("No value to divide");
                Form1 ob = new Form1();
                ob.Show();
                this.Hide();
            }
            else
            {
                if (a == 0)
                {

                    a = float.Parse(t1.Text);
                    t1.Clear();
                    t2.Text = a + "";
                }
                else if (a != 0)
                {
                    b = float.Parse(t1.Text);
                    t1.Clear();
                    r = a / b;
                    t2.Text = a + " / " + b + "=" + r;
                    a = r; b = 0;
                }
                ch = 3; chh = 1;
            }
        }
        private void clivkMul(object sender, EventArgs e)
        {
            if (t1.Text == "")
            {
                MessageBox.Show("No value to multiply");
                Form1 ob = new Form1();
                ob.Show();
                this.Hide();
            }
            else
            {
                if (a == 0)
                {

                    a = float.Parse(t1.Text);
                    t1.Clear();
                    t2.Text = a + "";

                }
                else if (a != 0)
                {
                    b = float.Parse(t1.Text);
                    t1.Clear();
                    r = a * b;
                    t2.Text = a + " * " + b + "=" + r;
                    a = r; b = 0;
                }
                ch = 4; chh = 1;
            }
        }
        private void clickFact(object sender, EventArgs e)
        {

            if (a == 0)
            {
                if (t1.Text == "")
            {
                MessageBox.Show("No value for factorial");
                Form1 ob = new Form1();
                ob.Show();
                this.Hide();
            }
            else
            {
                r = 1;
                a = int.Parse(t1.Text);
                for (int i = 1; i <= a; i++)
                {
                    r = r * i;
                }
                }
                    t1.Clear();
                t2.Text = a+"! = "+ r;
            }
            else{}
             chh = 1;
        }
        private void clickPow(object sender, EventArgs e)
        {
            if (a == 0)
            {
                if (t1.Text == "")
                {
                    MessageBox.Show("No value for power");
                    Form1 ob = new Form1();
                    ob.Show();
                    this.Hide();
                }
                else
                {
                    a = float.Parse(t1.Text);
                    t1.Clear();
                    t2.Text = a + "";
                }
            }
            else
            {
                b = float.Parse(t1.Text);
                t1.Clear();
                double pow_tt = Math.Pow(a, b);
                r = (float)pow_tt;
                t1.Clear();
                t2.Text = a + " ^ " + b + " = " + r;
                a = r; b = 0;
            }
            ch = 5;  chh = 1;
        }
        private void clivkInv(object sender, EventArgs e) {
            if (a == 0)
            {
                if (t1.Text == "")
                {
                    MessageBox.Show("No value for inverse");
                    Form1 ob = new Form1();
                    ob.Show();
                    this.Hide();
                }
                else
                {
                    t2.Clear();
                    a = float.Parse(t1.Text);
                    r = 1 / a;
                    t2.Text = "1 / " + a + " = " + r;
                }
            }
            else {
                
            }
            chh = 1;
        }
        private void ClickSin(object sender, EventArgs e)
        {
            if (t1.Text == "")
            {
                MessageBox.Show("No value for Sin");
                Form1 ob = new Form1();
                ob.Show();
                this.Hide();
            }
            else
            {
                t2.Clear();
                double rad = double.Parse(t1.Text);
                double ang = (Math.PI * rad) / 180;
                double ans = Math.Sin(ang);
                t2.Text = "sin(" + rad + ")= " + ans;
                r = (float)ans;
                ans = 0; chh = 1;
            }
        }
        private void ClickCos(object sender, EventArgs e)
        {
            if (t1.Text == "")
            {
                MessageBox.Show("No value to cos");
                Form1 ob = new Form1();
                ob.Show();
                this.Hide();
            }
            else
            {
                t2.Clear();
                double rad = double.Parse(t1.Text);
                double ang = (Math.PI * rad) / 180;
                double ans = Math.Cos(ang);
                t2.Text = "Cos(" + rad + ")= " + ans;
                r = (float)ans;
                ans = 0; chh = 1;
            }
        }
        private void ClickTan(object sender, EventArgs e)
        {
            if (t1.Text == "")
            {
                MessageBox.Show("No value for Tan");
                Form1 ob = new Form1();
                ob.Show();
                this.Hide();
            }
            else
            {
                t2.Clear();
                double rad = double.Parse(t1.Text);
                double ang = (Math.PI * rad) / 180;
                double ans = Math.Tan(ang);
                if (ans >= 1.63317787283838E+16) { t2.Text = " ♾"; }
                else
                {
                    t2.Text = "tan(" + rad + ")= " + ans;
                }
                r = (float)ans;
                ans = 0; chh = 1;
            }
        }
        private void ClickCosec(object sender, EventArgs e)
        {
            if (t1.Text == "")
            {
                MessageBox.Show("No value for Cosec");
                Form1 ob = new Form1();
                ob.Show();
                this.Hide();
            }
            else
            {
                t2.Clear();
                double rad = double.Parse(t1.Text);
                double ang = (Math.PI * rad) / 180;
                double ans = Math.Sin(ang);
                ans = 1 / ans;
                if (ans >= 1.63317787283838E+16) { t2.Text = " ♾"; }
                else
                {
                    t2.Text = "Cosec(" + rad + ")= " + ans;
                }
                r = (float)ans;
                ans = 0; chh = 1;
            }
        }
        private void ClickSec(object sender, EventArgs e)
        {
            if (t1.Text == "")
            {
                MessageBox.Show("No value for Sec");
                Form1 ob = new Form1();
                ob.Show();
                this.Hide();
            }
            else
            {
                t2.Clear();
                double rad = double.Parse(t1.Text);
                double ang = (Math.PI * rad) / 180;
                double ans = Math.Cos(ang);
                ans = 1 / ans;
                if (ans >= 1.63317787283838E+16) { t2.Text = " ♾"; }
                else
                {
                    t2.Text = "Sec(" + rad + ")= " + ans;
                }
                r = (float)ans;
                ans = 0; chh = 1;
            }
        }
        private void ClickCot(object sender, EventArgs e)
        {
            if (t1.Text == "")
            {
                MessageBox.Show("No value for Cot");
                Form1 ob = new Form1();
                ob.Show();
                this.Hide();
            }
            else
            {
                t2.Clear();
                double rad = double.Parse(t1.Text);
                double ang = (Math.PI * rad) / 180;
                double ans = Math.Tan(ang);
                ans = 1 / ans;
                if (ans >= 1.63317787283838E+16) { t2.Text = " ♾"; }
                else
                {
                    t2.Text = "Cot(" + rad + ")= " + ans;
                }
                r = (float)ans;
                ans = 0; chh = 1;
            }
        }
        private void clivkLog(object sender, EventArgs e)
        {
            if (t1.Text == "")
            {
                MessageBox.Show("No value for Log");
                Form1 ob = new Form1();
                ob.Show();
                this.Hide();
            }
            else
            {
                t2.Clear();
                double lgg = double.Parse(t1.Text);
                double ans = Math.Log10(lgg);
                t2.Text = "Log(" + lgg + ")= " + ans;
                r = (float)ans;
                ans = 0; chh = 1;
            }
        }
        private void clivkPer(object sender, EventArgs e)
        {
            if (t1.Text == "")
            {
                MessageBox.Show("No value for Percentage");
                Form1 ob = new Form1();
                ob.Show();
                this.Hide();
            }
            else
            {
                if (a == 0)
                {
                    a = float.Parse(t1.Text);
                    t1.Clear();
                    a = a / 100;
                    t2.Text = a + "";
                }
                else if (a != 0)
                { ch = 6; }
                ch = 6; chh = 1;
            }
        }

        private void clivkEqu(object sender, EventArgs e) {
            if (r != 0) { t1.Clear(); t2.Clear(); t2.Text = t2.Text + "Error,  Last answer: " + r; a = 0; b = 0; r = 0; }
            else{
            switch (ch) { 
                   
                case 1:
                     b = float.Parse(t1.Text);
                     t1.Clear();
                    r = a + b;
                    t2.Text = a + " + " + b+ "="+r;
                     a = r; b = 0; 
                    break;
                case 2:
                     b = float.Parse(t1.Text);
                t1.Clear();
                r = a - b;
                t2.Text = a + " - " + b + "=" + r;
                a = r; b = 0;
                    break;
                case 3:
                    b = float.Parse(t1.Text);
                t1.Clear();
                r = a / b;
                t2.Text = a + " / " + b + "=" + r;
                a = r; b = 0;
                    break;
                case 4:
                     b = float.Parse(t1.Text);
                t1.Clear();
                r = a * b;
                t2.Text = a + " * " + b + "=" + r;
                a = r; b = 0;
                    break;
                case 5:
                    b = float.Parse(t1.Text);
                    t1.Clear();
                    double pow_tt = Math.Pow(a, b);
                r = (float)pow_tt;
                t1.Clear();
                t2.Text = a + " ^ " + b + " = " + r;
                    a = r; b = 0;
                    break;
                case 6:
                     b = float.Parse(t1.Text);
                     t1.Clear();
                    r = a * b;
                    t2.Text = a + " % " + b+ "="+r;
                     a = r; b = 0; 
                    break;
            }
            chh = 1;
            }
            
        }
        

        private void clivkDel(object sender, EventArgs e) {
            if (t1.Text == "")
            {
                MessageBox.Show("No value to add");
                Form1 ob = new Form1();
                ob.Show();
                this.Hide();
            }
            else
            {
                String s = t1.Text;
                if (chh == 1) { }
                else
                {
                    string ss = s.Remove(s.Length - 1, 1);
                    t1.Clear();
                    t1.Text = t1.Text + ss;
                }
            }
        }
        private void clivkAC(object sender, EventArgs e) {
            t1.Clear();
            t2.Text = t1.Text + "Last operation answer: " + r;
            a = 0; b = 0; r = 0;
        }

    }
}
