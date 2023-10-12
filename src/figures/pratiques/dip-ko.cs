class ConsoleLogger {
  public void Log(string message) {...}
}

class FileLogger {
  public void Log(string message) {...}
}

class OrderProcessor {
  readonly ConsoleLogger _logger;

  public void ProcessOrder(Order order) {
    _logger.Log("Order processed: " + order.Id);
    ...
  }
}
