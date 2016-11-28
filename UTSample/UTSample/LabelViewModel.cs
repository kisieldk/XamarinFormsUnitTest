using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UTSample
{
	public class LabelViewModel: INotifyPropertyChanged
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
		public LabelViewModel(string movieTitle)
		{
			Title = movieTitle;
		}
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
		private string _CopyString;
		public string CopyString
		{
			get
			{
				return _CopyString;
			}
			set
			{
				_CopyString = value;
				RaisePropertyChanged();
			}
		}

		public string SaveToClipebord(string textToSave)
		{
		
			DependencyService.Get<IClipboard>().SaveTextToClipboard(textToSave);
			return DependencyService.Get<IClipboard>().GetTextFromCliboard();			
		}
	}
}
