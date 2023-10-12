abstract class Bird {
  abstract void setLocation(double lng, double lat);
  abstract void setAltitude(double alt);
  abstract void draw();
}

class Penguin : Bird {
  void setLocation(double lng, double lat) {...}
  void setAltitude(double alt) {
    //altitude can't be set because penguins can't fly
    //this function does nothing
  }
  void draw() {...}
}
