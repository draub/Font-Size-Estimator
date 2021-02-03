Imports System.Drawing.Text
Imports System.Drawing
Public Class frmFontCalc

    Private fontSelectedName As String = Me.Font.Name
    Private fontSelectedSize As Single = Me.Font.SizeInPoints
    Private fontSelectedStyle As FontStyle = Me.Font.Style

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtfSampleText.Text = "Enter Text To Measure"

        lblStringWidth.Visible = False
        lblZplDot.Visible = False
        lblMms.Visible = False
        lblInches.Visible = False

        'Populate labels
        lblFont.Text = fontSelectedName
        lblFontSize.Text = fontSelectedSize.ToString() + " Pt (" + fontSelectedStyle.ToString() + ")"

        Me.Refresh()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFontPick.Click
        If FontDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then

            'Update variables to reflect new font values
            fontSelectedName = FontDialog1.Font.Name
            fontSelectedSize = FontDialog1.Font.SizeInPoints
            fontSelectedStyle = FontDialog1.Font.Style

            'Update labels 
            lblFont.Text = fontSelectedName
            lblFontSize.Text = fontSelectedSize.ToString() + " Pt (" + fontSelectedStyle.ToString() + ")"

            'Apply font to Font Selector button text
            btnFontPick.Font = Font

            'Apply font to RTF Textbox
            rtfSampleText.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub rtfSampleText_TextChanged(sender As Object, e As EventArgs) Handles rtfSampleText.TextChanged
        'Update information in real time (as text is updated)
        Me.Refresh()
    End Sub

    Private Sub frmFontCalc_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim draw As Graphics = Me.CreateGraphics
        Dim textToDraw As String = rtfSampleText.Text
        Dim textDrawFont As New Font(FontDialog1.Font.Name, FontDialog1.Font.SizeInPoints, FontDialog1.Font.Style)
        Dim textDrawSize As New SizeF

        Dim textDrawBrush As New SolidBrush(Color.Blue)
        Dim textDrawBrush2 As New SolidBrush(Color.Yellow)

        Dim textDrawPosX As Single = 20.0F
        Dim textDrawPosY As Single = 280.0F

        Dim textDrawRectangleSize As New SizeF


        Dim textDrawFormat As New StringFormat

        If rtfSampleText.Text.Length > 0 Then
            draw.Clear(Me.BackColor)

            textDrawSize = draw.MeasureString(textToDraw, textDrawFont, rtfSampleText.Width)

            draw.DrawRectangle(New Pen(Color.Red, 1), textDrawPosX, textDrawPosY, textDrawSize.Width, textDrawSize.Height)
            draw.DrawString(textToDraw, textDrawFont, textDrawBrush, textDrawPosX, textDrawPosY, textDrawFormat)
            draw.DrawString(textToDraw, textDrawFont, textDrawBrush2, 15, 60, textDrawFormat)

            'Show Measurements
            lblStringWidth.Visible = True
            lblZplDot.Visible = True
            lblMms.Visible = True
            lblInches.Visible = True
            lblStringWidth.Text = "[Pixels] W: " + Math.Round(textDrawSize.Width).ToString() + "   H: " + Math.Round(textDrawSize.Height).ToString()
            lblZplDot.Text = "[ZPL Dots] W: " + CalcDpiToDot(textDrawSize.Width).ToString() + "   H: " + CalcDpiToDot(textDrawSize.Height).ToString()
            lblMms.Text = "[MMs] W: " + CalcDpiToMm(textDrawSize.Width).ToString() + "   H: " + CalcDpiToMm(textDrawSize.Height).ToString()
            lblInches.Text = "[Inches] W: " + CalcDpiToInches(textDrawSize.Width).ToString() + "   H: " + CalcDpiToInches(textDrawSize.Height).ToString()
        Else
            draw.Clear(Me.BackColor)

            'Hide Measurements
            lblStringWidth.Visible = False
            lblZplDot.Visible = False
            lblMms.Visible = False
            lblInches.Visible = False
        End If
    End Sub


End Class
