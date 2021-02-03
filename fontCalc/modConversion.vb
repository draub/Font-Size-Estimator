Module modConversion

    'Screen DPI
    Public screenDpi As Int32 = frmFontCalc.DeviceDpi


    ' ---------------------------------------------------------
    ' Currently used functions:
    ' ---------------------------------------------------------

    'Screen DPI to ZPLDots
    Public Function CalcDpiToDot(ByVal pixelcount As Double) As Int32
        Return Convert.ToInt32((pixelcount / screenDpi) * 203)
    End Function

    'Screen DPI to MM
    Public Function CalcDpiToMm(ByVal pixelcount As Double) As Double
        'Dpi = (current screen DPI) per inch
        '1 inch = 25.4 MMs
        Return Math.Round((pixelcount / screenDpi) * 25.4, 2)
    End Function


    Public Function CalcDpiToInches(ByVal pixelcount As Double) As Double
        'Dpi = (current screen DPI) per inch
        Return Math.Round((pixelcount / screenDpi), 3)
    End Function

    'Dots to Inches
    Public Function CalcDotToInch(ByVal zplDots As Int32) As Double
        '203 Dots = 1 Inch
        Return Math.Round((Convert.ToSingle(zplDots) / 203), 2)
    End Function


    ' ---------------------------------------------------------
    ' Future use conversion functions:
    ' ---------------------------------------------------------

    'ZPLDots to Screen DPI
    Public Function CalcDotToDpi(ByVal zplDots As Int32) As Double
        ' Dots = 203 / inch
        ' Dpi = (current screen DPI) / inch

        Return Math.Round((CalcDotToInch(zplDots) * screenDpi), 3)
    End Function

    'ZPLDots to MM
    Public Function CalcDotToMm(ByVal zplDots As Int32) As Double
        '8 Dots = 1 MM.
        Return Math.Round((Convert.ToSingle(zplDots) / 8), 2)
    End Function

    'MM to ZPLDots
    Public Function CalcMmToDot(ByVal mm As Double) As Int32
        '8 Dots = 1 MM.
        Return Convert.ToInt32(mm * 8)
    End Function

    'Inches to Dots
    Public Function CalcInchToDot(ByVal inches As Double) As Int32
        '203 Dots = 1 Inch
        Return Convert.ToInt32(inches * 203)
    End Function


End Module
