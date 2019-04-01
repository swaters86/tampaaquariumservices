<%@ Page Language="VB" MasterPageFile="~/Masters/Homepage.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" title="Tampa Aquarium Service" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <div class="leftContent">
        <center>
            <h1>Tampa Aquarium Service</h1>
            <h2>Complete custom aquarium system design and installation.</h2>
            <div class="slideshowwrapper">
                <div class="slideshow">
                    <asp:PlaceHolder ID="phSlideShow" runat="server" />
                </div>
            </div>

            <h3>Please contact us for a quote on a new system or an upgrade to an existing system. </h3>
            <span class="label20">We are well equipped to handle all jobs, as well as emergency work.</span>
            <p>
                Everyone deserves their own piece of the ocean!
            </p>  
        </center>      
    </div>

    <div class="rightContent">     
        <h3>Contact Us</h3>             
        <span class="inputlabel">Name:</span><br />
        <asp:TextBox ID="txtName" CssClass="text" runat="server"></asp:TextBox><br />

        <span class="inputlabel">Email:<sup class="required">*</sup></span><br />
        <asp:TextBox ID="txtEmail" CssClass="text" runat="server"></asp:TextBox><br />
        
        <span class="inputlabel">Questions:</span><br />
        <asp:TextBox ID="txtQuestions" CssClass="text" TextMode="MultiLine" runat="server" Rows="10"></asp:TextBox><br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" CssClass="buttonright" Text="SUBMIT" />
    </div>

    <div class="clearall">
        <div id="success" runat="server" class="success" visible="false">
            <asp:Label ID="lblSuccess" runat="server" Text="Thank you, we will Email you when the website is launched!"></asp:Label>
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error" />  
    
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                        CssClass="error" 
                                        ErrorMessage="Please make sure this is a valid email address. "   
                                        ControlToValidate="txtEmail" 
                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                        Display="None" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ErrorMessage="An Email address is  required to submit the form" 
                                    CssClass="error"  
                                    ControlToValidate="txtEmail" 
                                    Display="None" />
    </div>

    <script type="text/javascript">
        $('.slideshow').cycle({
            fx: 'scrollRight',
            speed: 300
        });
    </script>
</asp:Content>

