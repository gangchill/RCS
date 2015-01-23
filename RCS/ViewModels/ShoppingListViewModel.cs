﻿using System;
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
    public class ShoppingListViewModel :IComparable<ShoppingListViewModel>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        

        public int CompareTo(ShoppingListViewModel other)
        {
            return this.ID.CompareTo(other.ID);
        }
    }
}
