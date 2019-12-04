Imports Druida_IDE_Lite.IDEcfgs.Values

Public Class ProjectCFGsExplorer
    Dim ctItems() As Control = {New CFGsProject,
                                New CFGsHardware,
                                New CFGsPinout}

    Private Sub ProjectCFGsExplorer_Load(sender As Object, e As EventArgs) Handles Me.Load
        ApplyTheme()
    End Sub

    Public Sub ApplyTheme()
        tvCFGitem.BackColor = Color.FromArgb(CodeColors.BackColor)
        tvCFGitem.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        Me.BackColor = Color.FromArgb(CodeColors.ControlsColor)
    End Sub

    Private Sub tvCFGitem_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvCFGitem.AfterSelect
        ShowControlOfIndex(e.Node.Index)
    End Sub

    Public Sub ShowControlOfIndex(ByVal index As Short)
        scMain.Panel2.Controls.Clear()
        ctItems(index).Dock = DockStyle.Fill
        scMain.Panel2.AutoScroll = True
        scMain.Panel2.Controls.Add(ctItems(index))
    End Sub

    Public Sub ShowControl(ByRef control As Control)
        scMain.Panel2.Controls.Clear()
        scMain.Panel2.Controls.Add(control)
    End Sub

End Class
