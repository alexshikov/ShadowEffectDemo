using System;
using Xamarin.Forms;

namespace ShadowEffectDemo
{
	public class ShadowNavigationPage: NavigationPage
	{
		public ShadowNavigationPage ()
		{}

		public ShadowNavigationPage (Page page) : base (page)
		{}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();

			Effects.Add (new ShadowEffect ()
			{
				Radius = 5,
				DistanceX = 0,
				DistanceY = 0,
				Color = Color.Black
			});
		}
	}
}
