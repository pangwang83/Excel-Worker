﻿Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports System
Imports System.IO
Imports System.Collections

Public Class frmWorkExcel

    Private Const RANG As String = "A8:F18"
    Private fitxersObjectiu As List(Of String)

    Private Sub frmWorkExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnExplorarExcel.Enabled = False
        fitxersObjectiu = New List(Of String)
        lbFitxers.Items.Clear()
        lbFitxers.SelectionMode = SelectionMode.MultiExtended
        lbFitxers.Refresh()

    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Title = "Selecciona un fitxer"
        openFileDialog1.Filter = "Documents de Excel (*.xls, *.xlsb, *.xlsm, *xlsx)|*.xls;*.xlsb;*.xlsm;*.xlsx |All Files (*.*)|*.*"
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            tbRuta.Text = openFileDialog1.FileName.ToString()
            btnExplorarExcel.Enabled = True
        End If
    End Sub

    Private Sub btnExplorarExcel_Click(sender As Object, e As EventArgs) Handles btnExplorarExcel.Click
        'mostrarValorCeles(RANG)
        getSelectedItems()
        For Each fitxer In fitxersObjectiu
            lblContingutCela.Text += fitxer
        Next
    End Sub


    Private Sub mostrarValorCeles(Rang As String)
        Dim xlApp As Excel.Application = Nothing
        Dim xlWorkBooks As Excel.Workbooks = Nothing
        Dim xlWorkBook As Excel.Workbook = Nothing
        Dim xlWorkSheet As Excel.Worksheet = Nothing
        Dim xlWorkSheets As Excel.Sheets = Nothing
        Dim xlCells As Excel.Range = Nothing
        xlApp = New Excel.Application
        xlApp.DisplayAlerts = False
        xlWorkBooks = xlApp.Workbooks
        xlWorkBook = xlWorkBooks.Open(tbRuta.Text)
        xlApp.Visible = False
        xlWorkSheets = xlWorkBook.Sheets

        For Each c In xlWorkSheets(1).Range(Rang)
            lblContingutCela.Text = c.Value
        Next c

        xlWorkBook.Close()
        xlApp.UserControl = True
        xlApp.Quit()

        xlApp = Nothing
        xlWorkBook = Nothing
        xlWorkBooks = Nothing
        xlWorkSheet = Nothing
        xlWorkSheets = Nothing
    End Sub

    Private Sub btnEscollirCarpeta_Click(sender As Object, e As EventArgs) Handles btnEscollirCarpeta.Click
        Dim folderBrowserDialog As New FolderBrowserDialog()
        Dim path As String = ""
        Dim formats As New List(Of String)
        Dim llistaFitxers As New List(Of String)
        formats.Add("*.xls")
        formats.Add("*.xlsb")
        formats.Add("*.xlsm")
        formats.Add("*.xlsx")


        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            btnExplorarExcel.Enabled = True
            lbFitxers.Items.Clear()
            lbFitxers.Refresh()
            path = folderBrowserDialog.SelectedPath
            llistaFitxers = getXls(path, formats)
            tbRuta.Text = path
            For Each fitxer As String In llistaFitxers
                lbFitxers.Items.Add(fitxer)
            Next
        End If
    End Sub


    Private Function getXls(ruta As String, patterns As List(Of String)) As List(Of String)
        Dim fitxers As New List(Of String)
        Dim fileEntries As String() = Directory.GetFiles(ruta)
        For Each pattern As String In patterns
            fitxers.AddRange(Directory.GetFiles(ruta, pattern))
        Next
        Return fitxers
    End Function

    Private Sub getSelectedItems()
        For i = 0 To lbFitxers.Items.Count - 1
            If lbFitxers.GetSelected(i) = True Then
                fitxersObjectiu.Add(lbFitxers.Items(i))
            End If
        Next i
    End Sub

    Private Sub mostrarFitxersExcel(ruta As String, patterns As List(Of String))
        Dim fitxers As New List(Of String)
        Dim fileEntries As String() = Directory.GetFiles(ruta)
        For Each pattern As String In patterns
            fitxers.AddRange(Directory.GetFiles(ruta, pattern))
        Next
    End Sub


End Class

'https://social.msdn.microsoft.com/Forums/en-US/2600a145-4bcb-436d-8e88-232b8f58d14b/edit-a-cell-in-spreadsheet-using-c?forum=csharpgeneral
'https://www.e-iceblue.com/Tutorials/Spire.XLS/Spire.XLS-Program-Guide/NET-Edit-Excel-Edit-Excel-Data-in-C-and-VB.NET.html
'https://social.msdn.microsoft.com/Forums/vstudio/en-US/48201825-ab5c-4759-b593-56889d13ff4b/vb-2012-reading-excel-worksheet-cell-values?forum=vbgeneral