Imports System.Net.Mail
Imports System.IO

Partial Class _Default
    Inherits System.Web.UI.Page
    Dim instance As MailMessage

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        LoadSlideShowImages()
    End Sub

    Private Sub LoadSlideShowImages()
        Dim dInfo As New DirectoryInfo(Server.MapPath("~/Images/HomepageRotator"))

        For Each f As FileInfo In dInfo.GetFiles("*.jpg")
            Dim i As New Image
            i.ImageUrl = "~/Images/HomepageRotator/" & f.Name

            phSlideShow.Controls.Add(i)
        Next
    End Sub

    Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click

        Dim msg As New System.Net.Mail.MailMessage()
        Dim smtp As New System.Net.Mail.SmtpClient("relay-hosting.secureserver.net")    ' Add Your SMTP Client server url or ip
        Dim fromadx As New System.Net.Mail.MailAddress("mailer@rapidts.com", "Tampa Aquarium Service")   'From Email ID
        Dim toadx As System.Net.Mail.MailAddress
        Dim htmlContainer As String = String.Empty

        If Request.Url.ToString.Contains("localhost") Then
            toadx = New MailAddress("ryeako@rapidts.com")
        Else
            toadx = New MailAddress("tampaaquariumservice@verizon.net")
        End If

        msg.IsBodyHtml = True
        msg.From = fromadx
        msg.To.Add(toadx)
        msg.Subject = "Tampa Aquarium Service Landing Page Visitors: " + txtName.Text 'Subject line
        'Set the body
        htmlContainer = "<html>" & _
        "<body>" & _
        "<style type='text/css'>body{font:verdana, arial; font-size:12pt;}b{font-size:10pt;}</style>" & _
        "<b>Time Submited:</b> " + DateTime.Now & _
        "<br />" & vbCrLf & _
        "<b>Name:</b> " & txtName.Text & vbCrLf & _
        "<br />" & vbCrLf & _
        "<b>Email:</b> " & txtEmail.Text & vbCrLf & _
        "<br />" & vbCrLf & _
        "<b>Questions:</b> " & txtQuestions.Text & vbCrLf & _
        "<br />" & vbCrLf & _
        "</body></html>"

        msg.Body = htmlContainer

        Try
            smtp.Send(msg)
        Catch ex As Exception
            Me.lblSuccess.Text = "An error occured sending the message.  Please try again."
            Me.success.Attributes("class") = "error"
        Finally
            Me.success.Visible = True
        End Try
    End Sub

End Class
