Imports Druida_IDE_Lite.IDEcfgs.Values.AutoCompleteMenu

Public Class SettingsAutocomplete
    Private Sub SettingsAutocomplete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCFGs()
    End Sub

    Public Sub LoadCFGs()
        cbEnable.Checked = IDEcfgs.Values.AutoCompleteMenu.Enabled
        cbAllowTabKey.Checked = AllowTabKey
        cbAlwaysShowToolTip.Checked = AlwaysShowTooltip
        mtbAppearInterval.Text = AppearInterval
        mtbMinFragmentLenght.Text = MinFragmentLength
        mtbToolTipDuration.Text = ToolTipDuration
    End Sub

    Private Sub cbEnable_CheckedChanged(sender As Object, e As EventArgs) Handles cbEnable.CheckedChanged
        IDEcfgs.Values.AutoCompleteMenu.Enabled = cbEnable.Checked
    End Sub

    Private Sub cbAllowTabKey_CheckedChanged(sender As Object, e As EventArgs) Handles cbAllowTabKey.CheckedChanged
        AllowTabKey = cbAllowTabKey.Checked
    End Sub

    Private Sub cbAlwaysShowToolTip_CheckedChanged(sender As Object, e As EventArgs) Handles cbAlwaysShowToolTip.CheckedChanged
        AlwaysShowTooltip = cbAlwaysShowToolTip.Checked
    End Sub

    Private Sub mtbAppearInterval_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtbAppearInterval.MaskInputRejected
        AppearInterval = mtbAppearInterval.Text
    End Sub

    Private Sub mtbMinFragmentLenght_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtbMinFragmentLenght.MaskInputRejected
        MinFragmentLength = mtbMinFragmentLenght.Text
    End Sub

    Private Sub mtbToolTipDuration_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtbToolTipDuration.MaskInputRejected
        ToolTipDuration = mtbToolTipDuration.Text
    End Sub

End Class
