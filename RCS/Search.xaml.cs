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
using RCS.Code;
using System.Xml.Linq;
using RCS.ViewModels;


namespace RCS
{
    public partial class Search : PhoneApplicationPage
    {
        public Search()
        {
            InitializeComponent();

            //load Xml File
            XDocument countries = XDocument.Load("SampleData/Countrys.xml");
            
            //Fill List with data from xml file
            var countryList = (from c in countries.Descendants("CountryItem")
                              select new RCS.ViewModels.SelectorItemViewModel
                              {
                                 ID=(int)c.Element("ID"),
                                 Name=(string)c.Element("Name"),
                                 Image=(string)c.Element("Image")
                              }).ToList();
            
            //Add Datasource to control
            this.selectorLeft.DataSource = new ListLoopingDataSource<RCS.ViewModels.SelectorItemViewModel>() { Items = countryList, SelectedItem = countryList[1] }; 
            
			XDocument dishtypes = XDocument.Load("SampleData/dishtype.xml");
            var dishtypeList = (from d in dishtypes.Descendants("Type")
                               select new RCS.ViewModels.SelectorItemViewModel
                               {
                                   ID = (int)d.Element("ID"),
                                   Name = (string)d.Element("Name"),
                                   Image = (string)d.Element("Image")
                               }).ToList();
            this.dishtype_Selector.DataSource = new ListLoopingDataSource<RCS.ViewModels.SelectorItemViewModel>() { Items = dishtypeList, SelectedItem = dishtypeList[1] }; ;
            
			XDocument cookingTime = XDocument.Load("SampleData/CookerType.xml");
            var cookingTimeList = (from d in cookingTime.Descendants("Type")
                               select new RCS.ViewModels.SelectorItemViewModel
                               {
                                   ID = (int)d.Element("ID"),
                                   Name = (string)d.Element("Name"),
                                   Image = (string)d.Element("Image")
                               }).ToList();
            this.cookingType_Selector.DataSource = new ListLoopingDataSource<RCS.ViewModels.SelectorItemViewModel>() { Items =cookingTimeList, SelectedItem = cookingTimeList[1] }; ;
            

        }

        private void PhoneApplicationPage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
        	this.selectorLeft.UpdateItemState();
            this.dishtype_Selector.UpdateItemState();
			this.cookingType_Selector.UpdateItemState();
        }

        private void Searchbutton_Click(object sender, System.EventArgs e)
        {
        	NavigationService.Navigate(new Uri("/Results.xaml",UriKind.Relative));	
        }
    }
}
