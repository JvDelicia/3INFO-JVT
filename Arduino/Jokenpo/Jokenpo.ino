const int p1 = 13, p2 = 12, p3 = 8;
int num1, num2;
//1=pedra 2 - papel, 3 - tesoura
void setup() {
  pinMode(p1, OUTPUT);
  pinMode(p2, OUTPUT);
  pinMode(p3, OUTPUT);
  
}

void loop() {
  
  play();
}

void play() {
    num1 = random(1,3);
    num2 = random(1,3);
    check();
}

void check(){
  if(num1 == num2){
    Vencedor(0);
  }
  if(num1 == 1){
    if(num2 == 2){
      Vencedor(2);
    }
    else if(num2 == 3){
      Vencedor(1);
    }
  }
  if(num1 == 2){
    if(num2 == 1){
      Vencedor(1);
    }
    else if(num2 == 3){
      Vencedor(2);
    }
  }
  if(num1 == 3){
    if(num2 == 2){
      Vencedor(1);
    }
    else if(num2 == 1){
      Vencedor(2);
    }
  }
}
void Vencedor(int res){
    if(res == 0){
      sync(p2);
    }
    else if(res == 1){
      sync(p1);
    }
    else if(res == 2){
      sync(p3);
    }
}

void sync(int p) {
  for(int i = 0; i < 30; i++) {
    digitalWrite(p, HIGH);
    delay(50);
    digitalWrite(p, LOW);
    delay(50);
  }
  digitalWrite(p, HIGH);
  delay(1500);
  digitalWrite(p, LOW);
}

