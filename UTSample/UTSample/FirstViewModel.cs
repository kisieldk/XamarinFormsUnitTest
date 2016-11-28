using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static UTSample.Mock;

namespace UTSample
{
	public class FirstViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public void RaisePropertyChanged([CallerMemberName] string propertyName = null)
		{
			if (PropertyChanged != null)
			{
				try
				{
					PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

				}
				catch (Exception ex)
				{

				}
			}
		}
		private Movie[] _movies;
		private string _title;
		public string Title
		{
			get
			{
				return _title;
			}
			set
			{
				_title = value;
				RaisePropertyChanged();
			}
		}
		public Movie[] Movies
		{
			get
			{
				return _movies;
			}
			set
			{
				_movies = value;
				RaisePropertyChanged();
			}
		}
		public void GetTitle()
		{
			Title = "";
		}

		public void GetMovies()
		{
			Movies = new Movie[] { new Movie() {ID=1,MovieTitle="Cos",PremiereDate="2016",Type="Comedy" }, new Movie() { ID = 2, MovieTitle = "Dra", PremiereDate = "2011", Type = "Drama" } };
		}
	}
}
