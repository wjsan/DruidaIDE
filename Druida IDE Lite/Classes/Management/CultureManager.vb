Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class CultureManager
    Public Shared currentCulture As String = ""

    Public Sub setResxCulture(culture As String)
        Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(culture, True)
        Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo(culture, True)
        currentCulture = culture
    End Sub

    Public Function translateText(text As String)
        Dim currentCulture As String = Thread.CurrentThread.CurrentCulture.ToString
        If currentCulture = "pt-BR" Or currentCulture = "pt" Then Return text
        Dim index = ptTexts.ToList.IndexOf(text)
        If index = -1 Or index > enTexts.Count - 1 Then Return text
        Return enTexts(index)
    End Function

    Public Function forcedTranslationText(text As String, culture As String, Optional additionalText As String = "")
        If culture = "pt-BR" Or culture = "pt" Then Return text
        Dim index = ptTexts.ToList.IndexOf(text)
        If index = -1 Or index > enTexts.Count - 1 Then Return text
        Return enTexts(index)
    End Function

    Public Function translateFile(path As String, Optional additionalText As String = "")
        Dim currentCulture As String = Thread.CurrentThread.CurrentCulture.ToString
        If currentCulture = "pt-BR" Or currentCulture = "pt" Then Return path
        Dim index = ptFiles.ToList.IndexOf(path)
        If index = -1 Or index > enFiles.Count - 1 Then Return path
        Return enFiles(index)
    End Function

    Public Sub ShowError(message As String, Optional additionalText As String = "")
        Dim messageTranslate As String = translateText(message)
        Dim tittleTranslate As String = translateText("Erro")
        MessageBox.Show(messageTranslate & additionalText,
                        tittleTranslate,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
    End Sub

    Public Sub ShowInfo(message As String, Optional additionalText As String = "")
        Dim messageTranslate As String = translateText(message)
        Dim tittleTranslate As String = translateText("Informação")
        MessageBox.Show(messageTranslate & additionalText,
                        tittleTranslate,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Public Function ShowQuestion(message As String, Optional additionalText As String = "")
        Dim messageTranslate As String = translateText(message)
        Dim tittleTranslate As String = translateText("Confirmar")
        Dim r = MessageBox.Show(messageTranslate & additionalText,
                        tittleTranslate,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)
        Return r
    End Function

    Public Sub ShowMessage(message As String, tittle As String, Optional additionalText As String = "")
        Dim messageTranslate As String = translateText(message)
        Dim tittleTranslate As String = translateText(tittle)
        MessageBox.Show(messageTranslate & additionalText,
                        tittleTranslate)
    End Sub

    Public Sub ShowMessage(message As String, tittle As String, button As MessageBoxButtons, Optional additionalText As String = "")
        Dim messageTranslate As String = translateText(message)
        Dim tittleTranslate As String = translateText(tittle)
        MessageBox.Show(messageTranslate & additionalText,
                        tittleTranslate,
                        button)
    End Sub

    Public Sub ShowMessage(message As String, tittle As String, button As MessageBoxButtons, icon As MessageBoxIcon, Optional additionalText As String = "")
        Dim messageTranslate As String = translateText(message)
        Dim tittleTranslate As String = translateText(tittle)
        MessageBox.Show(messageTranslate & additionalText,
                        tittleTranslate,
                        button,
                        icon)
    End Sub

    Private ptTexts() = {"Novo Projeto",
                         "Abrir Projeto",
                         "Nova Biblioteca",
                         "Abrir Biblioteca",
                         "Digite o nome do código fonte principal",
                         "O diretório selecionado já existe.",
                         "Deletar Arquivos",
                         "Erro ao criar o projeto. ",
                         "Erro",
                         "Conectado",
                         "Desconectado",
                         "Sem Arquivos Recentes",
                         "Arquivo",
                         "Exportar",
                         "Arquivo de código do Arduino",
                         "Abrir Pojeto",
                         "Sair",
                         "Tem certeza que deseja sair do programa?",
                         "Salvar",
                         "Deseja salvar as alterações?",
                         "Arquivos de código",
                         "Abrir Arquivo",
                         "Importar arquivo",
                         "Novo nome",
                         "Digite o novo nome do componente selecionado: (Com a extensão!)",
                         "Digite o novo nome do componente selecionado: (Sem a extensão!)",
                         "Serão renomeados todos os arquivos essenciais do projeto.",
                         "Palavra-chave",
                         "Variável",
                         "Constante",
                         "Objeto, instância de classe ou estrutura.",
                         "Método, atributo, função ou procedimento",
                         "Tipo, ou construtor de um tipo",
                         "Biblioteca",
                         " Deseja limpar o arquivo para tentar salvá-lo novamente?",
                         "O arquivo está limpo. Tente salvá-lo agora.",
                         "Arquivo limpo",
                         "Selecione um diretório válido para realizar essa ação.",
                         "Nova Pasta",
                         "Novo trecho de código",
                         "Diretório de exemplos não encontrado.",
                         "Arquivo não encontrado.",
                         "O arquivo foi aberto com sucesso.",
                         "O arquivo foi importado com sucesso.",
                         "Diretório de bibliotecas não encontrado.",
                         "Selecione um tipo de arquivo válido.",
                         "Não é permitido caracteres especiais ou nome em branco. Favor alterar o nome.",
                         "Imagens",
                         "Importar Imagem",
                         "Digite o nome do novo projeto.",
                         "Configurações e loop principal",
                         "O arquivo já existe",
                         "Deseja continuar a pesquisa?",
                         "A pesquisa chegou ao final.",
                         "Arquivo a ser compilado para testar a biblioteca",
                         "Desrcição das estruturas da biblioteca",
                         "Implementação das estruturas da biblioteca",
                         "Tem certeza que deseja remover este item do acesso rápido?",
                         "PARÂMETROS: ",
                         "RETORNO: ",
                         "Diretórios",
                         " <CLI> executando processo... Aguarde.",
                         "Compilar",
                         "Compilando...",
                         "Aguardando...",
                         "Erro de comunicação. Verique a porta, a placa, e o processador selecionados.",
                         "Erro ao tentar acessar porta de comunicação.",
                         "Erro ao compilar o código! ",
                         "O código foi compilado com sucesso, mas existem advertências.",
                         "O diretório do compilador está incorreto",
                         "Alterar diretório do compilador",
                         "O diretório selecionado não existe.",
                         "Código compilado com sucesso!",
                         "Código enviado com sucesso!",
                         "Tem certeza que deseja limpar?",
                         "Limpar",
                         "O formato de arquivo não pode ser aberto.",
                         "Informação",
                         "Este arquivo é essencial para o seu projeto, e não pode ser deletado!",
                         "Confirmar",
                         "Tem certeza que deseja remover o arquivo ",
                         "Ao renomear esse arquivo, serão alteradas as referências e os nomes dos arquivos essenciais do projeto. Deseja continuar?",
                         "Existe uma atualização disponível. Deseja realizar o download?",
                         "Descrição e configuração dos pinos",
                         "O arquivo não existe mais. Deseja criar um novo projeto com esse nome?",
                         "O diretório do arquivo possui carcteres especiais.",
                         "Selecione uma biblioteca para importar para o código."}

    Private enTexts() = {"New Project",
                         "Open Project",
                         "New Library",
                         "Open Library",
                         "Type the name of your main source code",
                         "Selected directory already exists.",
                         "Delete Files",
                         "Error creating the project. ",
                         "Error",
                         "Connected",
                         "Disconnected",
                         "No Recent Files",
                         "File",
                         "Export",
                         "Arduino Source Code",
                         "Open Project",
                         "Exit",
                         "Are you sure to exit?",
                         "Save",
                         "Do you want to save the modifications?",
                         "Source Code",
                         "Open File",
                         "Import File",
                         "New Name",
                         "Enter the new name for selected component: (With extension!)",
                         "Enter the new name for selected component: (Without extension!)",
                         "All essential files will be renamed.",
                         "KeyWord",
                         "Variable",
                         "Constant",
                         "Object or Instance",
                         "Method",
                         "Type, or a constructor of a type",
                         "Library",
                         " Do you want to clear file content, and try to save it again?",
                         "The file is clean. Try to save it now.",
                         "Clean File",
                         "Select a valid directory.",
                         "New Folder",
                         "New Code Snippet",
                         "Examples directory not found.",
                         "File not found",
                         "The file was opened with sucess.",
                         "The file was imported with sucess.",
                         "Library directory not found",
                         "Select a valid file type.",
                         "Special characters are not alowed. Please change the name.",
                         "Images",
                         "Import image",
                         "Type a name for new project",
                         "Settings and main loop",
                         "File already exists",
                         "Do you want continue searching?",
                         "Search reach the end.",
                         "Code file to test your library.",
                         "Desrciption of library structures",
                         "Implementation of library structures",
                         "Do you want to remove this item from recent files?",
                         "PARAMETERS: ",
                         "RETURN: ",
                         "Directories",
                         " <CLI> running process... Please Wait.",
                         "Compile",
                         "Compiling...",
                         "Waiting",
                         "Communication error. Verify selecteded port and board.",
                         "Can't open serial port.",
                         "Error on compiling: ",
                         "The code was compiled successfully, but there are warnings.",
                         "Druida can't find Arduino Directory. Please, search directory, or reinstall Arduino Software on default path.",
                         "Select correct Aruino Directory",
                         "Selected directory, doesn't exists.",
                         "Code successfully compiled!",
                         "Code successfully uploaded!",
                         "Are you sure to clear?",
                         "Clear",
                         "File format not compatible.",
                         "Information",
                         "This file is essential, and can't be deleted.",
                         "Confirm",
                         "Are you sure to delete the file ",
                         "This is a essential file. All essential files will be renamed if you continue. Confirm?",
                         "A update for your software is available. Do you want to download now?",
                         "Definition of pins",
                         "This file doesn't exists. Do you want to create a file with this name?",
                         "Current directory path contain ilegal characters.",
                         "Select a library to import into the code"}

    Dim ptFiles() As String = {CodeInfo.HeaderFiles.DefaultHeader,
                               CodeInfo.ModelFiles.ArduinoDefault,
                               CodeInfo.ModelFiles.DruidaDefault,
                               CodeInfo.ModelFiles.DruidaInoDefault}
    Dim enFiles() As String = {CodeInfo.HeaderFiles.DefaultHeaderEN,
                               CodeInfo.ModelFiles.ArduinoDefaultEN,
                               CodeInfo.ModelFiles.DruidaDefaultEn,
                               CodeInfo.ModelFiles.DruidaInoDefaultEn}

End Class
