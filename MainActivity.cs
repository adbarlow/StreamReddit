using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;

namespace StreamReddit
{
	[Activity(Label = "Stream Games with Reddit", MainLauncher = true)]
	public class MainActivity : Activity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			FindViewById<Button>(Resource.Id.NBAButton).Click += OnNBAClick;
			FindViewById<Button>(Resource.Id.NFLButton).Click += OnNFLClick;
			FindViewById<Button>(Resource.Id.MLBButton).Click += OnMLBClick;

		}

		void OnMLBClick(object sender, EventArgs e)
		{
			var intent = new Intent(Intent.ActionView);
			intent.SetData(Android.Net.Uri.Parse("https://www.reddit.com/r/MLBStreams/"));
			StartActivity(intent);
		}

		void OnNFLClick(object sender, EventArgs e)
		{
			var intent = new Intent(Intent.ActionView);
			intent.SetData(Android.Net.Uri.Parse("https://www.reddit.com/r/nflstreams"));
			StartActivity(intent);
		}

		void OnNBAClick(object sender, EventArgs e)
		{
			var intent = new Intent(Intent.ActionView);
			intent.SetData(Android.Net.Uri.Parse("https://www.reddit.com/r/nbastreams"));
			StartActivity(intent);
		}
}
}


