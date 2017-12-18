﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace SamplePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookPage : ContentPage
    {
        public BookPage()
        {
            InitializeComponent();

            var query = UserModel.countUser(j);
            var query2 = UserModel.selectUser();
            ObservableCollection<Book> items = new ObservableCollection<Book>();
            for (var j = 1; j == query2.Count; j++)
            {
                foreach (var user in query)
                {
                   items.Add(new Book { Name = user.Name, Value = 2.5 });

                }
            }
            
           

            for (var i = 0; i < items.Count; i++)
            {
                if (items[i].Value <= 0.25)
                {
                    items[i].ValueImage = "value_0.gif";
                }

                else if (items[i].Value <= 0.75)
                {
                    items[i].ValueImage = "value_0.5.gif";
                }

                else if (items[i].Value <= 1.25)
                {
                    items[i].ValueImage = "value_1.gif";
                }

                else if (items[i].Value <= 1.75)
                {
                    items[i].ValueImage = "value_1.5.gif";
                }

                else if (items[i].Value <= 2.25)
                {
                    items[i].ValueImage = "value_2.gif";
                }

                else if (items[i].Value <= 2.75)
                {
                    items[i].ValueImage = "value_2.5.gif";
                }

                else if (items[i].Value <= 3.25)
                {
                    items[i].ValueImage = "value_3.gif";
                }

                else if (items[i].Value <= 3.75)
                {
                    items[i].ValueImage = "value_3.5.gif";
                }

                else if (items[i].Value <= 4.25)
                {
                    items[i].ValueImage = "value_4.gif";
                }

                else if (items[i].Value <= 4.75)
                {
                    items[i].ValueImage = "value_4.5.gif";
                }

                else
                {
                    items[i].ValueImage = "value_5.gif";
                }


                if (items[i].RedStar == true)
                {
                    items[i].RedStar2 = "red_star_72.png";
                }

                if (items[i].BlueBook == true)
                {
                    items[i].BlueBook2 = "blue_book_72.png";
                }

            }

            BookListView.ItemsSource = items;

        }

        private void Detail(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetailPage());
        }

        public class Book
        {
            public string Name { get; set; }

            public double Value { get; set; }

            public string ValueImage { get; set; }

            public bool RedStar { get; set; }

            public string RedStar2 { get; set; }

            public bool BlueBook { get; set; }

            public string BlueBook2 { get; set; }

        }


    }
}
