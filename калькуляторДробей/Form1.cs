using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькуляторДробей
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }


        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); //Очищение полей
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            textBox7.Text = "+"; //добавление плюс в текст-бокс 
           
            if ((textBox2.Text.Length == 0) || (textBox5.Text.Length == 0))  // проверка ввода знаменателя 
            {
                MessageBox.Show("Введите число в знаменатель!");
            }
            else if ((Convert.ToInt32(textBox2.Text) <= 0) || (Convert.ToInt32(textBox5.Text) <= 0)) // проверка значений знаменателей
            {
                MessageBox.Show("Введено отрицательное число или ноль в знаменатель!");
            }
            else
            {
                if ((textBox3.Text.Length == 0) || (textBox6.Text.Length == 0)) // проверка ввода целой части 
                {
                    MessageBox.Show("Введите целую часть!");
                }
                else
                {
                    if ((textBox1.Text.Length == 0) || (textBox4.Text.Length == 0)) // проверка ввода числителя
                    {
                        MessageBox.Show("Введите Числитель!");
                    }
                    else if ((Convert.ToInt32(textBox1.Text) < 0) || (Convert.ToInt32(textBox4.Text) < 0)) // проверка значений знаменателей
                     {
                            MessageBox.Show("Введено отрицательное число в числитель!");
                     }
                    else
                    {
                        int ch1, ch2, ch3; // инициализация
                        if (Convert.ToInt32(textBox3.Text) < 0) { ch1 = Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox1.Text); } // проверка знака целой  части  первой дроби, при выполнении избавляемся от целой части и засовываем в числитель, рассчёт числителя первой дроби
                        else { ch1 = Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox1.Text); } // при выполнении избавляемся от целой части и засовываем в числитель, рассчёт числителя первой дроби
                        if (Convert.ToInt32(textBox6.Text) < 0) { ch2 = Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox5.Text) - Convert.ToInt32(textBox4.Text); } // проверка знака целой  части  второй дроби при выполнении избавляемся от целой части и засовываем в числитель, рассчёт числителя второй дроби
                        else { ch2 = Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox4.Text); } // при выполнении избавляемся от целой части и засовываем в числитель, рассчёт числителя второй дроби


                        int zn1 = Convert.ToInt32(textBox2.Text), zn2 = Convert.ToInt32(textBox5.Text), zn3; //получение значений знаменателей

                        zn3 = zn1 * zn2; // подсчёт знаменателя итоговой дроби
                        ch3 = ch1 * zn2 + ch2 * zn1; //подсчёт числителя итоговой дроби

                        int div = GCD(ch3, zn3); //поиск наибольшего общего делителя(НОД)


                        textBox9.Text = (zn3 / div).ToString(); //сокращение итогового знаменателя на НОД
                        textBox10.Text = (Math.Abs((ch3 / div) % Convert.ToInt32(textBox9.Text))).ToString(); //вычисление числителя итоговой дроби
                        textBox8.Text = ((ch3 / div) / Convert.ToInt32(textBox9.Text)).ToString(); //вычисление целой части итоговой дроби
                        if ((Convert.ToInt32(textBox8.Text) == 0) && ((ch3 / div) % Convert.ToInt32(textBox9.Text) < 0)) { textBox8.Text = "-"; } // если  целая часть =0 и числитель <0 , то ставим -
                        
                        if (Convert.ToInt32(textBox10.Text) == 0) { textBox9.Text = ""; textBox10.Text = ""; } //если числитель =0, то знаменатель и числитель оставляем пустыми
                    }
                }
            }


        }

        int GCD(int a, int b) // метод поиска НОДа знаменателей
        {
            if (a == 0) return b; 
            if (b == 0) return a;
            if (a == b) return a;
            if (a == 1 || b == 1) return 1;
            if ((a % 2 == 0) && (b % 2 == 0)) return 2 * GCD(a / 2, b / 2);
            if ((a % 2 == 0) && (b % 2 != 0)) return GCD(a / 2, b);
            if ((a % 2 != 0) && (b % 2 == 0)) return GCD(a, b / 2);
            return GCD(b, (int)Math.Abs(a - b));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox7.Text = "-"; //добавление минус в текст-бокс 

            if ((textBox2.Text.Length == 0) || (textBox5.Text.Length == 0)) // проверка ввода знаменателя
            {
                MessageBox.Show("Введите число в знаменатель!");
            }
            else if ((Convert.ToInt32(textBox2.Text) <= 0) || (Convert.ToInt32(textBox5.Text) <= 0)) // проверка значений знаменателей
            {
                MessageBox.Show("Введено отрицательное число или ноль в знаменатель!");
            }
            else
            {
                if ((textBox3.Text.Length == 0) || (textBox6.Text.Length == 0)) // проверка ввода целой части 
                {
                    MessageBox.Show("Введите целую часть!");
                }
                else
                {
                    if ((textBox1.Text.Length == 0) || (textBox4.Text.Length == 0)) // проверка ввода числителя
                    {
                        MessageBox.Show("Введите Числитель!");
                    }
                    else if ((Convert.ToInt32(textBox1.Text) < 0) || (Convert.ToInt32(textBox4.Text) < 0)) // проверка значений знаменателей
                    {
                        MessageBox.Show("Введено отрицательное число в числитель!");
                    }
                    else
                    {

                        int ch1, ch2, ch3;
                        if (Convert.ToInt32(textBox3.Text) < 0) { ch1 = Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox1.Text); } // проверка знака целой  части  первой дроби, при выполнении избавляемся от целой части и засовываем в числитель, рассчёт числителя первой дроби
                        else { ch1 = Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox1.Text); } // при выполнении избавляемся от целой части и засовываем в числитель, рассчёт числителя первой дроби
                        if (Convert.ToInt32(textBox6.Text) < 0) { ch2 = Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox5.Text) - Convert.ToInt32(textBox4.Text); } // проверка знака целой  части  второй дроби при выполнении избавляемся от целой части и засовываем в числитель, рассчёт числителя второй дроби
                        else { ch2 = Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox4.Text); } // при выполнении избавляемся от целой части и засовываем в числитель, рассчёт числителя второй дроби

                        int zn1 = Convert.ToInt32(textBox2.Text), zn2 = Convert.ToInt32(textBox5.Text), zn3; //получение значений знаменателей

                        zn3 = zn1 * zn2; // подсчёт знаменателя итоговой дроби
                        ch3 = ch1 * zn2 - ch2 * zn1; //подсчёт числителя итоговой дроби

                        int div = GCD(ch3, zn3); //поиск наибольшего общего делителя(НОД)

                        textBox9.Text = (zn3 / div).ToString(); //сокращение итогового знаменателя на НОД
                        textBox10.Text = (Math.Abs((ch3 / div) % Convert.ToInt32(textBox9.Text))).ToString(); //вычисление числителя итоговой дроби
                        textBox8.Text = ((ch3 / div) / Convert.ToInt32(textBox9.Text)).ToString(); //вычисление целой части итоговой дроби
                        if (Convert.ToInt32(textBox10.Text) == 0) { textBox9.Text = ""; textBox10.Text = ""; }  //если числитель =0, то знаменатель и числитель оставляем пустыми

                    }
                }
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            textBox7.Text = "*"; //добавление знака умножения в текст-бокс 

            if ((textBox2.Text.Length == 0) || (textBox5.Text.Length == 0)) // проверка ввода знаменателя
            {
                MessageBox.Show("Введите число в знаменатель!");
            }
            else if ((Convert.ToInt32(textBox2.Text) <= 0) || (Convert.ToInt32(textBox5.Text) <= 0)) // проверка значений знаменателей
            {
                MessageBox.Show("Введено отрицательное число или ноль в знаменатель!");
            }
            else
            {
                if ((textBox3.Text.Length == 0) || (textBox6.Text.Length == 0)) // проверка ввода целой части 
                {
                    MessageBox.Show("Введите целую часть!");
                }
                else
                {
                    if ((textBox1.Text.Length == 0) || (textBox4.Text.Length == 0)) // проверка ввода числителя
                    {
                        MessageBox.Show("Введите Числитель!");
                    }
                    else if ((Convert.ToInt32(textBox1.Text) < 0) || (Convert.ToInt32(textBox4.Text) < 0)) // проверка значений знаменателей
                    {
                        MessageBox.Show("Введено отрицательное число в числитель!");
                    }
                    else
                    {

                        int ch1, ch2, ch3;
                        if (Convert.ToInt32(textBox3.Text) < 0) { ch1 = Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox1.Text); } // проверка знака целой  части  первой дроби, при выполнении избавляемся от целой части и засовываем в числитель, рассчёт числителя первой дроби
                        else { ch1 = Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox1.Text); } // при выполнении избавляемся от целой части и засовываем в числитель, рассчёт числителя первой дроби
                        if (Convert.ToInt32(textBox6.Text) < 0) { ch2 = Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox5.Text) - Convert.ToInt32(textBox4.Text); }  // проверка знака целой  части  второй дроби при выполнении избавляемся от целой части и засовываем в числитель, рассчёт числителя второй дроби
                        else { ch2 = Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox4.Text); } // при выполнении избавляемся от целой части и засовываем в числитель, рассчёт числителя второй дроби

                        int zn1 = Convert.ToInt32(textBox2.Text), zn2 = Convert.ToInt32(textBox5.Text), zn3; //получение значений знаменателей

                        zn3 = zn1 * zn2; // подсчёт знаменателя итоговой дроби
                        ch3 = ch1 * ch2; //подсчёт числителя итоговой дроби

                        int div = GCD(ch3, zn3);  //поиск наибольшего общего делителя(НОД)

                        textBox9.Text = (zn3 / div).ToString(); //сокращение итогового знаменателя на НОД
                        textBox10.Text = (Math.Abs((ch3 / div) % Convert.ToInt32(textBox9.Text))).ToString(); //вычисление числителя итоговой дроби
                        textBox8.Text = ((ch3 / div) / Convert.ToInt32(textBox9.Text)).ToString(); //вычисление целой части итоговой дроби
                        if (Convert.ToInt32(textBox10.Text) == 0) { textBox9.Text = ""; textBox10.Text = ""; } //если числитель =0, то знаменатель и числитель оставляем пустыми

                    }
                }
            }
        }



        private void button4_Click(object sender, EventArgs e)


        {
            textBox7.Text = ":"; //добавление знака деления в текст-бокс 

            if ((textBox2.Text.Length == 0) || (textBox5.Text.Length == 0)) // проверка ввода знаменателя
            {
                MessageBox.Show("Введите число в знаменатель!");
            }
            else if ((Convert.ToInt32(textBox2.Text) <= 0) || (Convert.ToInt32(textBox5.Text) <= 0)) // проверка значений знаменателей
            {
                MessageBox.Show("Введено отрицательное число или ноль в знаменатель!");
            }
            else
            {
                if ((textBox3.Text.Length == 0) || (textBox6.Text.Length == 0)) // проверка ввода целой части 
                {
                    MessageBox.Show("Введите целую часть!");
                }
                else
                {
                    if ((textBox1.Text.Length == 0) || (textBox4.Text.Length == 0)) // проверка ввода числителя
                    {
                        MessageBox.Show("Введите Числитель!");
                    }
                    else if ((Convert.ToInt32(textBox1.Text) < 0) || (Convert.ToInt32(textBox4.Text) < 0)) // проверка значений знаменателей
                    {
                        MessageBox.Show("Введено отрицательное число в числитель!");
                    }
                    else
                    {

                        int ch1, ch2, ch3;
                        if (Convert.ToInt32(textBox3.Text) < 0) { ch1 = Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox1.Text); } // проверка знака целой  части  первой дроби, при выполнении избавляемся от целой части и засовываем в числитель, рассчёт числителя первой дроби
                        else { ch1 = Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox1.Text); } // при выполнении избавляемся от целой части и засовываем в числитель, рассчёт числителя первой дроби
                        if (Convert.ToInt32(textBox6.Text) < 0) { ch2 = Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox5.Text) - Convert.ToInt32(textBox4.Text); }  // проверка знака целой  части  второй дроби при выполнении избавляемся от целой части и засовываем в числитель, рассчёт числителя второй дроби
                        else { ch2 = Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox4.Text); } // при выполнении избавляемся от целой части и засовываем в числитель, рассчёт числителя второй дроби

                        int zn1 = Convert.ToInt32(textBox2.Text), zn2 = Convert.ToInt32(textBox5.Text), zn3; //получение значений знаменателей

                        zn3 = zn1 * ch2; // подсчёт знаменателя итоговой дроби
                        ch3 = ch1 * zn2; //подсчёт числителя итоговой дроби

                        int div = GCD(ch3, zn3); //поиск наибольшего общего делителя(НОД)
                        if (zn3 < 0) { ch3 = -ch3; zn3 = Math.Abs(zn3); } // если знаменатель получился отрицательным, то минус переносим в числитель

                        textBox9.Text = (zn3 / div).ToString(); //сокращение итогового знаменателя на НОД
                        textBox10.Text = (Math.Abs((ch3 / div) % Convert.ToInt32(textBox9.Text))).ToString(); //вычисление числителя итоговой дроби
                        textBox8.Text = ((ch3 / div) / Convert.ToInt32(textBox9.Text)).ToString();  //вычисление целой части итоговой дроби
                        if ((Convert.ToInt32(textBox8.Text) == 0) && ((ch3 / div) % Convert.ToInt32(textBox9.Text) < 0)) { textBox8.Text = "-"; } // если  целая часть =0 и числитель <0 , то ставим -
                        if (Convert.ToInt32(textBox10.Text) == 0) { textBox9.Text = ""; textBox10.Text = ""; } //если числитель =0, то знаменатель и числитель оставляем пустыми

                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string a = textBox21.Text, b = "-";
            if ((textBox19.Text.Length == 0)) // проверка ввода числителя
            {
                MessageBox.Show("Введите Числитель!");
            }
            else if (Convert.ToInt32(textBox19.Text) < 0)
            {
                MessageBox.Show("Введён отрицательный числитель!");
            }

            else
            {
                if ((textBox20.Text.Length == 0)) // проверка ввода знаменателя
                {
                    MessageBox.Show("Введите число в знаменатель!");
                }
                else if ((Convert.ToInt32(textBox20.Text) <= 0)) // проверка значений знаменателей
                {
                    MessageBox.Show("Введено отрицательное число или ноль в знаменатель!");
                }
                else
                {
                    if ((textBox21.Text.Length == 0)) // проверка ввода целой части 
                    {
                        MessageBox.Show("Введите целую часть или минус!");
                    }
                    else
                    {
                        if ((textBox25.Text.Length == 0)) // проверка ввода целой части 
                        {
                            MessageBox.Show("Введите степень!");
                        }
                        else
                        {

                            int ch1, ch2, aa;

                            if (a == b) { ch1 = -(Convert.ToInt32(textBox19.Text)); textBox21.Text = "0"; }
                            else if (Convert.ToInt32(textBox21.Text) < 0) { ch1 = Convert.ToInt32(textBox21.Text) * Convert.ToInt32(textBox20.Text) - Convert.ToInt32(textBox19.Text); } // проверка знака целой  части  первой дроби, при выполнении избавляемся от целой части и засовываем в числитель, рассчёт числителя первой дроби
                            else { ch1 = Convert.ToInt32(textBox21.Text) * Convert.ToInt32(textBox20.Text) + Convert.ToInt32(textBox19.Text); } // при выполнении избавляемся от целой части и засовываем в числитель, рассчёт числителя первой дроби   

                            int zn1 = Convert.ToInt32(textBox20.Text), zn2;
                            int st = Convert.ToInt32(textBox25.Text);
                            
                            if (st < 0 ) //если дробь отрицательная, переварачиваем дробь
                            {
                                aa=ch1;
                                ch1 = zn1;
                                zn1 = aa;
                                st = -st;     
                            }
                            ch2 = Convert.ToInt32(Math.Pow(ch1, st)); //подсчёт числителя итоговой дроби
                            zn2 = Convert.ToInt32(Math.Pow(zn1, st)); // подсчёт знаменателя итоговой дроби

                            int div = GCD(ch2, zn2); //поиск наибольшего общего делителя(НОД)

                            textBox23.Text = (zn2 / div).ToString(); //сокращение итогового знаменателя на НОД
                            textBox24.Text = (Math.Abs((ch2 / div) % Convert.ToInt32(textBox23.Text))).ToString(); //вычисление числителя итоговой дроби
                            textBox22.Text = ((ch2 / div) / Convert.ToInt32(textBox23.Text)).ToString();  //вычисление целой части итоговой дроби
                            if ((Convert.ToInt32(textBox21.Text) == 0) && ((ch2 / div) % Convert.ToInt32(textBox23.Text) < 0)) { textBox22.Text = "-"; } // если  целая часть =0 и числитель <0 , то ставим -
                            if (Convert.ToInt32(textBox24.Text) == 0) { textBox23.Text = ""; textBox24.Text = ""; } //если числитель =0, то знаменатель и числитель оставляем пустыми
                            textBox21.Text = a;
                        }
                    }
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            textBox13.Text = "+"; //добавление плюс в текст-бокс 

            if ((textBox11.Text.Length == 0) || (textBox15.Text.Length == 0)) // проверка ввода числителя
            {
                MessageBox.Show("Введите Числитель!");
            }
            else
            {
                if ((textBox12.Text.Length == 0) || (textBox14.Text.Length == 0))  // проверка ввода знаменателя 
                {
                    MessageBox.Show("Введите число в знаменатель!");
                }

               
                { 
                int ch1, ch2, ch3; // инициализация
                    ch1 = Convert.ToInt32(textBox11.Text);
                    ch2 = Convert.ToInt32(textBox15.Text);

                    int zn1 = Convert.ToInt32(textBox12.Text), zn2 = Convert.ToInt32(textBox14.Text), zn3; //получение значений знаменателей
                    if (zn1 < 0)
                    {
                        zn1 = Math.Abs(zn1);
                        ch1 = -ch1;
                    }
                    if (zn2 < 0)
                    {
                        zn2 = Math.Abs(zn2);
                        ch2 = -ch2;
                    }
                    zn3 = zn1 * zn2; // подсчёт знаменателя итоговой дроби
                    ch3 = ch1 * zn2 + ch2 * zn1; //подсчёт числителя итоговой дроби

                    int div = GCD(ch3, zn3); //поиск наибольшего общего делителя(НОД)


                    textBox17.Text = (zn3 / div).ToString(); //сокращение итогового знаменателя на НОД
                    textBox16.Text = (Math.Abs((ch3 / div) % Convert.ToInt32(textBox17.Text))).ToString(); //вычисление числителя итоговой дроби
                    textBox18.Text = ((ch3 / div) / Convert.ToInt32(textBox17.Text)).ToString(); //вычисление целой части итоговой дроби
                    if ((Convert.ToInt32(textBox18.Text) == 0) && ((ch3 / div) % Convert.ToInt32(textBox17.Text) < 0)) { textBox18.Text = "-"; } // если  целая часть =0 и числитель <0 , то ставим -
                    if (Convert.ToInt32(textBox16.Text) == 0) { textBox17.Text = ""; textBox16.Text = ""; } //если числитель =0, то знаменатель и числитель оставляем пустыми
                     }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox13.Text = "-"; //добавление минуса в текст-бокс 

            if ((textBox11.Text.Length == 0) || (textBox15.Text.Length == 0)) // проверка ввода числителя
            {
                MessageBox.Show("Введите Числитель!");
            }
            else
            {
                if ((textBox12.Text.Length == 0) || (textBox14.Text.Length == 0))  // проверка ввода знаменателя 
                {
                    MessageBox.Show("Введите число в знаменатель!");
                }
                else
                {
                    int ch1, ch2, ch3; // инициализация
                    ch1 = Convert.ToInt32(textBox11.Text);
                    ch2 = Convert.ToInt32(textBox15.Text);

                    int zn1 = Convert.ToInt32(textBox12.Text), zn2 = Convert.ToInt32(textBox14.Text), zn3; //получение значений знаменателей
                    if (zn1 < 0)
                    {
                        zn1 = Math.Abs(zn1);
                        ch1 = -ch1;
                    }
                    if (zn2 < 0)
                    {
                        zn2 = Math.Abs(zn2);
                        ch2 = -ch2;
                    }
                    zn3 = zn1 * zn2; // подсчёт знаменателя итоговой дроби
                    ch3 = ch1 * zn2 - ch2 * zn1; //подсчёт числителя итоговой дроби

                    int div = GCD(ch3, zn3); //поиск наибольшего общего делителя(НОД)


                    textBox17.Text = (zn3 / div).ToString(); //сокращение итогового знаменателя на НОД
                    textBox16.Text = (Math.Abs((ch3 / div) % Convert.ToInt32(textBox17.Text))).ToString(); //вычисление числителя итоговой дроби
                    textBox18.Text = ((ch3 / div) / Convert.ToInt32(textBox17.Text)).ToString(); //вычисление целой части итоговой дроби
                    if ((Convert.ToInt32(textBox18.Text) == 0) && ((ch3 / div) % Convert.ToInt32(textBox17.Text) < 0)) { textBox18.Text = "-"; } // если  целая часть =0 и числитель <0 , то ставим -
                    if (Convert.ToInt32(textBox16.Text) == 0) { textBox17.Text = ""; textBox16.Text = ""; } //если числитель =0, то знаменатель и числитель оставляем пустыми
                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox13.Text = "*"; //добавление знака умножения в текст-бокс 

            if ((textBox11.Text.Length == 0) || (textBox15.Text.Length == 0)) // проверка ввода числителя
            {
                MessageBox.Show("Введите Числитель!");
            }
            else
            {
                if ((textBox12.Text.Length == 0) || (textBox14.Text.Length == 0))  // проверка ввода знаменателя 
                {
                    MessageBox.Show("Введите число в знаменатель!");
                }
                else
                {

                    int ch1, ch2, ch3; // инициализация
                    ch1 = Convert.ToInt32(textBox11.Text);
                    ch2 = Convert.ToInt32(textBox15.Text);

                    int zn1 = Convert.ToInt32(textBox12.Text), zn2 = Convert.ToInt32(textBox14.Text), zn3; //получение значений знаменателей
                    if (zn1 < 0)
                    {
                        zn1 = Math.Abs(zn1);
                        ch1 = -ch1;
                    }
                    if (zn2 < 0)
                    {
                        zn2 = Math.Abs(zn2);
                        ch2 = -ch2;
                    }
                    zn3 = zn1 * zn2; // подсчёт знаменателя итоговой дроби
                    ch3 = ch1 * ch2; //подсчёт числителя итоговой дроби

                    int div = GCD(ch3, zn3); //поиск наибольшего общего делителя(НОД)


                    textBox17.Text = (zn3 / div).ToString(); //сокращение итогового знаменателя на НОД
                    textBox16.Text = (Math.Abs((ch3 / div) % Convert.ToInt32(textBox17.Text))).ToString(); //вычисление числителя итоговой дроби
                    textBox18.Text = ((ch3 / div) / Convert.ToInt32(textBox17.Text)).ToString(); //вычисление целой части итоговой дроби
                    if ((Convert.ToInt32(textBox18.Text) == 0) && ((ch3 / div) % Convert.ToInt32(textBox17.Text) < 0)) { textBox18.Text = "-"; } // если  целая часть =0 и числитель <0 , то ставим -
                    if (Convert.ToInt32(textBox16.Text) == 0) { textBox17.Text = ""; textBox16.Text = ""; } //если числитель =0, то знаменатель и числитель оставляем пустыми


                }
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox13.Text = ":"; //добавление знака деления в текст-бокс 

            if ((textBox11.Text.Length == 0) || (textBox15.Text.Length == 0)) // проверка ввода числителя
            {
                MessageBox.Show("Введите Числитель!");
            }
            else
            {
                if ((textBox12.Text.Length == 0) || (textBox14.Text.Length == 0))  // проверка ввода знаменателя 
                {
                    MessageBox.Show("Введите число в знаменатель!");
                }
                else
                {

                    int ch1, ch2, ch3; // инициализация
                    ch1 = Convert.ToInt32(textBox11.Text);
                    ch2 = Convert.ToInt32(textBox15.Text);


                    int zn1 = Convert.ToInt32(textBox12.Text), zn2 = Convert.ToInt32(textBox14.Text), zn3; //получение значений знаменателей
                    if (zn1 < 0)
                    {
                        zn1 = Math.Abs(zn1);
                        ch1 = -ch1;
                    }
                    if (zn2 < 0)
                    {
                        zn2 = Math.Abs(zn2);
                        ch2 = -ch2;
                    }
                    zn3 = zn1 * ch2; // подсчёт знаменателя итоговой дроби
                    ch3 = ch1 * zn2; //подсчёт числителя итоговой дроби

                    int div = GCD(ch3, zn3); //поиск наибольшего общего делителя(НОД)
                    if (zn3 < 0) { ch3 = -ch3; zn3 = Math.Abs(zn3); }

                    textBox17.Text = (zn3 / div).ToString(); //сокращение итогового знаменателя на НОД
                    textBox16.Text = (Math.Abs((ch3 / div) % Convert.ToInt32(textBox17.Text))).ToString(); //вычисление числителя итоговой дроби
                    textBox18.Text = ((ch3 / div) / Convert.ToInt32(textBox17.Text)).ToString(); //вычисление целой части итоговой дроби
                    if ((Convert.ToInt32(textBox18.Text) == 0) && ((ch3 / div) % Convert.ToInt32(textBox17.Text) < 0)) { textBox18.Text = "-"; } // если  целая часть =0 и числитель <0 , то ставим -
                    if (Convert.ToInt32(textBox16.Text) == 0) { textBox17.Text = ""; textBox16.Text = ""; } //если числитель =0, то знаменатель и числитель оставляем пустыми
                    if (zn3 < 0) { ch3 = -ch3; zn3 = Math.Abs(zn3); }
                }

            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
