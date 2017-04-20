using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SVVVAPMasterApp
{
	public partial class svvapMasterUI : ContentPage
	{
		public ListView menuItems
		{
			get;
			set;
		}
		public svvapMasterUI()
		{
			InitializeComponent();
			var masterPageItem = new List<MasterPageItem>();
			masterPageItem.Add(new MasterPageItem
            {
                Title = "Welcome",
                IconSource = "menu.png",
                TargetType = typeof(WelcomePage)
            });

            masterPageItem.Add(new MasterPageItem
            {
                Title = "Video",
                IconSource = "menu.png",
                TargetType = typeof(VideosHome)
            });

            masterPageItem.Add(new MasterPageItem
            {
                Title = "News",
                IconSource = "menu.png",
                TargetType = typeof(ThursdaySabha)
            });

            masterPageItem.Add(new MasterPageItem
            {
                Title = "Registration",
                IconSource = "menu.png",
                TargetType = typeof(MahaSabha)
            });

			menuItems.ItemsSource = masterPageItem;

		}
	}
}
