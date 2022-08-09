namespace Learn.MauiPaymentUi.Services
{
  public interface IStoreService
  {
    Dictionary<string, double> CartItems();

    /// <summary>Select item for purchase</summary>
    /// <param name="itemCode">Item Code or UPC.</param>
    /// <param name="price">Price of item.</param>
    void SelectItem(string itemCode, double price);

    /// <summary>Clear cart.</summary>
    void Clear();
  }
}
