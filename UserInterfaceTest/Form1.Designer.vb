﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.cmd実行 = New System.Windows.Forms.Button()
        Me.txt商品ID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmd実行
        '
        Me.cmd実行.Location = New System.Drawing.Point(511, 280)
        Me.cmd実行.Name = "cmd実行"
        Me.cmd実行.Size = New System.Drawing.Size(297, 141)
        Me.cmd実行.TabIndex = 0
        Me.cmd実行.Text = "実行(&R)"
        Me.cmd実行.UseVisualStyleBackColor = True
        '
        'txt商品ID
        '
        Me.txt商品ID.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt商品ID.Location = New System.Drawing.Point(227, 102)
        Me.txt商品ID.Name = "txt商品ID"
        Me.txt商品ID.Size = New System.Drawing.Size(340, 43)
        Me.txt商品ID.TabIndex = 1
        '
        'Form1
        '
        Me.AcceptButton = Me.cmd実行
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 575)
        Me.Controls.Add(Me.txt商品ID)
        Me.Controls.Add(Me.cmd実行)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "テスト画面"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd実行 As Button
    Friend WithEvents txt商品ID As TextBox
End Class
