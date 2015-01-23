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
    public class SelectorItemViewModel: IComparable<SelectorItemViewModel>
    {
        int _ID;
        string _Name;
        string _Image;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Image
        {
            get { return _Image; }
            set { _Image = value; }
        }

        public int CompareTo(SelectorItemViewModel other)
        {
            return this.ID.CompareTo(other.ID);
        }
    }
}
