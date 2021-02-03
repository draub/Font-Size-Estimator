<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFontCalc
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
        Me.lblFont = New System.Windows.Forms.Label()
        Me.lblFontSize = New System.Windows.Forms.Label()
        Me.lblStringWidth = New System.Windows.Forms.Label()
        Me.rtfSampleText = New System.Windows.Forms.RichTextBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.btnFontPick = New System.Windows.Forms.Button()
        Me.lblZplDot = New System.Windows.Forms.Label()
        Me.lblMms = New System.Windows.Forms.Label()
        Me.lblMeasurements = New System.Windows.Forms.Label()
        Me.lblInches = New System.Windows.Forms.Label()
        Me.lblVisualization = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFont
        '
        Me.lblFont.AutoSize = True
        Me.lblFont.Location = New System.Drawing.Point(67, 10)
        Me.lblFont.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(0, 16)
        Me.lblFont.TabIndex = 0
        '
        'lblFontSize
        '
        Me.lblFontSize.AutoSize = True
        Me.lblFontSize.Location = New System.Drawing.Point(67, 31)
        Me.lblFontSize.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFontSize.Name = "lblFontSize"
        Me.lblFontSize.Size = New System.Drawing.Size(0, 16)
        Me.lblFontSize.TabIndex = 4
        '
        'lblStringWidth
        '
        Me.lblStringWidth.AutoSize = True
        Me.lblStringWidth.Location = New System.Drawing.Point(15, 191)
        Me.lblStringWidth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStringWidth.Name = "lblStringWidth"
        Me.lblStringWidth.Size = New System.Drawing.Size(57, 16)
        Me.lblStringWidth.TabIndex = 5
        Me.lblStringWidth.Text = "Pixels = "
        '
        'rtfSampleText
        '
        Me.rtfSampleText.Location = New System.Drawing.Point(15, 60)
        Me.rtfSampleText.Margin = New System.Windows.Forms.Padding(4)
        Me.rtfSampleText.Name = "rtfSampleText"
        Me.rtfSampleText.Size = New System.Drawing.Size(511, 100)
        Me.rtfSampleText.TabIndex = 7
        Me.rtfSampleText.Text = ""
        '
        'FontDialog1
        '
        Me.FontDialog1.FontMustExist = True
        Me.FontDialog1.ShowEffects = False
        '
        'btnFontPick
        '
        Me.btnFontPick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFontPick.Location = New System.Drawing.Point(16, 10)
        Me.btnFontPick.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFontPick.Name = "btnFontPick"
        Me.btnFontPick.Size = New System.Drawing.Size(43, 39)
        Me.btnFontPick.TabIndex = 2
        Me.btnFontPick.Text = "Aa"
        Me.btnFontPick.UseVisualStyleBackColor = True
        '
        'lblZplDot
        '
        Me.lblZplDot.AutoSize = True
        Me.lblZplDot.Location = New System.Drawing.Point(16, 213)
        Me.lblZplDot.Name = "lblZplDot"
        Me.lblZplDot.Size = New System.Drawing.Size(68, 16)
        Me.lblZplDot.TabIndex = 8
        Me.lblZplDot.Text = "ZplDots = "
        '
        'lblMms
        '
        Me.lblMms.AutoSize = True
        Me.lblMms.Location = New System.Drawing.Point(268, 190)
        Me.lblMms.Name = "lblMms"
        Me.lblMms.Size = New System.Drawing.Size(47, 16)
        Me.lblMms.TabIndex = 8
        Me.lblMms.Text = "MMs ="
        '
        'lblMeasurements
        '
        Me.lblMeasurements.AutoSize = True
        Me.lblMeasurements.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeasurements.Location = New System.Drawing.Point(16, 170)
        Me.lblMeasurements.Name = "lblMeasurements"
        Me.lblMeasurements.Size = New System.Drawing.Size(153, 16)
        Me.lblMeasurements.TabIndex = 8
        Me.lblMeasurements.Text = "String Measurements"
        '
        'lblInches
        '
        Me.lblInches.AutoSize = True
        Me.lblInches.Location = New System.Drawing.Point(268, 213)
        Me.lblInches.Name = "lblInches"
        Me.lblInches.Size = New System.Drawing.Size(57, 16)
        Me.lblInches.TabIndex = 8
        Me.lblInches.Text = "Inches ="
        '
        'lblVisualization
        '
        Me.lblVisualization.AutoSize = True
        Me.lblVisualization.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisualization.Location = New System.Drawing.Point(19, 256)
        Me.lblVisualization.Name = "lblVisualization"
        Me.lblVisualization.Size = New System.Drawing.Size(100, 16)
        Me.lblVisualization.TabIndex = 9
        Me.lblVisualization.Text = "Visualization:"
        '
        'frmFontCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 384)
        Me.Controls.Add(Me.lblVisualization)
        Me.Controls.Add(Me.lblMeasurements)
        Me.Controls.Add(Me.lblInches)
        Me.Controls.Add(Me.lblMms)
        Me.Controls.Add(Me.lblZplDot)
        Me.Controls.Add(Me.rtfSampleText)
        Me.Controls.Add(Me.lblStringWidth)
        Me.Controls.Add(Me.lblFontSize)
        Me.Controls.Add(Me.btnFontPick)
        Me.Controls.Add(Me.lblFont)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmFontCalc"
        Me.Text = "Font Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFont As Label
    Friend WithEvents btnFontPick As Button
    Friend WithEvents lblFontSize As Label
    Friend WithEvents lblStringWidth As Label
    Friend WithEvents rtfSampleText As RichTextBox
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents lblZplDot As Label
    Friend WithEvents lblMms As Label
    Friend WithEvents lblMeasurements As Label
    Friend WithEvents lblInches As Label
    Friend WithEvents lblVisualization As Label
End Class
