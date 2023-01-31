using OrderingDemo;

OrderProcessor orderProcessor = new(new ShippingCalculator());

Order order = new()
{
	TotalPrice = 100f,
	DatePlaced = DateTime.Now
};

orderProcessor.Process(order: order);