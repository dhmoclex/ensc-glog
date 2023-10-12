interface IPrinterTasks {
  void Print(string PrintContent);
  void Scan(string ScanContent);
}
interface IFaxTasks {
  void Fax(string content);
}
interface IPrintDuplexTasks {
  void PrintDuplex(string content);
}

class HPLaserJetPrinter : IPrinterTasks, IFaxTasks, IPrintDuplexTasks {
  void Print(string PrintContent) {...}
  void Scan(string ScanContent) {...}
  void Fax(string FaxContent) {...}
  void PrintDuplex(string PrintDuplexContent) {...}
}

class LiquidInkjetPrinter : IPrinterTasks {
  void Print(string PrintContent) {...}
  void Scan(string ScanContent) {...}
}
