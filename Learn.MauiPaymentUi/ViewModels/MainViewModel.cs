namespace Learn.MauiPaymentUi.ViewModels
{
  public class MainViewModel : ViewModelBase
  {
    private int _counter;
    private string _text;

    public MainViewModel(ISemanticScreenReader screenReader, INavigationService navService)
      : base(navService)
    {
      _screenReader = screenReader;

      Title = "Payment Sample";
      Text = "Click Me!";
    }

    public DelegateCommand CmdCounter => new DelegateCommand(OnCounter);

    public DelegateCommand CmdNavigate => new DelegateCommand(() =>
    {
      ////string navTo = $"{nameof(NavigationPage)}/{nameof(MainView)}/{nameof(Page2View)}";
      ////NavigationService.NavigateAsync(navTo);
    });

    public string Text
    {
      get => _text;
      set => SetProperty(ref _text, value);
    }

    private ISemanticScreenReader _screenReader { get; }

    private void OnCounter()
    {
      _counter++;

      if (_counter == 1)
        Text = "Clicked one time";
      else
        Text = $"Clicked {_counter} times";

      // Update accessability screen reader. Ref: https://docs.microsoft.com/en-us/dotnet/maui/fundamentals/accessibility
      _screenReader.Announce(Text);
    }
  }
}
