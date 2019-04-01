Imports Microsoft.VisualBasic
Imports System.Collections.Generic

Public Class ImageGallery
    Public Class ImageGallery
        Public Property ThumbNailLink As String
        Public Property FullImageLink As String

        Public Shared ImageExtension() As String = New String() {".png", ".jpg", ".gif", ".jpeg"}

        Public Shared Function PullGallery(ByVal path As String) As List(Of ImageGallery)
            Dim dirInfo As New IO.DirectoryInfo(System.Web.HttpContext.Current.Server.MapPath(path))
            Dim gal As New List(Of ImageGallery)

            For Each f As IO.FileInfo In dirInfo.GetFiles()
                Dim extension As String = f.Extension.ToLower()
                If ImageExtension.Contains(extension) Then
                    Dim g As New ImageGallery
                    Dim thumbPath As String = System.Web.HttpContext.Current.Server.MapPath(path & "\thumb")

                    g.FullImageLink = path & "\" & f.Name

                    Dim thumbName As String = Trim(f.Name.Substring(0, f.Name.LastIndexOf(".")) & "_t" & f.Extension.ToLower())
                    Dim thumbFullPath As String = thumbPath & "\" & thumbName
                    'If IO.File.Exists(thumbFullPath) Then
                    g.ThumbNailLink = path & "\thumb\" & thumbName
                    'End If

                    gal.Add(g)
                End If
            Next

            Return gal
        End Function
    End Class
End Class
