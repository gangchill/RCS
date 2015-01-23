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
using System.Xml.Linq;
using RCS.ViewModels;

namespace RCS
{
    public partial class shoppinglist : PhoneApplicationPage
    {
        public static List<ShoppingListViewModel> shoppingListData;
        public shoppinglist()
        {
            InitializeComponent();

            if (shoppingListData == null)
            {
                XDocument shoppingLists = XDocument.Load("SampleData/Shoppinglist.xml", LoadOptions.PreserveWhitespace);

                shoppingListData = (from s in shoppingLists.Descendants("Item")
                                    select new ShoppingListViewModel
                                    {
                                        ID = (int)s.Element("ID"),
                                        Name = (string)s.Element("Name"),
                                        Date = (string)s.Element("Date")
                                    }).ToList();
            }
            this.shoppingList_List.ItemsSource = shoppingListData;
            
            
                        
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
        	NavigationService.Navigate(new Uri("/new list.xaml",UriKind.Relative));
        }

        private void shoppingList_List_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
        	 // If selected index is -1 (no selection) do nothing
            if (shoppingList_List.SelectedIndex == -1)
                return;

            // Navigate to the new page
            NavigationService.Navigate(new Uri("/Ingridients.xaml?filter=" + ((RCS.ViewModels.ShoppingListViewModel)(shoppingList_List.SelectedItem)).ID + "&name=" + ((RCS.ViewModels.ShoppingListViewModel)(shoppingList_List.SelectedItem)).Name, UriKind.Relative));

            // Reset selected index to -1 (no selection)
            shoppingList_List.SelectedIndex = -1;
        }

        private void Home_Click(object sender, System.EventArgs e)
        {
        	NavigationService.Navigate(new Uri("/MainPage.xaml",UriKind.Relative));
        }
    }
}
