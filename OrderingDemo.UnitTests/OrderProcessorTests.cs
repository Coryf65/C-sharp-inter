using OrderingDemo;
using Newtonsoft.Json.Linq;

namespace OrderingDemo.UnitTests;

// Naming convention MethodName_Condition_Expectation

/// <summary>
/// All my Xunit test for the OrderingDemo Project
/// </summary>
public class OrderProcessorTests
{
	[Theory]
	[InlineData(3)]
	[InlineData(5)]
	[InlineData(7)]
	public void TestTheory(int value)
	{
		Assert.True(IsOdd(value));
	}

	bool IsOdd(int value)
	{
		return value % 2 == 1;
	}

	// if order is shipped we should get an exception
	[Fact]
	public void Process_OrderIsAlreadyShipped_ThrowsAnException()
	{
		// Arrange
		OrderProcessor orderProcessor = new(new FakeShippingCalculator());
		Order order = new()
		{
			Shipment = new Shipment()
		};

		// Act
		Action action = () => orderProcessor.Process(order);

		// Assert
		InvalidOperationException exception = Assert.Throws<InvalidOperationException>(action);
		//The thrown exception can be used for even more detailed assertions.
		Assert.Equal("This order is already processed.", exception.Message);
	}

	/// <summary>
	/// Check if the Is Shipped is set correctly
	/// </summary>
	[Fact]
	public void Process_OrderIsNotShipped_SetShipmentPropertyOfTheOrder()
	{
		// Arrange
		OrderProcessor orderProcessor = new(new FakeShippingCalculator());
		Order order = new();

		// Act
		orderProcessor.Process(order);

		// Assert
		Assert.True(order.IsShipped);
	}

	/// <summary>
	/// Check the Shipment Cost to equal 1f
	/// </summary>
	[Fact]
	public void Process_OrderCostSet_OrderCostIsOne()
	{
		// Arrange
		OrderProcessor orderProcessor = new(new FakeShippingCalculator());
		Order order = new();

		// Act
		orderProcessor.Process(order);

		// Assert
		Assert.Equal(1f , order.Shipment.Cost);
	}

	/// <summary>
	/// Check the Shipment Date should be tommorrow
	/// </summary>
	[Fact]
	public void Process_OrderShipmentDate_ShipmentDateIsTommorrow()
	{
		// Arrange
		OrderProcessor orderProcessor = new(new FakeShippingCalculator());
		Order order = new();

		// Act
		orderProcessor.Process(order);

		// Assert
		Assert.Equal(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
	}
}

/// <summary>
/// Creating a fake class so we can test our order processor only
/// </summary>
public class FakeShippingCalculator : IShippingCalculator
{
	public float CalculateShipping(Order order)
	{
		return 1f;
	}
}