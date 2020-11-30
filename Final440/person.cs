using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Text;

namespace Final440
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string name, DateTime birthday, Color favoriteColor)
        {
            Name = name;
            Birthday = birthday;
            FavoriteColor = favoriteColor;
        }

        public string Name { set; get; }

        public DateTime Birthday { set; get; }

        public Color FavoriteColor { set; get; }
    };
}

