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
    public partial class Results : PhoneApplicationPage
    {
        public Results()
        {
            InitializeComponent();
            XDocument results = XDocument.Load("SampleData/Recipes.xml");

            var resultList = from r in results.Descendants("Recipe")
                             select new RecipeViewModel
                             {
                                 ID= (int)r.Element("ID"),
                                 Name= (string)r.Element("Name"),
                                 Image= (string)r.Element("Image"),
                                 TrafficSignImage= (string)r.Element("TrafficSignImage")
                             };

            this.ResultList.ItemsSource = resultList;
        }

        private void ResultList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
        	 // If selected index is -1 (no selection) do nothing
            if (ResultList.SelectedIndex == -1)
                return;

            // Navigate to the new page
            NavigationService.Navigate(new Uri("/Receipe.xaml?selectedItem=" + ResultList.SelectedIndex, UriKind.Relative));

            // Reset selected index to -1 (no selection)
            ResultList.SelectedIndex = -1;
        }

        
    }
}
