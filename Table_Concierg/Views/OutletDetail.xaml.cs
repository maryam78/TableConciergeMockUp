using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Table_Concierg.Views;
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
    public sealed partial class OutletDetail : Page
    {
        int hubSection = -1;

        private List<Photo> photo;
        private List<MenuIn> inMenuItem;
        private List<MenuIt> itMenuItem;
        private List<MenuLe> leMenuItem;

        public OutletDetail()
        {
            this.InitializeComponent();
            this.InitializeData();
        }

        private void InitializeData()
        {

            //Photo Gallery Images
            photo = new List<Photo>();
            photo.Add(new Photo() { Image = "/Assets/PhotoGallery/1.jpg"});
            photo.Add(new Photo() { Image = "/Assets/PhotoGallery/2.jpg" });
            photo.Add(new Photo() { Image = "/Assets/PhotoGallery/3.jpg" });
            photo.Add(new Photo() { Image = "/Assets/PhotoGallery/4.jpg" });
            photo.Add(new Photo() { Image = "/Assets/PhotoGallery/5.jpg" });
            photo.Add(new Photo() { Image = "/Assets/PhotoGallery/6.jpg" });
            photo.Add(new Photo() { Image = "/Assets/PhotoGallery/7.jpg" });
            photo.Add(new Photo() { Image = "/Assets/PhotoGallery/8.jpg" });
            photo.Add(new Photo() { Image = "/Assets/PhotoGallery/9.jpg" });
            photo.Add(new Photo() { Image = "/Assets/PhotoGallery/10.jpg" });
            photo.Add(new Photo() { Image = "/Assets/PhotoGallery/11.jpg" });
            photo.Add(new Photo() { Image = "/Assets/PhotoGallery/12.jpg" });
            photo.Add(new Photo() { Image = "/Assets/PhotoGallery/13.jpg" });
            photo.Add(new Photo() { Image = "/Assets/PhotoGallery/14.jpg" });
            photo.Add(new Photo() { Image = "/Assets/PhotoGallery/15.jpg" });
            photo.Add(new Photo() { Image = "/Assets/PhotoGallery/16.jpg" });
            photo.Add(new Photo() { Image = "/Assets/PhotoGallery/17.jpg" });

            photoCollectionViewSource.Source = photo;

            //Italian Menu Items
            itMenuItem = new List<MenuIt>();
            itMenuItem.Add(new MenuIt() { Image = "/Assets/MenuItems/Italian/1.jpg" });
            itMenuItem.Add(new MenuIt() { Image = "/Assets/MenuItems/Italian/2.jpg" });
            itMenuItem.Add(new MenuIt() { Image = "/Assets/MenuItems/Italian/3.jpg" });
            itMenuItem.Add(new MenuIt() { Image = "/Assets/MenuItems/Italian/4.jpg" });
            itMenuItem.Add(new MenuIt() { Image = "/Assets/MenuItems/Italian/5.jpg" });
            itMenuItem.Add(new MenuIt() { Image = "/Assets/MenuItems/Italian/6.jpg" });
            itMenuItem.Add(new MenuIt() { Image = "/Assets/MenuItems/Italian/7.jpg" });
            itMenuItemCollectionViewSource.Source = itMenuItem;

            //Indian Menu Items
            inMenuItem = new List<MenuIn>();
            inMenuItem.Add(new MenuIn() { Image = "/Assets/MenuItems/Indian/1.jpg" });
            inMenuItem.Add(new MenuIn() { Image = "/Assets/MenuItems/Indian/2.jpg" });
            inMenuItem.Add(new MenuIn() { Image = "/Assets/MenuItems/Indian/3.jpg" });
            inMenuItem.Add(new MenuIn() { Image = "/Assets/MenuItems/Indian/4.jpg" });
            inMenuItemCollectionViewSource.Source = inMenuItem;

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
            leMenuItem.Add(new MenuLe() { Image = "/Assets/MenuItems/Lebanese/11.jng" });
            leMenuItem.Add(new MenuLe() { Image = "/Assets/MenuItems/Lebanese/12.jpg" });
            leMenuItem.Add(new MenuLe() { Image = "/Assets/MenuItems/Lebanese/13.jpg" });
            leMenuItemCollectionViewSource.Source = leMenuItem;

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter != null)
            {
                string section = e.Parameter as string;
                hubSection = Int32.Parse(section);
            }
            else
                hubSection = -1;
        }

        private void Click_GoBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void PhotoGalleryGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Frame.Navigate(typeof(PhotoGallery));
        }

        public class Photo
        {
            public string Image { get; set; }
        }

        public class MenuIt
        {
            public string Image { get; set; }
        }

        public class MenuIn
        {
            public string Image { get; set; }
        }

        public class MenuLe
        {
            public string Image { get; set; }
        }

        private void leMenuItemsGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Frame.Navigate(typeof(MenuItems));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (hubSection != -1)
                DetailHub.ScrollToSection(DetailHub.Sections[hubSection]);
        }

        private void Slot1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Reservation));
        }

        private void Slot2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Reservation));
        }

        private void Slot3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Reservation));
        }
    }
}
