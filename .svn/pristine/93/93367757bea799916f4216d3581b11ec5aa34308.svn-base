using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace RCS.ViewModels
{
    public class ShoppingListItemViewModel: IComparable<ShoppingListItemViewModel>
    {
        
        public string Name { get; set; }
        public string Unit { get; set; }
        public int amount { get; set; }
        public int ShoppingListID { get; set; }

        public int CompareTo(ShoppingListItemViewModel other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
