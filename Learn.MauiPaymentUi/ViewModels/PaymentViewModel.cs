using Learn.MauiPaymentUi.Services;
using Learn.MauiPaymentUi.Views;

namespace Learn.MauiPaymentUi.ViewModels
{
  public class PaymentViewModel : ViewModelBase
  {
    private readonly IPaymentService _paymentService;
    private readonly IStoreService _storeService;
    private string _cardNumber;
    private string _cardCvv;
    private string _cardExpirationDate;

    public PaymentViewModel(INavigationService navService, IStoreService store, IPaymentService payment)
      : base(navService)
    {
      Title = "Verify Purchase";
      _storeService = store;
      _paymentService = payment;
    }

    public DelegateCommand CmdGoBack => new DelegateCommand(async () =>
    {
      var args = new NavigationParameters();
      await NavigationService.GoBackAsync(args);
    });

    public DelegateCommand CmdPurchase => new DelegateCommand(async () =>
    {
      if (IsValidPurchase())
      {
        var args = new NavigationParameters();
        args.Add("total", "$10.00");

        await NavigationService.NavigateAsync(nameof(ReceiptView), args);
      }
      else
      {
        // TODO: Show warning prompt/dialog
      }
    });

    public string CardNumber
    {
      get => _cardNumber;
      set => SetProperty(ref _cardNumber, value);
    }

    public string CardCvv
    {
      get => _cardCvv;
      set => SetProperty(ref _cardCvv, value);
    }

    public string CardExpirationDate
    {
      get => _cardExpirationDate;
      set => SetProperty(ref _cardExpirationDate, value);
    }

    /// <summary>After the page has been pushed onto the stack, and it is now visible.</summary>
    /// <param name="parameters">Navigation Parameters.</param>
    public override void OnNavigatedTo(INavigationParameters parameters)
    {
    }

    private bool IsValidPurchase()
    {
      // TODO:
      //  1) Validate items are in cart
      //  2) Validate Credit Card

      return true;
    }
  }
}
