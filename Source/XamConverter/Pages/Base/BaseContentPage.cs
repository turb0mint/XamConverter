﻿using Xamarin.Forms;

namespace XamConverter
{
	public class BaseContentPage<TViewModel> : ContentPage where TViewModel : BaseViewModel, new()
	{
		public BaseContentPage() => BindingContext = ViewModel;

		protected TViewModel ViewModel { get; } = new TViewModel();
	}
}
