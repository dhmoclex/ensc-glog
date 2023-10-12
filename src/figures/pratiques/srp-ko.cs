class XMLExporter {
  URL runSaveDialog() {...}
  void showSuccessDialog() {...}

  String exportDocToXML(Document doc) {...}

  void exportDocument(Document doc) {
    String xmlFileContent = exportDocToXML(doc);
    URL fileURL = runSaveDialog();
    xmlFileContent.writeToURL(fileURL);
    showSuccessDialog();
  }
}
