//*************************************************************************************************/
//   Projeto    : Teste Depurador
//   Arquivo    : HardwareDebugger.cpp
//   Descrição  : Debugger para monitoramento e diagnóstico de hardware
//   Data       : 07/05/2019
//*************************************************************************************************/

#include "HardwareDebugger.h"

#ifndef NUM_DIGITAL_PINS
#define NUM_DIGITAL_PINS 13
#endif // !NUM_DIGITAL_PINS

#ifndef NUM_ANALOG_PINS
#define NUM_ANALOG_PINS 6
#endif // !NUM_ANALOG_PINS

#define numRegs (2 + NUM_DIGITAL_PINS/16 + NUM_ANALOG_INPUTS)

HardwareDebugger::HardwareDebugger()
{
    DebugCOM = BqBusCmd(numRegs);
}

void HardwareDebugger::begin(long baud)
{
    DebugCOM.begin(baud);
    DebugCOM.setReg(1, (NUM_DIGITAL_PINS - 1) * 256);
}

void HardwareDebugger::main()
{
    DebugCOM.comunicacao();
    word data = DebugCOM.getReg(0);
    byte param1 = lowByte(data);
    byte param2 = highByte(data);
    int cmdReg = lowByte(DebugCOM.getReg(1));
    readDigitalPorts();
    readAnalogPorts();
    switch(cmdReg)
    {
      case 0:
        break;
      case 1:
        pinMode(param1, param2);
        resetCmd();
        break;
      case 2:
        setPinStatus(param1, param2);
        if(param2 == 0)
        {
            resetCmd();
        }
        break;
      case 3:
        setPinValue(param1, param2);
        DebugCOM.setReg(0,0);
        break;
      default:
        
        break;
    }
}

void HardwareDebugger::resetCmd()
{
    DebugCOM.setReg(0,0);
    DebugCOM.setReg(1,(NUM_DIGITAL_PINS - 1) * 256);
}

void HardwareDebugger::setPinStatus(byte pin, bool status)
{
    digitalWrite(pin, status);
}

void HardwareDebugger::setPinValue(byte pin, byte value)
{
    analogWrite(pin, value);
}

bool HardwareDebugger::getPinStatus(byte pin)
{
    bool status = digitalRead(pin);
    return(status);
}

int HardwareDebugger::getPinValue(byte pin)
{
    bool value = analogRead(pin);
    return(value);
}

void HardwareDebugger::readDigitalPorts()
{
    byte nMax = NUM_DIGITAL_PINS - 1;
    for(byte i = 2; i <= nMax; i++)
    {
        byte regN = getRegAddress(i) + 2;
        byte bitN = getBitAddress(i);
        bool status = digitalRead(i);
        DebugCOM.setRegBit(regN, bitN, status);
    }
}

void HardwareDebugger::readAnalogPorts()
{
    byte n1 = NUM_DIGITAL_PINS;
    byte n2 = n1 + NUM_ANALOG_INPUTS - 1;
    byte regN = getRegAddress(n1) + 2;
    byte cont = A0;
    for (byte i = n1; i <= n2; i++)
    {
        int value = analogRead(cont);
        DebugCOM.setReg(regN, value);
        regN++;
        cont++;
    }
}

byte HardwareDebugger::getRegAddress(byte portN)
{
    byte reg = portN / 16;
    return(reg);
}

byte HardwareDebugger::getBitAddress(byte portN)
{
    byte reg = portN / 16;
    byte bit = portN - reg * 16;
    return(bit);
}

void HardwareDebugger::delay(long time)
{
    long startMillis = millis();
    while(startMillis + time > millis())
    {
        main();
    }
}