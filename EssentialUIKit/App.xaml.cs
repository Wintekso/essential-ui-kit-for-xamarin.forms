using EssentialUIKit.AppLayout.Views;
#if EnableAppCenterAnalytics
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
#endif
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace EssentialUIKit
{
    /// <summary>
    /// The UITemplate Application
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="App" /> class.
        /// </summary>
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mzc4MTUxQDMxMzgyZTM0MmUzMGxMVk96UG93bERwNHdGZUFBYzJBaDU1bzNqMFp5QmJJN1Rub1lvc1VuR1U9;Mzc4MTUyQDMxMzgyZTM0MmUzMFF0dm1zbWlHSnlkeXhRMEwwUGErZHZxNkU2QXZjVHgyTHI5b1A2NzN0Wk09;Mzc4MTUzQDMxMzgyZTM0MmUzMEFVMTAxc3Z0ejFKMzdPR2Vnait2Y3hvbjdkRHR3bEdQVkpPdW9POEI5eTg9;Mzc4MTU0QDMxMzgyZTM0MmUzMGVlUmlzN2h5eUVNZGZpVFFLVUtjcUdvNmFQZThpS0FFdWtlaE5ueWNtdDA9;Mzc4MTU1QDMxMzgyZTM0MmUzME5PdGQ1NFIwcmhDaHVmY2FEVUl4aXZkL3lkQmdzT2poQjZIK1NKWk1EVDg9;Mzc4MTU2QDMxMzgyZTM0MmUzMFJPS0oyZGFhSUJFdTd5Vm11aTg2S3NBN1Z2M1VLMWh1OTc5YnlSMG9tUWs9;Mzc4MTU3QDMxMzgyZTM0MmUzMGRlQWMvSEhIbUVtaVU4ZFluOGlUR25YUmVDVzZaR0dud3FON1locXB4RTA9;Mzc4MTU4QDMxMzgyZTM0MmUzMFp3L2RoZnZRdjZHa1RRcDdmU2gyU2QyRzhuNjc4WVVhOVF2clhHdVd2ZmM9;Mzc4MTU5QDMxMzgyZTM0MmUzMG02RlNvV0V5R2xERmdQQVpTSTVqcGVXU1BSU0xpcmNPUkhySExhY2lMWnM9;Mzc4MTYwQDMxMzgyZTM0MmUzMEZHaXpHS1d0c3RKTGI0TW5tZ1V4T2RnK3I5dmVLampQY1BXaUpGbVBTOWs9");

#if EnableAppCenterAnalytics
            // AppCenter.Start(
            //    $"ios={AppSettings.IOSSecretCode};android={AppSettings.AndroidSecretCode};uwp={AppSettings.UWPSecretCode}",
            //    typeof(Analytics),
            //    typeof(Crashes));
#endif

            InitializeComponent();

            // this.MainPage = new AppShell();
            this.MainPage = new NavigationPage(new HomePage());


        }

        #endregion

        #region Properties

        public static string BaseImageUrl { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when your app starts
        /// </summary>
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        /// <summary>
        /// Invoked when your app sleeps
        /// </summary>
        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        /// <summary>
        /// Invoked when your app resumes
        /// </summary>
        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        #endregion
    }
}