
Partial Class Gallery
    Inherits System.Web.UI.Page

    Protected Sub Gallery_Init(sender As Object, e As EventArgs) Handles Me.Init
        'Dim lightboxScript As String = "$(function() {$('.Gallery1 a').lightBox();});"
        ScriptManager.GetCurrent(Me).Scripts.Add(New ScriptReference("~\Scripts\jquery.lightbox-0.5.min.js"))
        'ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "LightBox", lightboxScript, True)
    End Sub

    Protected Sub Gallery_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        LoadDateGrid()
    End Sub

    Private Sub LoadDateGrid()
        dlGallery1.DataSource = ImageGallery.ImageGallery.PullGallery("~\images\Gallery1")
        dlGallery1.DataBind()
    End Sub

End Class
