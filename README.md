# PictureResize
C# and VB.NET function to resize picture with new dimentions and decreased storage size

Example of Use:
# VB.NET

Dim filePath As String = "C:\Users\Sanket\Pictures\largeimagetest.jpg"
Dim newfilePath As String = "C:\Users\Sanket\Pictures\largeimagetest2.jpg"
Using img As New System.Drawing.Bitmap(filePath)
      ResizeImageAndSave(img, Convert.ToInt32(600), Convert.ToInt32(420), newfilePath)
End Using


# C# 

string filePath = "C:\Users\Sanket\Pictures\largeimagetest.jpg"
string newfilePath  = "C:\Users\Sanket\Pictures\largeimagetest2.jpg"
using (System.Drawing.Bitmap img = new System.Drawing.Bitmap(filePath))
{
    ResizeImageAndSave(img, Convert.ToInt32(1400), Convert.ToInt32(1400), newfilePath);
}

ResizeImageAndSave function takes
1. Bitmap of existing image
2. Desire Width size of newimage
3. Desire height of new image
4. New File path to be store.
