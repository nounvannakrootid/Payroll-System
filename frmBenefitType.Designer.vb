﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBenefitType
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
        Me.txtCodeBenefit = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtBenefit = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnSaveNew = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'txtCodeBenefit
        '
        '
        '
        '
        Me.txtCodeBenefit.Border.Class = "TextBoxBorder"
        Me.txtCodeBenefit.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.txtCodeBenefit.Location = New System.Drawing.Point(192, 26)
        Me.txtCodeBenefit.Name = "txtCodeBenefit"
        Me.txtCodeBenefit.Size = New System.Drawing.Size(255, 41)
        Me.txtCodeBenefit.TabIndex = 0
        '
        'txtBenefit
        '
        '
        '
        '
        Me.txtBenefit.Border.Class = "TextBoxBorder"
        Me.txtBenefit.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.txtBenefit.Location = New System.Drawing.Point(192, 87)
        Me.txtBenefit.Name = "txtBenefit"
        Me.txtBenefit.Size = New System.Drawing.Size(255, 41)
        Me.txtBenefit.TabIndex = 1
        '
        'LabelX1
        '
        Me.LabelX1.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.LabelX1.Location = New System.Drawing.Point(41, 31)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 35)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "លេខកូដ"
        '
        'LabelX2
        '
        Me.LabelX2.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.LabelX2.Location = New System.Drawing.Point(41, 90)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(143, 36)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "ប្រភេទប្រាក់បន្ថែម"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(378, 150)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 33)
        Me.btnCancel.TabIndex = 47
        Me.btnCancel.Text = "បិទ"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(292, 150)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 33)
        Me.btnSave.TabIndex = 46
        Me.btnSave.Text = "រក្សាទុក"
        '
        'btnSaveNew
        '
        Me.btnSaveNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSaveNew.AntiAlias = True
        Me.btnSaveNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSaveNew.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveNew.Location = New System.Drawing.Point(192, 150)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(94, 33)
        Me.btnSaveNew.TabIndex = 45
        Me.btnSaveNew.Text = "រក្សាទុក​ ថ្មី"
        '
        'frmBenefitType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 221)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnSaveNew)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtBenefit)
        Me.Controls.Add(Me.txtCodeBenefit)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBenefitType"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCodeBenefit As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtBenefit As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSaveNew As DevComponents.DotNetBar.ButtonX
End Class
