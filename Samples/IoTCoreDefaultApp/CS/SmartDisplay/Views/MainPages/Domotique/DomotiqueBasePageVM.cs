// Copyright (c) Microsoft Corporation. All rights reserved.

using SmartDisplay.Contracts;
using SmartDisplay.Utils;
using SmartDisplay.Views;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Networking.Connectivity;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Imaging;

namespace SmartDisplay.ViewModels
{
    public class DomotiqueBasePageVM : BaseViewModel
    {
        #region UI properties

        public string DeviceName
        {
            get { return GetStoredProperty<string>(); }
            private set { SetStoredProperty(value); }
        }
        public string IPAddress
        {
            get { return GetStoredProperty<string>(); }
            private set { SetStoredProperty(value); }
        }
        public string BoardName
        {
            get { return GetStoredProperty<string>(); }
            private set { SetStoredProperty(value); }
        }
        public BitmapImage BoardImage
        {
            get { return GetStoredProperty<BitmapImage>(); }
            private set { SetStoredProperty(value); }
        }

        public ObservableCollection<string> DevicesCollection
        {
            get { return GetStoredProperty<ObservableCollection<string>>(); }
            set { SetStoredProperty(value); }
        }

        public LanguageManager LanguageManager { get; } = LanguageManager.GetInstance();

        #endregion
        
        public DomotiqueBasePageVM() : base()
        {           
            //SubtitleFontSize = 16;
        }

        public async Task<bool> SetUpVM()
        {           
            return true;
        }

        public void TearDownVM()
        {
            
        }

        //private void NetworkInformation_NetworkStatusChanged(object sender)
        //{
        //    InvokeOnUIThread(async () => { await UpdateNetworkInfo(); });
        //}

        //#region Commands
        //private RelayCommand _securityNoticeLearnMoreCommand;
        //public ICommand SecurityNoticeLearnMoreCommand
        //{
        //    get
        //    {
        //        return _securityNoticeLearnMoreCommand ??
        //            (_securityNoticeLearnMoreCommand = new RelayCommand(unused =>
        //            {
        //                try
        //                {
        //                    AppService.PageService.NavigateTo(typeof(WebBrowserPage), "https://go.microsoft.com/fwlink/?linkid=865702");
        //                }
        //                catch (Exception ex)
        //                {
        //                    App.LogService.Write(ex.ToString(), Windows.Foundation.Diagnostics.LoggingLevel.Error);
        //                }
        //            }));
        //    }
        //}

        //private RelayCommand _securityNoticeCloseCommand;
        //public ICommand SecurityNoticeCloseCommand
        //{
        //    get
        //    {
        //        return _securityNoticeCloseCommand ??
        //            (_securityNoticeCloseCommand = new RelayCommand(unused =>
        //            {
        //                try
        //                {
        //                    MakerImageBannerVisible = false;
        //                }
        //                catch (Exception ex)
        //                {
        //                    App.LogService.Write(ex.ToString(), Windows.Foundation.Diagnostics.LoggingLevel.Error);
        //                }
        //            }));
        //    }
        //}
        //#endregion
    }   
}
