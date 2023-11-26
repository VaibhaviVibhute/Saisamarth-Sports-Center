<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product_master.aspx.cs" Inherits="saisamarthsportscenter.Product_master" %>

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
           .style3
           {
               width: 183px;
           }
           .style4
           {
               width: 100%;
           }
           </style>
   </head>
<script type="text/javascript" language="javascript">
function formValidator()
{
	// Make quick references to our fields
	var name = document.getElementById("txt_prod_nm");
	var rate = document.getElementById("txt_rate");
	var size = document.getElementById("txt_size");
	var stock=document.getElementById("txt_stock");
	
	if(notEmpty(name,"Name Must be given") && isAlphabet(name, "Please enter only letters for your name"))
                {
    if(notEmpty(rate,"Rate Must be given") && isNumeric(rate, "Please enter a rate of a product"))
                {     
    if(notEmpty(size,"Size Must be given") )
                {
    if(notEmpty(stock,"Stock Must be given") && isNumeric(stock, "Please enter stock of a product"))
                {

                
    

                                     return true;
                }
                }
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

function isAlphabet(elem, helperMsg)
{
	var alphaExp = /^[a-zA-Z ]+$/;
	if(elem.value.match(alphaExp))
	{
		return true;
	}
	else
	{
		alert(helperMsg);
		elem.value="";
		elem.focus();
		return false;
	}
	
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
                    <a href="Dashboard.aspx">Dashboard</a>
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
                     <h2>Product Master</h2>
                  </div>
               </div>
            </div>
          </div>
</div>




      <!-- map -->
      
    <form id="form1" runat="server" class="main_form">
    <div class="container">
    <div class="row">
    
        <table class="table">
            <tr>
                <td class="style3">
                    <asp:Label ID="Label1" runat="server" Text="Product ID"></asp:Label>

                    <asp:TextBox ID="txt_prod_id" class="form-control" runat="server" 
                        Enabled="False" Width="375px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label2" runat="server" Text="Product Name"></asp:Label>

                    <asp:TextBox ID="txt_prod_nm"    class="form-control"    runat="server" 
                        Enabled="False" Width="375px" 
                        ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label3" runat="server" Text="Category ID"></asp:Label>

                    <asp:DropDownList ID="DropDownList1" class="form-control" runat="server" 
                        Enabled="False" Width="375px" Height="55px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label4" runat="server" Text="Rate"></asp:Label>

                    <asp:TextBox ID="txt_rate" class="form-control" runat="server" Enabled="False" 
                        Width="375px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label>
                    
                    <asp:DropDownList ID="DropDownList2" class="form-control" runat="server" 
                        Enabled="False" Width="375px" Height="55px">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label6" runat="server" Text="Size"></asp:Label>

                    <asp:TextBox ID="txt_size" class="form-control" runat="server" Enabled="False" 
                        Width="375px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label7" runat="server" Text="Stock"></asp:Label>

                    <asp:TextBox ID="txt_stock" class="form-control" runat="server" Enabled="False" 
                        Width="375px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label8" runat="server" Text="Photo"></asp:Label>

                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Upload" />
                    <asp:Image ID="Image1" runat="server" Height="200px" Width="200px" />
                </td>
            </tr>
            
            <tr>
                <td>
                    <table class="style4">
                        <tr>
                            <td >
                                <asp:Button ID="btn_new" class="send"  runat="server" Text="New" 
                                    onclick="btn_new_Click1" Height="66px" Width="66px"/>
                            </td>
                            <td>
                                <asp:Button ID="btn_save" OnClientClick="return formValidator()" class="send" 
                                runat="server" onclick="btn_save_Click" Text="Save" Enabled="False" Height="66px" Width="66px"/>
                            </td>
                            <td>
                                <asp:Button ID="btn_update" class="send" runat="server" Enabled="False" Text="Update" 
                                onclick="btn_update_Click" EnableTheming="True" Height="66px" Width="66px"/>
                            </td>
                            <td>
                                <asp:Button ID="btn_delete" class="send" runat="server" Enabled="False" Text="Delete" 
                                onclick="btn_delete_Click" Height="66px" Width="66px"/>
                            </td>
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
        <td class="style3">
                    <asp:GridView ID="GridView1" class="table" runat="server" 
                        onselectedindexchanged="GridView1_SelectedIndexChanged" 
                        AutoGenerateSelectButton="True">
                    </asp:GridView>
                    </td>
    </div>
    </div>
    </form>
        

<div class="contact">
         <div class="container></div>
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
