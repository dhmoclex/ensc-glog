public static SimpleDateFormat makeStandardHttpDateFormat()
{
  // SimpleDateFormat n'étant pas sur vis-a-vis des threads,
  // nous devons créer chaque instance indépendamment.
  SimpleDateFormat df = new SimpleDateFormat("EEE, dd MMM yyyy HH:mm:ss z");
  df.setTimeZone(TimeZone.getTimeZone("GMT"));
  return df;
}