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
using System.Windows.Navigation;

namespace RCS
{
    public partial class Ingridients : PhoneApplicationPage
    {
		public static IEnumerable<ShoppingListItemViewModel> listitems;
        public int _filter;
        public Ingridients()
        {
            InitializeComponent();
            XDocument ingridients = XDocument.Load("SampleData/Ingridients.xml", LoadOptions.PreserveWhitespace);
            XDocument shoppinglistIngridients = XDocument.Load("SampleData/IngridientShoppinglist.xml", LoadOptions.PreserveWhitespace);

            listitems = (from ing in ingridients.Descendants("Item")
                             join shing in shoppinglistIngridients.Descendants("Item")
                              on (int)ing.Element("ID") equals (int)shing.Element("Ingridient")
                             select new ShoppingListItemViewModel
                             {
                                 Name = (string)ing.Element("Name"),
                                 amount = (int)shing.Element("Amount"),
                                 Unit = (string)shing.Element("Unit"),
                                 ShoppingListID = (int)shing.Element("ShoppinglistID")
            
                             });

            
            this.ShoppingListItemsList.ItemsSource = listitems.Where(m => m.ShoppingListID == _filter).ToList();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string selectedIndex = "";

            if (NavigationContext.QueryString.TryGetValue("name", out selectedIndex))
            {
                this.PageTitle.Text = "Edit " + selectedIndex;
            }

            selectedIndex = "";
            if (NavigationContext.QueryString.TryGetValue("filter", out selectedIndex))
            {
                 _filter = int.Parse(selectedIndex);
                 this.ShoppingListItemsList.ItemsSource = listitems.Where(m => m.ShoppingListID == _filter).ToList();
            }
        }

        private void Add_Click(object sender, System.EventArgs e)
        {
			NavigationService.Navigate(new Uri("/addingradiant.xaml",UriKind.Relative));
        }

        private void save_Click(object sender, System.EventArgs e)
        {
        	NavigationService.Navigate(new Uri("/shoppinglist.xaml",UriKind.Relative));
        }

        private void share_Click(object sender, System.EventArgs e)
        {
        	NavigationService.Navigate(new Uri("/contact.xaml",UriKind.Relative));
        }

        private void Home_Click(object sender, System.EventArgs e)
        {
        	NavigationService.Navigate(new Uri("/MainPage.xaml",UriKind.Relative));
        }

        
    }
}
