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
    public class RecipeViewModel : IComparable<RecipeViewModel>
    {
        public int ID { get; set; }
        public string Name {get;set;}
        public string Image {get;set;}
        public string RecipeText {get;set;}
        public int Callary {get;set;}
        public int Carbohydrate {get;set;}
        public int Cholesterole {get;set;}
        public string TrafficSignImage {get;set;}
        public int CountryID {get;set;}
        public int DishTypeID {get;set;}
        public string Type { get; set; }

        public int CompareTo(RecipeViewModel other)
        {
            return this.ID.CompareTo(other.ID);
        }

    }
}
