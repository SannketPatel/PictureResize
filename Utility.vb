Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Public Class Utility
    Public Shared Sub ResizeImageAndSave(image As Bitmap, maxWidth As Integer, maxHeight As Integer, quality As Integer, filePath As String)
        ' Get the image's original width and height
        Dim originalWidth As Integer = image.Width
        Dim originalHeight As Integer = image.Height

        ' To preserve the aspect ratio
        Dim ratioX As Single = CSng(maxWidth) / CSng(originalWidth)
        Dim ratioY As Single = CSng(maxHeight) / CSng(originalHeight)
        Dim ratio As Single = Math.Min(ratioX, ratioY)

        ' New width and height based on aspect ratio
        Dim newWidth As Integer = CInt(originalWidth * ratio)
        Dim newHeight As Integer = CInt(originalHeight * ratio)

        ' Convert other formats (including CMYK) to RGB.
        Dim newImage As New Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb)

        ' Draws the image in the specified size with quality mode set to HighQuality
        Using graphics__1 As Graphics = Graphics.FromImage(newImage)
            graphics__1.CompositingQuality = CompositingQuality.HighQuality
            graphics__1.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphics__1.SmoothingMode = SmoothingMode.HighQuality
            graphics__1.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        image.Dispose()
        newImage.Save(filePath, ImageFormat.Jpeg)
    End Sub
End Class
