
// Retourne une instance du Responder en cours de test.
protected abstract Responder responderInstance();
// responderBeingTested aurait été un meilleur nom.


// Format reconnu kk:mm:ss EEE, MMM dd, yyyy
Pattern timeMatcher = Pattern.compile("\\d*:\\d*:\\d* \\w*, \\w* \\d*, \\d*");
