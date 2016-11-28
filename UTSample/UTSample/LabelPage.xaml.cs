using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace UTSample
{
	public partial class LabelPage : ContentPage
	{
		private LabelViewModel lbl;
		public LabelPage(string title)
		{
			InitializeComponent();
			lbl = new LabelViewModel(title);
			BindingContext = lbl;
			testLbl.GestureRecognizers.Add(CreateGestureRecognizer());
		}

		private TapGestureRecognizer CreateGestureRecognizer()
		{
			TapGestureRecognizer regonizer = new TapGestureRecognizer();
			regonizer.Tapped += (sender, e) =>
			{
				if (sender is Label)
				{
					Label labelSender = sender as Label;
					lbl.SaveToClipebord(labelSender.Text);
				}

			};
			return regonizer;
		}
	}
}
