using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApplication1 {
	/// <summary>
	/// Interaction logic for Page1.xaml
	/// </summary>
    public partial class SetParam : Page
    {
        public SetParam()
        {
			InitializeComponent();
		}

        //private void Page_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
        //    NavigationService.Navigate(new Uri("Main.xaml", UriKind.Relative));
        //}
        DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        int advs = 0;
      
        void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            advs++;
            txtTime.Text = DateTime.Now.ToString();
            //if (advs%2 ==0)
            //    label1.Content = "系统初始化中……";
            //else
            //    label1.Content = "系统初始化中…";
            //if (advs > 10)
            //{
            //    NavigationService.Navigate(new Uri("Main.xaml", UriKind.Relative));
            //    dispatcherTimer.Stop();
            //}

        }

        private void Canvas_TouchUp(object sender, TouchEventArgs e)
        {

        }

        private void Canvas_Unloaded(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            advs=0;
        }

        private void Canvas_Loaded_1(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1); ;
            dispatcherTimer.Start();
        }

        private void btnSetTime_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtTime(object sender, TextChangedEventArgs e)
        {

        }
	}
}
