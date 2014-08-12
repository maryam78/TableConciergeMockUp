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
    /// 


    public sealed partial class MainPage : Page 
    {

        private List<Item> item;
        private List<ItemHeaders> header;
        private List<ItemCategories> category;
        private List<ItemAttire> attire;
        private List<ItemAmenities> amenity;
        private List<ItemRatings> rating;

        public MainPage()
        {
            this.InitializeComponent();
            this.InitializeData();
        }

        private void InitializeData()
        {

  
          
            header = new List<ItemHeaders>();
            header.Add(new ItemHeaders() { Header = "Name"});
            header.Add(new ItemHeaders() { Header = "Category" });
            header.Add(new ItemHeaders() { Header = "Attire" });
            header.Add(new ItemHeaders() { Header = "Amenities" });
            header.Add(new ItemHeaders() { Header = "Price" });
            header.Add(new ItemHeaders() { Header = "Rating" });
            header.Add(new ItemHeaders() { Header = "Distance" });
            header.Add(new ItemHeaders() { Header = "Availability" });
            itemHeadersCollectionViewSource.Source = header;

            category = new List<ItemCategories>();
            category.Add(new ItemCategories() { Category = "Regular Dining" });
            category.Add(new ItemCategories() { Category = "Buffet" });
            category.Add(new ItemCategories() { Category = "Bar" });
            category.Add(new ItemCategories() { Category = "Sports Bar" });
            category.Add(new ItemCategories() { Category = "Coffee Shop" });
            itemCategoriesCollectionViewSource.Source = category;

            attire = new List<ItemAttire>();
            attire.Add(new ItemAttire() { Attire = "Casual" });
            attire.Add(new ItemAttire() { Attire = "SmartCasual" });
            attire.Add(new ItemAttire() { Attire = "Formal" });
            itemAttireCollectionViewSource.Source = attire;

            amenity = new List<ItemAmenities>();
            amenity.Add(new ItemAmenities() { Amenity = "24 Hours" });
            amenity.Add(new ItemAmenities() { Amenity = "Smoking" });
            amenity.Add(new ItemAmenities() { Amenity = "Non Smoking" });
            amenity.Add(new ItemAmenities() { Amenity = "Outdoors" });
            amenity.Add(new ItemAmenities() { Amenity = "Vegetarian" });
            itemAmenitiesCollectionViewSource.Source = amenity;

            rating = new List<ItemRatings>();
            rating.Add(new ItemRatings() { Rating = "1 Star" });
            rating.Add(new ItemRatings() { Rating = "2 Stars" });
            rating.Add(new ItemRatings() { Rating = "3 Stars" });
            rating.Add(new ItemRatings() { Rating = "4 Stars" });
            rating.Add(new ItemRatings() { Rating = "5 Stars" });
            itemRatingsCollectionViewSource.Source = rating;


            item = new List<Item>();
            item.Add(new Item() { Name = "Radisson", 
                                  Location = "Dubai, Business Bay", 
                                  Phone = "+971 50 546 7876",
                                  Image = "/Assets/Outlets/Outlet_Chill.jpg",
                                  Category = "Buffet",
                                  Attire = "Formal",
                                  Price = "AED 250 for two",
                                  Rating = "5",
                                  RegularMode = true,
                                  Amenities = "/Assets/Icons/ic_action_person_Aquamarine.png" });

            item.Add(new Item() { Name = "Holiday Inn",
                                  Location = "Sharjah, Al Khan",
                                  Phone = "+971 50 234 5466",
                                  Image = "/Assets/Outlets/Outlet_Chill.jpg",
                                  Category = "Regular Dining",
                                  Attire = "Smart Casual",
                                  Price = "AED 150 for two",
                                  Rating = "3",
                                  RegularMode = true,
                                  Amenities = "/Assets/Icons/ic_action_person_Aquamarine.png" });

            item.Add(new Item() { Name = "Hilton",
                                  Location = "Dubai, Sheikh Zayed Road",
                                  Phone = "+971 50 546 7876",
                                  Image = "/Assets/Outlets/Outlet_Chill.jpg",
                                  Category = "Buffet",
                                  Attire = "Smart Casual",
                                  Price = "AED 350 for two",
                                  Rating = "5",
                                  RegularMode = true,
                                  Amenities = "/Assets/Icons/ic_action_person_Aquamarine.png" });

            item.Add(new Item() { Name = "Intercontinental",
                                  Location = "Dubai, Festival City",
                                  Phone = "+971 50 234 5466",
                                  Image = "/Assets/Outlets/Outlet_Chill.jpg",
                                  Category = "Regular Dining",
                                  Attire = "Formal",
                                  Price = "AED 150 for two",
                                  Rating = "5",
                                  RegularMode = true,
                                  Amenities = "/Assets/Icons/ic_action_person_Aquamarine.png" });

            item.Add(new Item() { Name = "Hilton",
                                  Location = "Ajman",
                                  Phone = "+971 52 299 7866",
                                  Image = "/Assets/Outlets/Outlet_Chill.jpg",
                                  Category = "Formal",
                                  Attire = "Buffet",
                                  Price = "AED 300 for two",
                                  Rating = "3",
                                  RegularMode = true,
                                  Amenities = "/Assets/Icons/ic_action_person_Aquamarine.png" });

            item.Add(new Item() { Name = "Holiday Inn",
                                  Location = "Dubai, Bar Dubai",
                                  Phone = "+971 50 234 5466",
                                  Image = "/Assets/Outlets/Outlet_Chill.jpg",
                                  Category = "Bar",
                                  Attire = "Casual",
                                  Price = "AED 150 for two",
                                  Rating = "3",
                                  RegularMode = true,
                                  Amenities = "/Assets/Icons/ic_action_person_Aquamarine.png" });

            item.Add(new Item() { Name = "Holiday Inn",
                                  Location = "Dubai, Bar Dubai",
                                  Phone = "+971 50 234 5466",
                                  Image = "/Assets/Outlets/Outlet_Chill.jpg",
                                  Category = "Bar",
                                  Attire = "Casual",
                                  Price = "AED 150 for two",
                                  Rating = "3",
                                  RegularMode = true,
                                  Amenities = "/Assets/Icons/ic_action_person_Aquamarine.png" });
            
            itemCollectionViewSource.Source = item;
            
        }

        private void Minute_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            char key = Convert.ToChar(e.Key);

            //if the key is not 0-9 prevent the event from being handled further
            if (!(key >= '0' && key <= '9'))
                e.Handled = true; 
        }

        private void Hour_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            char key = Convert.ToChar(e.Key);

            //if the key is not 0-9 prevent the event from being handled further
            if (!(key >= '0' && key <= '9'))
                e.Handled = true; 
        }

        private void Click_SearchOutlets(object sender, RoutedEventArgs e)
        {
            SearchOutput.Visibility = Visibility.Visible;
            MainPageHub.ScrollToSection(MainPageHub.Sections[1]);
        }

        private void ListView_Click(object sender, ItemClickEventArgs e)
        {
            this.Frame.Navigate(typeof(OutletDetail));
        }

        public class Item
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public string Phone { get; set; }
            public string Image { get; set; }
            public string Category { get; set; }
            public string Attire { get; set; }
            public string Price { get; set; }
            public string Rating { get; set; }
            public string Amenities { get; set; }
            public bool RegularMode { get; set; }
        }

        public class ItemHeaders
        {
            public string Header { get; set; }
        }

        public class ItemCategories
        {
            public string Category { get; set; }
        }

        public class ItemAttire
        {
            public string Attire { get; set; }
        }

        public class ItemAmenities
        {
            public string Amenity { get; set; }
        }

        public class ItemRatings
        {
            public string Rating { get; set; }
        }

        private void Availibility_Checked(object sender, RoutedEventArgs e)
        {
            List<Item> items = itemCollectionViewSource.Source as List<Item>;
            foreach (Item item in items)
            {
                item.RegularMode = false;
            }
        }

        private void Availibility_Unchecked(object sender, RoutedEventArgs e)
        {
            List<Item> items = itemCollectionViewSource.Source as List<Item>;
            foreach (Item item in items)
            {
                item.RegularMode = true;
            }
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
