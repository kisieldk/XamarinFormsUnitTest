using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using static UTSample.Mock;

namespace UTSample
{
	public partial class FirstPage : ContentPage
	{
		private FirstViewModel _firstViewModel;
		public FirstPage()
		{
			InitializeComponent();
			_firstViewModel = new FirstViewModel();
			_firstViewModel.GetTitle();
			_firstViewModel.GetMovies();			
			BindingContext = _firstViewModel;
		}
		private async void GoToDetails_OnTapped(object obj, ItemTappedEventArgs e)
		{
			Movie movie = e.Item as Movie;
			ListView lv = obj as ListView;
			lv.SelectedItem = null;
			await Navigation.PushAsync(new LabelPage(movie.MovieTitle),false);
		}
	}
}
