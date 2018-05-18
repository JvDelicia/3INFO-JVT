const int p1 = 13, p2 = 12, p3 = 8;
void setup() {
  pinMode(p1, OUTPUT);
  pinMode(p2, OUTPUT);
  pinMode(p3, OUTPUT);
}

void loop() {
  state(p1, 10000);
  state(p2, 3000);
  state(p3, 10000);
}

void state(int p, int d) {
  digitalWrite(p, HIGH);
  delay(d);
  digitalWrite(p, LOW);
}

