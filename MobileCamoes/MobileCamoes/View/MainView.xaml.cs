using MobileCamoes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileCamoes.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainView : ContentPage
	{
		
		public class Program
		{
			 
			 static void Main() { }

		}
		public MainView ()
		{
			InitializeComponent ();

		}

		private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			Serie serie = e.Item as Serie;
			await Navigation.PushAsync(new DetailVeiw(serie));
		}
	}
}