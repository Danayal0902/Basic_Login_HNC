using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Basic_Login
{
    public partial class Calculator : PhoneApplicationPage
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";

        }

        private void btnDecimal_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + ".";
            txtDisplay.Text = "dot";

        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            if (txt4.Text == "dot")
            {
                Decimal a = Convert.ToDecimal(txtDisplay.Text);
                txt2.Text = Convert.ToString(a);
            }
            else
            {
                Int16 a = Convert.ToInt16(txtDisplay.Text);
                txt2.Text = Convert.ToString(a);
            }
            txtDisplay.Text = "";

            txt3.Text = "divide";

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txt4.Text == "dot")
            {
                Decimal a = Convert.ToDecimal(txtDisplay.Text);
                txt2.Text = Convert.ToString(a);
            }
            else
            {

                Int16 a = Convert.ToInt16(txtDisplay.Text);
                txt2.Text = Convert.ToString(a);
            }
            txtDisplay.Text = "";

            txt3.Text = "sum";


        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {

            if (txt3.Text == "div")
            {
                if (txt4.Text == "dot")
                {
                    Decimal a = Convert.ToDecimal(txt2.Text);
                    Decimal b = Convert.ToDecimal(txtDisplay.Text);
                    txtDisplay.Text = Convert.ToString(a / b);
                }
                else
                {
                    Int16 a = Convert.ToInt16(txt2.Text);
                    Int16 b = Convert.ToInt16(txtDisplay.Text);
                    txtDisplay.Text = Convert.ToString(a / b);
                }

            }
            if (txt3.Text == "mul")
            {
                if (txt4.Text == "dot")
                {
                    Decimal a = Convert.ToDecimal(txt2.Text);
                    Decimal b = Convert.ToDecimal(txtDisplay.Text);
                    txtDisplay.Text = Convert.ToString(a * b);
                }
                else
                {
                    Int16 a = Convert.ToInt16(txt2.Text);
                    Int16 b = Convert.ToInt16(txtDisplay.Text);
                    txtDisplay.Text = Convert.ToString(a * b);
                }

            }
            if (txt3.Text == "sum")
            {
                if (txt4.Text == "dot")
                {
                    Decimal a = Convert.ToDecimal(txt2.Text);
                    Decimal b = Convert.ToDecimal(txtDisplay.Text);
                    txtDisplay.Text = Convert.ToString(a + b);
                }
                else
                {
                    Int16 a = Convert.ToInt16(txt2.Text);
                    Int16 b = Convert.ToInt16(txtDisplay.Text);
                    txtDisplay.Text = Convert.ToString(a + b);
                }

            }
            if (txt3.Text == "minus")
            {
                if (txt4.Text == "dot")
                {
                    Decimal a = Convert.ToDecimal(txt2.Text);
                    Decimal b = Convert.ToDecimal(txtDisplay.Text);
                    txtDisplay.Text = Convert.ToString(a - b);
                }
                else
                {
                    Int16 a = Convert.ToInt16(txt2.Text);
                    Int16 b = Convert.ToInt16(txtDisplay.Text);
                    txtDisplay.Text = Convert.ToString(a - b);


                }
            }
        }
    }
}
  