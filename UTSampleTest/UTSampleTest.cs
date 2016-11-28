using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xunit;
using UTSample;
using static UTSample.Mock;

namespace UTSampleTest
{
	public class SampleTest
	{
		[Fact]
		public void FirstTest()
		{
			Assert.True(true);
		}

		[Fact]
		public void SetAppTittle()
		{
			FirstViewModel fvm = new FirstViewModel();
			fvm.GetTitle();
			Assert.NotNull(fvm.Title);
		}
		[Fact]
		public void GetMoviesArray()
		{
			FirstViewModel fvm = new FirstViewModel();
			fvm.GetMovies();
			Assert.True(fvm.Movies.Count() > 0);
		}
		[Fact]
		public void CheckTitleInLabelPage()
		{
			string title = "Title!";
			string checkedTitle="";
			LabelViewModel lvm = new LabelViewModel(title);
			checkedTitle = lvm.Title;
			Assert.Equal(title, checkedTitle);
		}

	}
}
