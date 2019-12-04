//*************************************************************************************************/
//   Projeto    : Teste Depurador
//   Arquivo    : HardwareDebugger.h
//   Descrição  : Debugger para monitoramento e diagnóstico de hardware
//   Data       : 07/05/2019
//*************************************************************************************************/

#ifndef HardwareDebugger_h
#define HardwareDebugger_h

#include "BqBusCmd.h"

class HardwareDebugger
{
public:
    HardwareDebugger();
    void begin(long baud);
    void main();
    void delay(long time);
private:
    BqBusCmd DebugCOM;
    void readDigitalPorts();
    void readAnalogPorts();
    void setPinStatus(byte pin, bool status);
    void setPinValue(byte pin, byte value);
    bool getPinStatus(byte pin);
    int getPinValue(byte pin);
    byte getRegAddress(byte portN);
    byte getBitAddress(byte portN);
    void resetCmd();
};

static HardwareDebugger Debugger;

#endif