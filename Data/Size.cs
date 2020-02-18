/*
 * Size.cs
 * Author: Nathan Bean
 * Purpose: categorize side sizes
 */

using System;

namespace CowboyCafe.Data
{
    public enum Size
    {
        Small,
        Medium,
        Large
    }

    public static class EnumHandler
    {
        public static string SizeString(Size sz)
        {
            switch (sz)
            {
                case (Size.Small): return "Small";
                case (Size.Medium): return "Medium";
                case (Size.Large): return "Large";
                default: throw new ArgumentException();
            }
        }
    }
}



