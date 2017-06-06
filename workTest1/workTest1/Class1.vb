Public Class Class1

    Public Sub chkString(ByVal strLabel As String)

        If strLabel = "" Then
            MessageBox.Show("テキスト未入力なのでクリア必要なし", _
                            "注意", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Exclamation)
        Else
            MessageBox.Show("テキスト入力あり。クリア必要", _
                            "注意", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)

        End If

    End Sub

End Class
