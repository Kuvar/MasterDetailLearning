using MasterDetailLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailLearning.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterView : ContentPage
	{
        public ListView ListView;

		public MasterView ()
		{
			InitializeComponent ();

            ListView = MenuItemListView;
            MenuItems();

        }

        private void MenuItems()
        {
            List<MasterPageItem> list = new List<MasterPageItem>();
            list.Add(new MasterPageItem { Id = 1, Title = "Page 1", TargetType = typeof(DetailView) });
            list.Add(new MasterPageItem { Id = 2, Title = "Page 2", TargetType = typeof(PageView2) } );
            list.Add(new MasterPageItem { Id = 3, Title = "Page 3", TargetType = typeof(PageView3) });
            list.Add(new MasterPageItem { Id = 4, Title = "Page 4", TargetType = typeof(DetailView) });
            list.Add(new MasterPageItem { Id = 5, Title = "Page 5", TargetType = typeof(DetailView) });

            MenuItemListView.ItemsSource = list;
        }
	}
}