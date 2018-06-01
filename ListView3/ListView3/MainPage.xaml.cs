using ListView3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

//
// Project adds Selection & Tapping actions to ListView2
//

namespace ListView3
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            myListView.ItemsSource = new List<Contact>
            {
                //new Contact {Name="Jaime", ImageUrl= "http://lorempixel.com/100/100/people/1", Status="sure!"},
                new Contact {Name="Jaime", ImageUrl= "https://placeimg.com/100/100/tech/any", Status="sure!"},
                new Contact {Name="Steph", ImageUrl= "https://placeimg.com/100/100/people/2", Status="not sure..."},
                new Contact {Name="Sophie", ImageUrl= "https://placeimg.com/100/100/people/3", Status="so happy"},
                new Contact {Name="Denise", ImageUrl= "https://placeimg.com/100/100/people/4", Status="resentful"},
                new Contact {Name="Caroline", ImageUrl= "https://placeimg.com/100/100/people/5", Status="am i alive?"}
            }; 
        }

        private void myListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //var contact = e.Item as Contact;
            //DisplayAlert("Tapped", contact.Name, "Ok");
        }

        private void myListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            DisplayAlert("Selected", contact.Name, "Ok");

            //myListView.SelectedItem = null;
        }
    }
}
