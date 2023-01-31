namespace OrderingDemo;

public class Order
{
	public bool IsShipped { get; internal set; }
	public Shipment Shipment { get; internal set; }
	public float TotalPrice { get; internal set; }
	private readonly DateTime _datePlaced;

	public Order(DateTime datePlaced, float totalPrice)
	{
		_datePlaced = datePlaced;
		TotalPrice = totalPrice;
	}

}