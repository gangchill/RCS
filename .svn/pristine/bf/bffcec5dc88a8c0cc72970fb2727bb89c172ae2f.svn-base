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

namespace RCS.Code
{
 
    public class CountryData : IComparable<CountryData>
    {
        public string Name
        {
            get;
            set;
        }

        public string Flag
        {
            get;
            set;
        }
        public int ID
        {
            get;
            set;
        }

        #region IComparable<CityData> Members

        public int CompareTo(CountryData other)
        {
            return this.ID.CompareTo(other.ID);
        }

        #endregion
    }
}
