int led_pin = 13;
int lightSensor_pin = 0;
char pp_status = 'f';
char temp_status = 'f';

void setup() {
  Serial.begin(9600);
  pinMode(led_pin, OUTPUT);
}

void loop() {
  temp_status = Serial.read();
  if (temp_status != -1) {
    pp_status = temp_status;
    Serial.write(pp_status);
  }
  Serial.write(pp_status);
  switch (pp_status) {
    case 'b':
      digitalWrite(led_pin, HIGH);
      break;
    case 'f':
      digitalWrite(led_pin, LOW);
      break;
    case 'c':
      if (isCarOnPlace())
        digitalWrite(led_pin, LOW);
      break;
  }
  if (pp_status == 'f' || pp_status == 'c') {
    if (isCarOnPlace()) {
      pp_status = 'c';
      digitalWrite(led_pin, LOW);
    }
    else {
      pp_status = 'f';
    }
  }
  delay(2000);
}

bool isCarOnPlace() {
  if (analogRead(lightSensor_pin) < 700) {
    delay(5000);
    if (analogRead(lightSensor_pin) < 700) {
      return true;
    }
  }
  return false;
}

