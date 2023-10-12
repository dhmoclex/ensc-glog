interface ILogger {
  void Log(string message);
}

class ConsoleLogger : ILogger {
  public void Log(string message) {...}
}

class FileLogger : ILogger {
  public void Log(string message) {...}
}

class OrderProcessor {
  readonly ILogger _logger;

  public void ProcessOrder(Order order) {
    _logger.Log("Order processed: " + order.Id);
    ...
  }
}
