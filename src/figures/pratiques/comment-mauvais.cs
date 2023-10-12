// Commentaires redondants
// Méthode utilitaire qui se termine lorsque this.closed vaut true. Elle lance
// une exception lorsque la temporisation est écoulée.
public synchronized void waitForClose(final long timeoutMillis) throws Exception {
  if(!closed) {
    wait(timeoutMillis);
    if(!closed)
      throw new Exception("MockResponseSender could not be closed");
  }
}

// Commentaires obligés
/**
 *
 * @param title Le titre du CD.
 * @param author L'auteur du CD.
 * @param tracks Le nombre de morceaux sur le CD.
 * @param durationInMinutes La durée du CD en minutes.
 */
public void addCD(String title, String author, int tracks, int durationInMinutes) {
  CD cd = new CD();
  cd.title = title;
  cd.author = author;
  cd.tracks = tracks;
  cd.duration = duration;
  cdList.add(cd);
}