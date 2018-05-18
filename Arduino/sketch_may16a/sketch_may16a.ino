const int pino = 12;
void setup() {
pinMode(pino, OUTPUT);

}

void loop() {
  
  acelerar();
  delay(500);
  desacelerar();
  delay(500);
}

void acelerar(){
  for(int i = 0; i<100; i++){
    digitalWrite(pino, HIGH);
    delay(50);
    digitalWrite(pino, LOW);
    delay(50);
  }
    
}

void desacelerar(){
  for(int i = 0; i<5; i++){
    digitalWrite(pino, HIGH);
    delay(1000);
    digitalWrite(pino, LOW);
    delay(1000);
  }   
}

