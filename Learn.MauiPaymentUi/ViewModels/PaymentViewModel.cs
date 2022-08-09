using Learn.MauiPaymentUi.Views;

namespace Learn.MauiPaymentUi.ViewModels
{
  public class PaymentViewModel : ViewModelBase
  {
    public PaymentViewModel(INavigationService navService)
      : base(navService)
    {
      Title = "Verify Purchase";
    }

    public DelegateCommand CmdGoBack => new DelegateCommand(async () =>
    {
      var args = new NavigationParameters();
      await NavigationService.GoBackAsync(args);
    });

    public DelegateCommand CmdPurchase => new DelegateCommand(async () =>
    {
      var args = new NavigationParameters();
      args.Add("total", "$10.00");

      await NavigationService.NavigateAsync(nameof(ReceiptView), args);
    });

    /// <summary>After the page has been pushed onto the stack, and it is now visible.</summary>
    /// <param name="parameters">Navigation Parameters.</param>
    public override void OnNavigatedTo(INavigationParameters parameters)
    {
    }
  }
}
