using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPageDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamicTabbed : Xamarin.Forms.TabbedPage
    {
        public DynamicTabbed()
        {
            InitializeComponent();
            CreateTabs();
        }
        private void CreateTabs()
        {
            On<Windows>().SetHeaderIconsEnabled(true);
            On<Windows>().SetHeaderIconsSize(new Size(48, 48));


            Xamarin.Forms.Page tab1 = new Tab1();
            tab1.Title = "Tab 1";
            tab1.IconImageSource = "schedule.png";
            Xamarin.Forms.Page tab2 = new Tab2();
            tab2.Title = "Tab 2";
            tab2.IconImageSource = "settings.png";

            this.Children.Add(tab1);
            this.Children.Add(tab2);

        }
    }
}