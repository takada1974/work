<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtbox1 = New System.Windows.Forms.TextBox
        Me.lbl1 = New System.Windows.Forms.Label
        Me.btn1 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtClear = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtbox1
        '
        Me.txtbox1.Location = New System.Drawing.Point(18, 175)
        Me.txtbox1.Name = "txtbox1"
        Me.txtbox1.Size = New System.Drawing.Size(247, 19)
        Me.txtbox1.TabIndex = 0
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(13, 21)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(0, 12)
        Me.lbl1.TabIndex = 1
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(18, 215)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(61, 34)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "Display"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(213, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtClear
        '
        Me.txtClear.Location = New System.Drawing.Point(100, 215)
        Me.txtClear.Name = "txtClear"
        Me.txtClear.Size = New System.Drawing.Size(66, 34)
        Me.txtClear.TabIndex = 4
        Me.txtClear.Text = "Clear"
        Me.txtClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtClear)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtbox1)
        Me.Name = "Form1"
        Me.Text = "VB test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtClear As System.Windows.Forms.Button

End Class
