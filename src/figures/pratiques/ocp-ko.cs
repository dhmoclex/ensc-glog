class XMLConverter {
  String toXML(Document doc) {...}
}
class BinaryConverter {
  Data toBinary(Document doc) {...}
}

enum ConverterType {XMLConverterType, BinaryConverterType}

class DocumentExporter {
  ConverterType _converterType;

  void exportDocument(Document doc) {
    switch(_converterType) {
      case ConverterType.XMLConverterType:
        var xmlConverter = ...;
        var xmlFileContent = xmlConverter.toXML(doc);
        xmlFileContent.writeToURL(fileURL);
        break;
      case ConverterType.BinaryConverterType:
        var binaryConverter = ...;
        var binaryFileContent = binaryConverter.toBinary(doc);
        binaryFileContent.writeToURL(fileURL);
        break;
    }
  }
}
