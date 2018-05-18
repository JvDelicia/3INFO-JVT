const int p1 = 13, p2 = 12, p3 = 8;
void setup() {
  pinMode(p1, OUTPUT);
  pinMode(p2, OUTPUT);
  pinMode(p3, OUTPUT);
}

void loop() {
  sync();
}

void sync() {
  for(int i = 0; i <= 100; i++) {
    digitalWrite(p1, HIGH);
    delay(50);
    digitalWrite(p1, LOW);
    digitalWrite(p2, HIGH);
    delay(50);
    digitalWrite(p2, LOW);
    digitalWrite(p3, HIGH);
    delay(50);
    digitalWrite(p3, LOW);
  }
}

