using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;

namespace UTSample.UITest
{
	public class AppInitializer
	{
		private const string path = @"C:\App\UT\UTSample\UTSample\UTSample.Droid\bin\Debug\UTSample.Droid.apk";
		public static IApp StartApp(Platform platform)
		{
			return ConfigureApp.Android.StartApp();
		}
	}
}
