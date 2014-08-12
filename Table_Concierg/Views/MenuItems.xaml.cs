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

namespace Table_Concierg
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MenuItems : Page
    {
        private List<MenuLe> leMenuItem;

        public MenuItems()
        {
            this.InitializeComponent();
            this.InitializeData();
        }

        private void InitializeData()
        {

            //Lebanese Menu Items
            leMenuItem = new List<MenuLe>();
            leMenuItem.Add(new MenuLe() { Image = "/Assets/MenuItems/Lebanese/1.jpg" });
            leMenuItem.Add(new MenuLe() { Image = "/Assets/MenuItems/Lebanese/2.jpg" });
            leMenuItem.Add(new MenuLe() { Image = "/Assets/MenuItems/Lebanese/3.jpg" });
            leMenuItem.Add(new MenuLe() { Image = "/Assets/MenuItems/Lebanese/4.jpg" });
            leMenuItem.Add(new MenuLe() { Image = "/Assets/MenuItems/Lebanese/5.jpg" });
            leMenuItem.Add(new MenuLe() { Image = "/Assets/MenuItems/Lebanese/6.jpg" });
            leMenuItem.Add(new MenuLe() { Image = "/Assets/MenuItems/Lebanese/7.jpg" });
            leMenuItem.Add(new MenuLe() { Image = "/Assets/MenuItems/Lebanese/8.jpg" });
            leMenuItem.Add(new MenuLe() { Image = "/Assets/MenuItems/Lebanese/9.jpg" });
            leMenuItem.Add(new MenuLe() { Image = "/Assets/MenuItems/Lebanese/10.jpg" });
            leMenuItem.Add(new MenuLe() { Image = "/Assets/MenuItems/Lebanese/11.png" });
            leMenuItem.Add(new MenuLe() { Image = "/Assets/MenuItems/Lebanese/12.jpg" });
            leMenuItem.Add(new MenuLe() { Image = "/Assets/MenuItems/Lebanese/13.jpg" });
            leMenuItemCollectionViewSource.Source = leMenuItem;
        }

        public class MenuLe
        {
            public string Image { get; set; }
        }

        private void Click_GoBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OutletDetail), "3");
        }
    }
}
