<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.forButton = New System.Windows.Forms.Button()
        Me.forNextButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'forButton
        '
        Me.forButton.Location = New System.Drawing.Point(185, 23)
        Me.forButton.Name = "forButton"
        Me.forButton.Size = New System.Drawing.Size(75, 23)
        Me.forButton.TabIndex = 0
        Me.forButton.Text = "for文のテスト"
        Me.forButton.UseVisualStyleBackColor = True
        '
        'forNextButton
        '
        Me.forNextButton.Location = New System.Drawing.Point(12, 23)
        Me.forNextButton.Name = "forNextButton"
        Me.forNextButton.Size = New System.Drawing.Size(108, 23)
        Me.forNextButton.TabIndex = 0
        Me.forNextButton.Text = "for Each文のテスト"
        Me.forNextButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.forNextButton)
        Me.Controls.Add(Me.forButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents forButton As System.Windows.Forms.Button
    Friend WithEvents forNextButton As System.Windows.Forms.Button

End Class
