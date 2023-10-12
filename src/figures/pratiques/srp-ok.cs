class XMLConverter {
  String exportDocToXML(Document doc) {...}
}

class XMLExporter {
  URL runSaveDialog() {...}
  void showSuccessDialog() {...}

  void exportDocument(Document doc) {
    XMLConverter converter;
    String xmlFileContent = converter.exportDocToXML(doc);
    URL fileURL = runSaveDialog();
    xmlFileContent.writeToURL(fileURL);
    showSuccessDialog();
  }
}
