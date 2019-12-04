'Imports Druida_IDE_Lite.Objects

'Public Class InitialClasses

'    Public Function getStringClass()
'        Dim StringClass As New objClass("String //Constrói uma instância da classe String", 0)
'        'StringClass.addPublicFunction(Method("char charAt(n)",
'        '                                     "Acessa um caractere em uma determinada posição na String.",
'        '                                     "n: a posição do caractere a ser lido da String",
'        '                                     "O caractere na posição n da String."))
'        'StringClass.addPublicFunction(Method("int compareTo(minhaString)",
'        '                                     "Compara duas Strings, testando se uma vem antes da outra na tabela ASCII, ou se são iguais.",
'        '                                     "minhaString: variável do tipo String",
'        '                                     "um número negativo: se minhaString vem antes de minhaString2\n0: se minhaString é igual a minhaString2\num número positivo: se minhaString vem depois de minhaString2"))
'        'StringClass.addPublicFunction(Method("bool concat(param)",
'        '                                     "Adiciona o parâmetro ao final da String.",
'        '                                     "param: Tipos de dados permitidos String, string, char, byte, int, unsigned int, long, unsigned long, \nfloat, double, e a __FlashStringHelper(macro F()).",
'        '                                     "true: sucesso\nfalse: falha ( em qual a String é deixada como antes)."))
'        'StringClass.addPublicFunction(Method("void c_str()",
'        '                                     "Converte o conteúdo de um objeto String para uma string estilo C, terminada em null.",
'        '                                     "Nenhum",
'        '                                     "Um ponteiro para a versão em estilo C do objeto String."))
'        'StringClass.addPublicFunction(Method("bool endsWith(minhaString)",
'        '                                     "Testa se uma String termina ou não com os caracteres de outra String.",
'        '                                     "minhaString: variável do tipo String",
'        '                                     "true: se minhaString termina com os carcateres de minhaString\nfalse: do contrário"))
'        'StringClass.addPublicFunction(Method("bool equals(minhaString)",
'        '                                     "Verifica se duas Strings são iguais.",
'        '                                     "minhaString: variável do tipo String",
'        '                                     "true: se minhaString é igual a minhaString2\nfalse: do contrário"))
'        'StringClass.addPublicFunction(Method("bool equalsIgnoreCase(minhaString)",
'        '                                     "Verifica se duas strings são iguais. A comparação, nesse caso, não é case-sensitive.",
'        '                                     "minhaString: variável do tipo String",
'        '                                     "true: se minhaString é igual a minhaString (sem diferenciar maiúsculas e minúsculas)2\nfalse: do contrário"))
'        'StringClass.addPublicFunction(Method("bool equalsIgnoreCase(minhaString)",
'        '                                     "Verifica se duas strings são iguais. A comparação, nesse caso, não é case-sensitive.",
'        '                                     "minhaString: variável do tipo String",
'        '                                     "true: se minhaString é igual a minhaString (sem diferenciar maiúsculas e minúsculas)2\nfalse: do contrário"))
'        'StringClass.addPublicFunction(Method("void getBytes(buf, len)",
'        '                                     "Copia os caracteres da String para o buffer fornecido.",
'        '                                     "buf: o buffer no qual os caracteres devem ser copiados (byte [])\nlen: o tamanho do buffer (unsigned int)",
'        '                                     "Nada"))
'        'StringClass.addPublicFunction(Method("int indexOf(string)",
'        '                                     "Localiza um caractere ou String dentro de outra String.",
'        '                                     "string: a string a ser procurada - char ou String",
'        '                                     "A posição da minhaString especificada dentro do objeto String, ou -1 se não for encontrada."))
'        'StringClass.addPublicFunction(Method("int indexOf(string, desde)",
'        '                                     "Localiza um caractere ou String dentro de outra String.",
'        '                                     "string: a string a ser procurada - char ou String\ndesde: a posição a partir da qual iniciar a busca",
'        '                                     "A posição da minhaString especificada dentro do objeto String, ou -1 se não for encontrada."))
'        'StringClass.addPublicFunction(Method("int lastIndexOf(string)",
'        '                                     "Localiza a última ocorrência de um caractere ou String dentro de outra String.",
'        '                                     "string: a string a ser procurada - char ou String",
'        '                                     "A posição da minhaString especificada dentro do objeto String, ou -1 se não for encontrada."))
'        'StringClass.addPublicFunction(Method("int lastIndexOf(string, desde)",
'        '                                     "Localiza a última ocorrência de um caractere ou String dentro de outra String.",
'        '                                     "string: a string a ser procurada - char ou String\ndesde: a posição a partir da qual iniciar a busca",
'        '                                     "A posição da minhaString especificada dentro do objeto String, ou -1 se não for encontrada."))
'        'StringClass.addPublicFunction(Method("int length()",
'        '                                     "Retorna o comprimento da String, em caracteres.",
'        '                                     "Nenhum",
'        '                                     "O comprimento da String em caracteres."))
'        'StringClass.addPublicFunction(Method("void remove(index)",
'        '                                     "Modifica uma String, removendo os caracteres a partir de determinado índice até o final da String.",
'        '                                     "index: índice a partir do qual remover os caracteres -int",
'        '                                     "Nada."))
'        'StringClass.addPublicFunction(Method("void remove(index, count)",
'        '                                     "Modifica uma String, removendo os caracteres a partir de determinado índice até número \nde caracteres a partir do índice fornecido.",
'        '                                     "index: índice a partir do qual remover os caracteres -int\ncount: o número de caracteres a serem removidos a partir do indíce - int",
'        '                                     "Nada."))
'        'StringClass.addPublicFunction(Method("void replace(substring1, substring2)",
'        '                                     "A função replace() permite substituir todas as instâncias de um determinado caractere por outro caractere.",
'        '                                     "substring1: variável do tipo String\nsubstring2: variável do tipo String",
'        '                                     "Nada."))
'        'StringClass.addPublicFunction(Method("void reserve(tamanho)",
'        '                                     "A função reserve() permite alocar um buffer de memória no objeto String para manipular strings.",
'        '                                     "tamanho: número de bytes na memória a serem reservados para manipulação de strings - unsigned int",
'        '                                     "Nada."))
'        'StringClass.addPublicFunction(Method("void setCharAt(index, c)",
'        '                                     "Coloca um caractere em determinada posição da String.",
'        '                                     "index: a posição a se escrever o caractere\nc: o caractere a ser armazenado na posição dada",
'        '                                     "Nada."))
'        'StringClass.addPublicFunction(Method("bool startsWith(minhaString)",
'        '                                     "Testa se uma String começa ou não com os caracteres de uma outra String.",
'        '                                     "minhaString: variável do tipo String",
'        '                                     "true: se minhaString começa com os carcateres de minhaString\nfalse: do contrário."))
'        'StringClass.addPublicFunction(Method("string substring(inicio)",
'        '                                     "Retorna uma substring de uma String.",
'        '                                     "inicio: o índice no qual começar a substring",
'        '                                     "A substring"))
'        'StringClass.addPublicFunction(Method("void toCharArray(buf, compr)",
'        '                                     "Copia os caracteres da String para o buffer fornecido.",
'        '                                     "buf: o buffer no qual os caracteres devem ser copiados(char [])\ncompr: o comprimento do buffer (unsigned int)",
'        '                                     "Nada"))
'        'StringClass.addPublicFunction(Method("double toDouble()",
'        '                                     "Converte uma String válida para um double.",
'        '                                     "Nenhum",
'        '                                     "O número contido na String - float"))
'        'StringClass.addPublicFunction(Method("int toInt()",
'        '                                     "Converte uma String válida para um Int.",
'        '                                     "Nenhum",
'        '                                     "O número contido na String - Int"))
'        'StringClass.addPublicFunction(Method("float toFloat()",
'        '                                     "Converte uma String válida para um Float.",
'        '                                     "Nenhum",
'        '                                     "O número contido na String - Float"))
'        'StringClass.addPublicFunction(Method("void toLowerCase()",
'        '                                     "Converte uma String para sua versão composta apenas de letras minúsculas.",
'        '                                     "Nenhum",
'        '                                     "Nada"))
'        'StringClass.addPublicFunction(Method("void toUpperCase()",
'        '                                     "Converte uma String para sua versão composta apenas de letras maiúsculas.",
'        '                                     "Nenhum",
'        '                                     "Nada"))
'        'StringClass.addPublicFunction(Method("void trim()",
'        '                                     "Remove quaisquer espaços no começo ou final da String.",
'        '                                     "Nenhum",
'        '                                     "Nada"))
'        Return StringClass
'    End Function

'    Private Function Method(name As String, description As String, parameters As String, ret As String)
'        Return New objFunction(name & " //" & description & "\n\n" & "PARAMETROS:\n" & parameters & "\n\n" & "RETORNO:\n" & ret, 0)
'    End Function
'End Class
