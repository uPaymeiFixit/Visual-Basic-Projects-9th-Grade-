﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnMainMenu = New System.Windows.Forms.PictureBox()
        CType(Me.btnMainMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Impact", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.Red
        Me.lblScore.Location = New System.Drawing.Point(84, 56)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(36, 42)
        Me.lblScore.TabIndex = 0
        Me.lblScore.Text = "0"
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Image = Global.DotsGame.My.Resources.Resources.btnMainMenu
        Me.btnMainMenu.Location = New System.Drawing.Point(11, 111)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(182, 41)
        Me.btnMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMainMenu.TabIndex = 1
        Me.btnMainMenu.TabStop = False
        '
        'frmEnd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.DotsGame.My.Resources.Resources.frmGameEndBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(205, 163)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lblScore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEnd"
        Me.Text = "frmEnd"
        CType(Me.btnMainMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents btnMainMenu As System.Windows.Forms.PictureBox
End Class
