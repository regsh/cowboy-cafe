using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale.ExtensionMethods
{
    public static class ExtensionMethods
    {
        //extension methods have to be static
        /// <summary>
        /// Extension method that is attached to every FrameworkElement
        /// First argument is what we are modifying, everything else is what we would typically ask for
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static T FindAncestor<T>(this DependencyObject element) where T: DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(element);

            if (parent == null) return null;

            if (parent is T) return parent as T;

            else return parent.FindAncestor<T>();
        } 
    }
}
