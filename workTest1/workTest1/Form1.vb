Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        '�e�L�X�g�{�b�N�X�ɓ��͂�������������x���ɕ\��
        lbl1.Text = txtbox1.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '�A�v���̏I��
        Me.Close()
    End Sub

    Private Sub txtClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClear.Click

        Dim cls1 As New Class1

        cls1.chkString(lbl1.Text)

        If txtbox1.Text <> "" Then
            txtbox1.Clear()
            lbl1.Text = ""
        End If





    End Sub
End Class
