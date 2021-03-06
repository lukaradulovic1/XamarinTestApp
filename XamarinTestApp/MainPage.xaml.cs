using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int count = 0;
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked {count} times.";
            if (count == 10)
            { // App will stop after 10 hits
                ((Button)sender).Text = $"Antistress process finished!";
                System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
            }
        }

    }
}
