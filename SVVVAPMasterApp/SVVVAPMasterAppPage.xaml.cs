using Xamarin.Forms;
using System;

namespace SVVVAPMasterApp
{
	public partial class SVVVAPMasterAppPage : MasterDetailPage
	{
		void menuItem_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                svvvapMaster.menuItems.SelectedItem = null;
                IsPresented = false;            
			}
		}

		public SVVVAPMasterAppPage()
		{
			InitializeComponent();
			svvvapMaster.menuItems.ItemSelected += menuItem_ItemSelected;
		}
	}
}
