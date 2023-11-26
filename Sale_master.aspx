<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sale_master.aspx.cs" Inherits="saisamarthsportscenter.Sale_master" %>

<!DOCTYPE html>
<html lang="en">
   <head>
      <!-- basic -->
      <meta charset="utf-8">
      <meta http-equiv="X-UA-Compatible" content="IE=edge">
      <!-- mobile metas -->
      <meta name="viewport" content="width=device-width, initial-scale=1">
      <meta name="viewport" content="initial-scale=1, maximum-scale=1">
      <!-- site metas -->
      <title>niture</title>
      <meta name="keywords" content="">
      <meta name="description" content="">
      <meta name="author" content="">
      <!-- bootstrap css -->
      <link rel="stylesheet" href="niture/css/bootstrap.min.css">
      <!-- style css -->
      <link rel="stylesheet" href="niture/css/style.css">
      <!-- Responsive-->
      <link rel="stylesheet" href="niture/css/responsive.css">
      <!-- fevicon -->
      <link rel="icon" href="niture/images/fevicon.png" type="image/gif" />
      <!-- Scrollbar Custom CSS -->
      <link rel="stylesheet" href="niture/css/jquery.mCustomScrollbar.min.css">
      <!-- Tweaks for older IEs-->
      <link rel="stylesheet" href="https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css">
      <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.css" media="screen">
      <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script><![endif]-->
       <style type="text/css">
           .style1
           {
               width: 314px;
           }
           .style2
           {
               width: 100%;
           }
       </style>
   </head>
<script type="text/javascript" language="javascript">
function formValidator()
{
	// Make quick references to our fields
	var gst = document.getElementById("txt_gst");
	var grandtotal = document.getElementById("txt_grandtotal");
	


	
	if(notEmpty(gst,"Gst Must be given") && isNumeric(gst, "Please enter only digits for gst"))
    {
    if(notEmpty(grandtotal,"Grandtotal Must be given") && isNumeric(grandtotal, "Please enter only digits for grandtotal"))
    {



                    return true;
                }
                }
                    return false;
}

function notEmpty(elem, helperMsg)
 {

	    if(elem.value.length == 0)
	    {
		    alert(helperMsg);
		    elem.focus(); // set the focus to this input
		    return false;
	    }
	        return true;
 }

function isNumeric(elem, helperMsg)
{
	var numericExpression = /^[0-9]+$/;
	if(elem.value.match(numericExpression))
	{
		return true;
	}
	else
	{
		elem.value="";
		alert(helperMsg);
		elem.focus();
		return false;
	}
}



	

</script>
<body>
<!-- loader  -->
      <div class="loader_bg">
         <div class="loader"><img src="niture/images/loading.gif" alt="#" />
         </div>
      </div>

     <div class="wrapper">

      <!-- end loader --> 
      <div class="sidebar">
         <!-- Sidebar  -->
        <nav id="sidebar">

            <div id="dismiss">
                <i class="fa fa-arrow-left"></i>
            </div>

            <ul class="list-unstyled components">
                
                <li>
                    <a href="index.html">Home</a>
                </li>
                <li>
                    <a href="about.html">Admin Login</a>
                </li>
                <li>
                    <a href="product.html">Customer Login</a>
                </li>
               
            </ul>

        </nav>
      </div>
     
     <div id="content">
      <!-- header -->
      <header>
         <!-- header inner -->
         <div class="header">
           
         <div class="container-fluid">
             
            <div class="row">
               <div class="col-lg-3 logo_section">
                  <div class="full">
                     <div class="center-desk">
                        <div class="logo"> <a href="index.html">
                        <h1>Sai Samarth Sport's Center</h1></a> </div>
                     </div>
                  </div>
               </div>
               <div class="col-lg-9">
                  <div class="right_header_info">
                     <ul>
                       
                         <li>
                           <button type="button" id="sidebarCollapse">
                              <img src="niture/images/menu_icon.png" alt="#" />
                           </button>
                        </li>
                     </ul>
                  </div>
               </div>
            </div>
         </div>
            </div>
        
         <!-- end header inner --> 
      </header>
      <!-- end header -->
<div class="contactus">
   <div class="container">
            <div class="row">
               <div class="col-md-8 offset-md-2">
                  <div class="title">
                     <h2>Sale Master</h2>
                    
                  </div>
               </div>
            </div>
          </div>
</div>
   
   
    <form id="form1" runat="server" class="main_form">
    <div class="container">
    <div class="row">
    
    <table class="table">
        <tr>
            <td class="style1">
                <asp:Label ID="Label1" runat="server" Text="Sale ID"></asp:Label>

                <asp:TextBox ID="txt_sale_id" class="form-control" runat="server" 
                    Enabled="False" Width="260px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label2" runat="server" Text="Sale Date"></asp:Label>

                <asp:TextBox ID="txt_sale_date" class="form-control" runat="server" 
                    Enabled="False" Width="260px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label3" runat="server" Text="Customer ID"></asp:Label>
                
                <asp:DropDownList ID="DropDownList1" class="form-control" runat="server" 
                    Enabled="False" Width="260px" Height="55px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label4" runat="server" Text="GST"></asp:Label>
               
                <asp:TextBox ID="txt_gst" class="form-control" runat="server" Enabled="False" 
                    Width="260px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label5" runat="server" Text="GrandTotal"></asp:Label>

                <asp:TextBox ID="txt_grandtotal" class="form-control" runat="server" 
                    Enabled="False" Width="260px"></asp:TextBox>
            </td>
        </tr>
 
        <tr>
            <td class="style1">
                <table class="style2">
                    <tr>
                        <td>
                <asp:Button ID="btn_new" class="send" runat="server" Text="New" 
                    onclick="btn_new_Click" Height="66px" Width="66px"/>
                        </td>
                        <td>
                <asp:Button ID="btn_save" OnClientClick="return formValidator()" class="send" 
                    runat="server" Text="Save" Enabled="False" 
                    onclick="btn_save_Click" Height="66px" Width="66px"/> 
                        </td>
                        <td>
                <asp:Button ID="btn_update" class="send" runat="server" Text="Update" Enabled="False" 
                    onclick="btn_update_Click" Height="66px" Width="66px" /> 
                        </td>
                        <td>
                <asp:Button ID="btn_delete" class="send" runat="server" Text="Delete" Enabled="False" 
                    onclick="btn_delete_Click" Height="66px" Width="66px"/>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </td>

            <td>    
                &nbsp;</td>
                    
            <td>
                &nbsp;</td>

            <td>
                &nbsp;</td>
        </tr>

        
        </table>
        <tr>
            <td class="style1">
                <asp:GridView ID="GridView1" class="table" runat="server" AutoGenerateSelectButton="True" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
        </tr>
    
    </div>
    
    </div>
    </form>
    
    <div class="contact">
         <div class="container
         <div class="overlay"></div>

      <!-- Javascript files--> 
      <script src="niture/js/jquery.min.js"></script> 
      <script src="niture/js/popper.min.js"></script> 
      <script src="niture/js/bootstrap.bundle.min.js"></script> 
      <script src="niture/js/jquery-3.0.0.min.js"></script> 
      <script src="niture/js/plugin.js"></script> 
      <!-- sidebar --> 
      <script src="niture/js/jquery.mCustomScrollbar.concat.min.js"></script> 
      <script src="niture/js/custom.js"></script>
      <script src="https:cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.js"></script>
     <script type="text/javascript">
         $(document).ready(function () {
             $("#sidebar").mCustomScrollbar({
                 theme: "minimal"
             });

             $('#dismiss, .overlay').on('click', function () {
                 $('#sidebar').removeClass('active');
                 $('.overlay').removeClass('active');
             });

             $('#sidebarCollapse').on('click', function () {
                 $('#sidebar').addClass('active');
                 $('.overlay').addClass('active');
                 $('.collapse.in').toggleClass('in');
                 $('a[aria-expanded=true]').attr('aria-expanded', 'false');
             });
         });
      </script>
      
      <script>
          $(document).ready(function () {
              $(".fancybox").fancybox({
                  openEffect: "none",
                  closeEffect: "none"
              });

              $(".zoom").hover(function () {

                  $(this).addClass('transition');
              }, function () {

                  $(this).removeClass('transition');
              });
          });
         
      </script> 
</body>
</html>
