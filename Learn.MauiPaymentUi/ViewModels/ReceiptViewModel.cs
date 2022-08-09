namespace Learn.MauiPaymentUi.ViewModels
{
  public class ReceiptViewModel : ViewModelBase
  {
    public ReceiptViewModel(INavigationService navService)
      : base(navService)
    {
      Title = "Receipt";
    }

    /// <summary>Navigatte back to main page.</summary>
    public DelegateCommand CmdFinished => new DelegateCommand(async () =>
    {
      await NavigationService.GoBackToRootAsync();
    });

    /// <summary>After the page has been pushed onto the stack, and it is now visible.</summary>
    /// <param name="parameters">Navigation Parameters.</param>
    public override void OnNavigatedTo(INavigationParameters parameters)
    {
    }
  }
}
