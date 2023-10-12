abstract class Bird {
  abstract void draw();
  abstract void setLocation(double lng, double lat);
}

abstract class FlyingBird : Bird {
  abstract void setAltitude(double alt);
}

class Penguin : Bird {
  void setLocation(double lng, double lat) {...}
  void draw() {...}
}
