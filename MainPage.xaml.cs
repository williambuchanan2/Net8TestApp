using Net8TestApp.ViewModels;

namespace Net8TestApp
{
    public partial class MainPage : ContentPage
    {
        public ContentPageUtil<MainPageVm> PageUtil { get; set; }

        public MainPage(MainPageVm vm)
        {
            InitializeComponent();

            PageUtil = new ContentPageUtil<MainPageVm>(this, vm);
            BindingContext = PageUtil.PageBindingContext;
        }


    }
}