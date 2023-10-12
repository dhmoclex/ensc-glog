interface IPrinterTasks {
  void Print(string PrintContent);
  void Scan(string ScanContent);
  void Fax(string FaxContent);
  void PrintDuplex(string PrintDuplexContent);
}

class HPLaserJetPrinter : IPrinterTasks {
  void Print(string PrintContent) {...}
  void Scan(string ScanContent) {...}
  void Fax(string FaxContent) {...}
  void PrintDuplex(string PrintDuplexContent) {...}
}

class LiquidInkjetPrinter : IPrinterTasks {
  void Print(string PrintContent) {...}
  void Scan(string ScanContent) {...}
  void Fax(string FaxContent) {
    throw new NotImplementedException();
  }
  void PrintDuplex(string PrintDuplexContent) {
    throw new NotImplementedException();
  }
}
