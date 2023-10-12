abstract class Converter {
  abstract Data toData(Document doc);
}
class XMLConverter: Converter {
  Data toData(Document doc) {...}
}
class BinaryConverter: Converter {
  Data toData(Document doc) {...}
}

class DocumentExporter {
  Converter _converter;
  void exportDocument(Document doc)
  {
    _converter.toData(doc).writeToURL(fileURL);
  }
}
