﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkExcel
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbRuta = New System.Windows.Forms.TextBox()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.btnExplorarExcel = New System.Windows.Forms.Button()
        Me.lblContingutCela = New System.Windows.Forms.Label()
        Me.btnEscollirCarpeta = New System.Windows.Forms.Button()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.lbFitxers = New System.Windows.Forms.ListBox()
        Me.lblDeLlista = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbRuta
        '
        Me.tbRuta.Location = New System.Drawing.Point(95, 102)
        Me.tbRuta.Name = "tbRuta"
        Me.tbRuta.Size = New System.Drawing.Size(378, 20)
        Me.tbRuta.TabIndex = 0
        '
        'btnExaminar
        '
        Me.btnExaminar.Location = New System.Drawing.Point(540, 161)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(149, 36)
        Me.btnExaminar.TabIndex = 1
        Me.btnExaminar.Text = "Escollir Fitxer"
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'btnExplorarExcel
        '
        Me.btnExplorarExcel.Location = New System.Drawing.Point(540, 229)
        Me.btnExplorarExcel.Name = "btnExplorarExcel"
        Me.btnExplorarExcel.Size = New System.Drawing.Size(170, 35)
        Me.btnExplorarExcel.TabIndex = 2
        Me.btnExplorarExcel.Text = "Explorar Excel"
        Me.btnExplorarExcel.UseVisualStyleBackColor = True
        '
        'lblContingutCela
        '
        Me.lblContingutCela.AutoSize = True
        Me.lblContingutCela.Location = New System.Drawing.Point(276, 379)
        Me.lblContingutCela.Name = "lblContingutCela"
        Me.lblContingutCela.Size = New System.Drawing.Size(39, 13)
        Me.lblContingutCela.TabIndex = 3
        Me.lblContingutCela.Text = "Label1"
        '
        'btnEscollirCarpeta
        '
        Me.btnEscollirCarpeta.Location = New System.Drawing.Point(240, 31)
        Me.btnEscollirCarpeta.Name = "btnEscollirCarpeta"
        Me.btnEscollirCarpeta.Size = New System.Drawing.Size(115, 36)
        Me.btnEscollirCarpeta.TabIndex = 4
        Me.btnEscollirCarpeta.Text = "Escollir Carpeta"
        Me.btnEscollirCarpeta.UseVisualStyleBackColor = True
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(50, 102)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(39, 13)
        Me.lblPath.TabIndex = 5
        Me.lblPath.Text = "PATH:"
        '
        'lbFitxers
        '
        Me.lbFitxers.FormattingEnabled = True
        Me.lbFitxers.Location = New System.Drawing.Point(95, 161)
        Me.lbFitxers.Name = "lbFitxers"
        Me.lbFitxers.Size = New System.Drawing.Size(378, 199)
        Me.lbFitxers.TabIndex = 6
        '
        'lblDeLlista
        '
        Me.lblDeLlista.AutoSize = True
        Me.lblDeLlista.Location = New System.Drawing.Point(95, 142)
        Me.lblDeLlista.Name = "lblDeLlista"
        Me.lblDeLlista.Size = New System.Drawing.Size(158, 13)
        Me.lblDeLlista.TabIndex = 7
        Me.lblDeLlista.Text = "Selecciona els fitxers de la llista:"
        '
        'frmWorkExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 404)
        Me.Controls.Add(Me.lblDeLlista)
        Me.Controls.Add(Me.lbFitxers)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.btnEscollirCarpeta)
        Me.Controls.Add(Me.lblContingutCela)
        Me.Controls.Add(Me.btnExplorarExcel)
        Me.Controls.Add(Me.btnExaminar)
        Me.Controls.Add(Me.tbRuta)
        Me.Name = "frmWorkExcel"
        Me.Text = "Explora Excel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbRuta As TextBox
    Friend WithEvents btnExaminar As Button
    Friend WithEvents btnExplorarExcel As Button
    Friend WithEvents lblContingutCela As Label
    Friend WithEvents btnEscollirCarpeta As Button
    Friend WithEvents lblPath As Label
    Friend WithEvents lbFitxers As ListBox
    Friend WithEvents lblDeLlista As Label
End Class
