// Copyright (c) Microsoft Corporation. All rights reserved.

using SmartDisplay.Controls;
using SmartDisplay.ViewModels;
using Windows.UI.Xaml.Navigation;

namespace SmartDisplay.Views
{
    public sealed partial class DomotiqueBasePage : PageBase
    {
        public DomotiqueBasePageVM ViewModel { get; } = new DomotiqueBasePageVM();
        protected override BaseViewModel ViewModelImpl => ViewModel;

        public DomotiqueBasePage()
        {
            InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            await ViewModel.SetUpVM();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            ViewModel.TearDownVM();
        }
    }
}
