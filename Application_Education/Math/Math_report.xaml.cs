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
    public sealed partial class Math_report : Page
    {
        public Math_report()
        {
            this.InitializeComponent();
        }

        private void but_home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        private void but_back_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Math_main),null);
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Member exper = e.Parameter as Member;
            int fails = int.Parse(exper.failer);
            int finily = int.Parse(exper.scoter);
            int summe = fails + finily;
            int vat = summe / 60;

            this.tb1.Text = "จำนวนข้อที่ทำ " + summe + "  ข้อ";
            this.tb2.Text = "จำนวนข้อถูก  " + finily + "  ข้อ";
            this.tb3.Text = "จำนวนข้อผิด  " + fails + "  ข้อ";
            this.tb4.Text = "เฉลี่ย/วินาที  " + vat + "  ต่อข้อ";
        }
    }
}
