using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void btnexlit_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "00";



        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";




        }

       

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            string str = Calculeter.result(textBox1.Text);
            textBox1.Text = str;



        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "incorrect input")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "5";
           
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "incorrect input")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "4";
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "incorrect input")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "7";
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "incorrect input")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "8";
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "incorrect input")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "9";
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "incorrect input")
            {
                textBox1.Text = "";
            }

            textBox1.Text = textBox1.Text + "6";

        }

        private void guna2Button9_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "incorrect input")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "0";
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "incorrect input")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "00";
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "incorrect input")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + ".";
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "incorrect input")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "1";
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "incorrect input")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "2";
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "incorrect input")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "3";
        }
       

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "incorrect input")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "-";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "incorrect input")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "+";

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "incorrect input")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "*";
        }

        private void btnexlit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if(textBox1.Text !="")
            textBox1.Text = textBox1.Text.Substring(0,textBox1.Text.Length-1);
        }
    }

    public class Calculeter
    {
        public static string result(string s) //55+8*8+6
        {
            try
            {
                string num1 = "";//15
                string num2 = "";//5
                char n = '\0';//+//4

                int start = 0;//44*4

                for (int i = 0; i < s.Length; i++)// 555+3-5
                {
                    if ((s[i] >= '0' && s[i] <= '9') || (s[i] == '.')) //
                    {
                        if (n == '\0')//start = 4
                        {
                            if (num1 == "")
                            {
                                start = i;
                            }
                            num1 += s[i].ToString();

                        }
                        else
                        {
                            num2 += s[i].ToString();
                        }
                    }
                    else
                    {
                        if (n == '\0')
                        {
                            if (s[i] == '*' || s[i] == '/')
                            {
                                n = s[i];

                            }
                            else
                            {
                                num1 = "";

                            }


                        }
                        else
                        {
                            double r = 0;
                            switch (n)
                            {
                                case '*':
                                    r = double.Parse(num1) * double.Parse(num2);
                                    break;

                                case '/':
                                    r = double.Parse(num1) / double.Parse(num2);//555+15/5-5
                                    break;// r = 3
                            }
                            n = s[i];
                            i = start + r.ToString().Length;// i = 5
                            s = s.Substring(0, start) + r.ToString() + s.Substring((num1 + n.ToString() + num2).Length + start);

                            if (n == '/' || n == '*')
                            {

                                num1 = r.ToString();
                                num2 = "";
                            }
                            else
                            {
                                n = '\0';
                                num1 = num2 = "";//هون فضالي ياهن مشان تلرتيب العمليات

                            }

                        }
                    }

                }
                double j = 0;//  ضرب او قسمة هون هي العبارة لاخر رقمين لان ماعم بنفذن اذا كانو 
                switch (n)
                {
                    case '*':
                        j = double.Parse(num1) * double.Parse(num2);
                        s = s.Substring(0, start) + j.ToString();

                        break;

                    case '/':
                        j = double.Parse(num1) / double.Parse(num2);
                        s = s.Substring(0, start) + j.ToString();

                        break;
                }
                n = '\0';
                num1 = num2 = "";



                for (int i = 0; i < s.Length; i++)//558
                {
                    if ((s[i] >= '0' && s[i] <= '9') || s[i] == '.')

                    {
                        if (n == '\0')
                            num1 += s[i];//555
                        else
                        {
                            num2 += s[i];// 3
                        }

                    }
                    else
                    {
                        if (n == '\0')
                            n = s[i];// +
                        else
                        {
                            double t = 0;

                            switch (n)
                            {
                                case '+':
                                    t = double.Parse(num1) + double.Parse(num2);

                                    break;
                                case '-':
                                    t = int.Parse(num1) - int.Parse(num2);

                                    break;



                            }

                            s = t.ToString() + s.Substring(i);//اذا بعتلا رقم واحد بتقص من عندو للاخر
                                                              //558-5
                            i = -1;//هون حطيت -1 لان الفور رح تزود واجد فوق الصفر بامختصر  مشان رجعا لل 0
                            num1 = "";
                            num2 = "";
                            n = '\0';

                        }

                    }


                }
                j = 0;

                switch (n)
                {
                    case '+':
                        j = double.Parse(num1) + double.Parse(num2);
                        s = j.ToString();


                        break;
                    case '-':
                        j = double.Parse(num1) - int.Parse(num2);
                        s = j.ToString();


                        break;
                        //case '*':
                        //    j = int.Parse(num1) * int.Parse(num2);

                        //    break;
                        //case '/':
                        //    j = int.Parse(num1) / int.Parse(num2);

                        //    break;


                }
                return s;
            }

            catch (Exception)
            {
                return "incorrect input";
                
            }
                
            
        }

    }
}

