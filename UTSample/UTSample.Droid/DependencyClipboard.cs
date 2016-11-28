using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Runtime.CompilerServices;
using UTSample.Droid;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(DependencyClipboard))]
namespace UTSample.Droid
{
	public class DependencyClipboard : IClipboard
	{
		public string GetTextFromCliboard()
		{
			var clipboardmanager = (ClipboardManager)Forms.Context.GetSystemService(Context.ClipboardService);
			var item = clipboardmanager.PrimaryClip.GetItemAt(0);
			var text = item.Text;
			return text;
		}

		public void SaveTextToClipboard(string saveText)
		{
			var clipManager = (ClipboardManager)Forms.Context.GetSystemService(Context.ClipboardService);
			clipManager.Text = saveText;
		}
	}
}