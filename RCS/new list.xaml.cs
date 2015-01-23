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
using System.IO.IsolatedStorage;
using System.IO;
using System.Windows.Resources;
using System.Xml;

namespace RCS
{
    public partial class new_list : PhoneApplicationPage
    {

        public static int slistid=10;
        public new_list()
        {
            InitializeComponent();
        }


        private void AddButton_Click(object sender, System.EventArgs e)
        {

            using (IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication())
            {
                
                if(isf.FileExists("SampleData/Shoppinglist.xml")){
                using (var strmSettings = isf.OpenFile("SampleData/Shoppinglist.xml", FileMode.Open, FileAccess.ReadWrite))
                {

                    Uri uri = new Uri("SampleData/Shoppinglist.xml", UriKind.RelativeOrAbsolute);
                    StreamResourceInfo sri = App.GetResourceStream(uri);
                    StreamReader sr = new StreamReader(sri.Stream);


                    XDocument shoppingLists = null;
                    try
                    {
                        XDocument.Load("SampleData/Shoppinglist.xml", LoadOptions.PreserveWhitespace);
                    }
                    catch (Exception ex)
                    {

                    }
                    XElement list = new XElement("Item");
                    list.Add(new XElement("Name", this.txtName.Text));
                    list.Add(new XElement("Date", DateTime.Now.Date.ToString()));
                    list.Add(new XElement("ID", 100));

                    shoppingLists.Add(list);
                    shoppingLists.Save(strmSettings);
                    strmSettings.Close();
                }
                }
                else{

                    shoppinglist.shoppingListData.Add(new ShoppingListViewModel
                                                    {
                                                        Date = DateTime.Now.ToString().Split(' ')[0],
                                                        Name = this.txtName.Text,
                                                        ID = slistid
                                                    });
                    NavigationService.Navigate(new Uri("/shoppinglist.xaml", UriKind.Relative));

                }
            }
        }
    }
}
