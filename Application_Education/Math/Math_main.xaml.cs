using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Application_Education.Math
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Math_main : Page
    {
        public Math_main()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Question();
            anwser();
        }
        DispatcherTimer timer = new DispatcherTimer();
        int times;
        private void but_strat_Click(object sender, RoutedEventArgs e)
        {
            Question();
            but_send.IsEnabled = true;
            times = 60;
            tb_time.Text = "" + times;
            Question();
            but_strat.IsEnabled = false;
            timer.Tick += dispatTick;
            timer.Interval = new TimeSpan(0, 0, 0, 1);
            timer.Start();
            tb_scoser.Text = "0";
        }

        private void dispatTick(object sender, object e)
        {
            if (times >= 0)
            {
                tb_time.Text = "" + times;
                times--;
            }
            else
            {
                timer.Stop();
                but_send.IsEnabled = false;
                but_strat.IsEnabled = true;

            }
        }

        private void re_but_Click(object sender, RoutedEventArgs e)
        {
            Member exper = new Member();
            exper.scoter = scoser.ToString();
            exper.failer = fail.ToString();

            this.Frame.Navigate(typeof(Math_report), exper);
        }
        //การทำงานเสรฺิม
        //ตัวเเปล
        public int x, y, r, a, b, simbot, sum, sum1, sum2, sum3;

        private void but_back_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Math_level), null);
        }

        private void but_home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        public void Question()
        {

            Random ren = new Random();

            x = ren.Next(1, 10);
            y = ren.Next(1, 10);
            r = ren.Next(1, 10);
            a = ren.Next(1, 10);
            b = ren.Next(1, 10);

            simbot = ren.Next(1, 5);

            sum = x + y;
            sum1 = x - y;
            sum2 = x * y;
            r = a * b;
            sum3 = r / a;



            if (simbot == 1)
            {
                tb_math.Text = x + " + " + y + "= ?";
            }
            else if (simbot == 2)
            {
                tb_math.Text = x + " - " + y + "= ?";
            }
            else if (simbot == 3)
            {
                tb_math.Text = x + " * " + y + "= ?";
            }
            else if (r == a * b && r >= b)
            {
                tb_math.Text = r + " / " + a + "= ?";

            }
            else
            {
                return;
            }

        }
        public int scoser, fail;
        public void anwser()

        {
            if (txt_math.Text == sum.ToString())
            {
                scoser++;
                tb_true.Text = "";
                tb_true.Text = "";
                tb_true.Text = "TRUE";
            }
            else if (txt_math.Text == sum1.ToString())
            {
                scoser++;
                tb_true.Text = "";
                tb_true.Text = "";
                tb_true.Text = "TRUE";
            }
            else if (txt_math.Text == sum2.ToString())
            {
                scoser++;
                tb_true.Text = "";
                tb_true.Text = "";
                tb_true.Text = "TRUE";
            }
            else if (txt_math.Text == sum3.ToString())
            {
                scoser++;
                tb_true.Text = "";
                tb_true.Text = "";
                tb_true.Text = "TRUE";
            }
            else
            {
                fail++;
                tb_true.Text = "";
                tb_true.Text = "FALSE";
            }


            tb_scoser.Text = "" + scoser;
        }
    }
}
