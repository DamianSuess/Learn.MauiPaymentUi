namespace Learn.MauiPaymentUi;

public partial class MainView : ContentPage
{
  private int _count = 0;

  public MainView()
  {
    InitializeComponent();
  }

  private void OnCounterClicked(object sender, EventArgs e)
  {
    _count++;

    if (_count == 1)
      CounterBtn.Text = $"Clicked {_count} time";
    else
      CounterBtn.Text = $"Clicked {_count} times";

    SemanticScreenReader.Announce(CounterBtn.Text);
  }
}
