namespace Learn.MauiPaymentUi.Services
{
  public class StoreService : IStoreService
  {
    private Dictionary<string, double> _cartItems = new();

    public StoreService()
    {
    }

    public Dictionary<string, double> CartItems()
    {
      return _cartItems;
    }

    public void Clear()
    {
      _cartItems.Clear();
    }

    public void SelectItem(string itemCode, double price)
    {
      if (_cartItems is null)
        _cartItems = new();

      // _cartItems.Add(itemCode, price);
      _cartItems[itemCode] = price;
    }
  }
}
