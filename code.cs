// C++ code
//
void setup()
{
  pinMode(4, OUTPUT);
  pinMode(A0,INPUT);
  Serial.begin(9600);
}

void loop()
{
  int A= analogRead(0);
  Serial.print("A=");
  Serial.print(A);
  digitalWrite(2,!A);
  if(A<100){
  digitalWrite(4,HIGH);
  Serial.print("The street lights are on");
    }
      else
    {
  digitalWrite(4,LOW);
  Serial.print("The street lights are off");
               }           
  Serial.println();
  delay(1000);
}
