using Net8TestApp.ViewModels;

namespace Net8TestApp.Views;

public partial class KeyboardIssue : ContentPage
{
    public ContentPageUtil<KeyboardIssueVm> PageUtil { get; set; }

    public KeyboardIssue(KeyboardIssueVm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<KeyboardIssueVm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }
}