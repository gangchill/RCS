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
    public partial class addingradiant : PhoneApplicationPage
    {
        public addingradiant()
        {
            InitializeComponent();

            XDocument ingridients = XDocument.Load("SampleData/Ingridients.xml");

            var vegetablesList = (from r in ingridients.Descendants("Item")
                             select new RecipeViewModel
                             {
                                 ID = (int)r.Element("ID"),
                                 Name = (string)r.Element("Name"),
                                 Type= (string)r.Element("Type")
                             }).Where(m => m.Type == "Vegetables");

            this.VegetablesList.ItemsSource = vegetablesList;

            var meatList = (from r in ingridients.Descendants("Item")
                                  select new RecipeViewModel
                                  {
                                      ID = (int)r.Element("ID"),
                                      Name = (string)r.Element("Name"),
                                      Type = (string)r.Element("Type")
                                  }).Where(m => m.Type == "Meat");

            this.MeatList.ItemsSource = meatList;

            var fruitList = (from r in ingridients.Descendants("Item")
                                  select new RecipeViewModel
                                  {
                                      ID = (int)r.Element("ID"),
                                      Name = (string)r.Element("Name"),
                                      Type = (string)r.Element("Type")
                                  }).Where(m => m.Type == "Fruit");

            this.FruitList.ItemsSource = fruitList;
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
        	NavigationService.Navigate(new Uri("/Ingridients.xaml?filter=5&name=List D/",UriKind.Relative));
        }
    }
}
