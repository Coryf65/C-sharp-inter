using OrderingDemo;


OrderProcessor orderProcessor = new();

Order order = new(datePlaced: DateTime.Now, totalPrice: 100f);

orderProcessor.Process(order: order);