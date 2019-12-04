//*************************************************************************************************/
//   Projeto    : Teste Depurador
//   Arquivo    : TesteDepurador.ino
//   Descrição  : Configurações e loop principal
//   Data       : 07/05/2019
//*************************************************************************************************/

#include "HardwareDebugger.h"
HardwareDebugger Debugger;
#define delay Debugger.delay

void setup()
{
    // coloque aqui o seu código de configuração para ser executado uma vez:
    Debugger.begin();
}

void loop()
{
    // coloque seu código principal aqui, para executar repetidamente:
    Debugger.main();
}