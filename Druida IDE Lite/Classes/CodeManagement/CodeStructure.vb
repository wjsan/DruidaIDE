Imports Druida_IDE_Lite.CodeObjects

Module CodeSctructureModule
    Public currentCodeStructure As New CodeStructure
End Module

Public Class CodeStructure
    Public Scope_Globall As CodeScope

    Public Sub New()
        Dim newGloballScope = New GlobalCodeScope
        Scope_Globall = newGloballScope.getGlobalScope
    End Sub
End Class
