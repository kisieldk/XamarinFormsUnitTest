using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace UTSample.UITest
{
	[TestFixture(Platform.Android, Category ="a")]
	public class Tests
	{
		IApp app;
		Platform platform;
		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			//{
			//	// TODO: If the Android app being tested is included in the solution then open
			//	// the Unit Tests window, right click Test Apps, select Add App Project
			//	// and select the app projects that should be tested.
			//	app = ConfigureApp
			//		.Android
			//		// TODO: Update this path to point to your Android app and uncomment the
			//		// code if the app is not included in the solution.
			//		//.ApkFile ("../../../Android/bin/Debug/UITestsAndroid.apk")
			//		.StartApp();
		}

		[Test]
		public void AppLaunches()
		{
			//app.Query(c => c.All());
			//app.Screenshot("First screen.");
			app.Tap("Cos");
		}
	}
}

