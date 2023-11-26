<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="saisamarthsportscenter.Link1" %>

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
       </head>
   
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
                     <h2>Admin Dashboard</h2>
                    
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
            <td>
                Manage</td>
            <td>
                List</td>
            <td>
                Dynamic</td>
            <td>
                Datewise</td>
        </tr>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLink3" runat="server" 
                    NavigateUrl="~/Product_Category.aspx">Product_Category</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink9" runat="server" 
                    NavigateUrl="~/Report/frm_ProductCategory.aspx">Product_Category</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink15" runat="server" 
                    NavigateUrl="~/Report/frm_Categorywiseproductmaster.aspx">Categorywise_Sale_master</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink20" runat="server" 
                    NavigateUrl="~/Report/frm_DateWise_SaleMaster.aspx">Datewise_Sale_master</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLink4" runat="server" 
                    NavigateUrl="~/Product_master.aspx">Product_master</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink10" runat="server" 
                    NavigateUrl="~/Report/frm_Product_Master.aspx">Product_master</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink16" runat="server" 
                    NavigateUrl="~/Report/frm_CustomerwiseSaleMaster.aspx">Customerwise_Sale_master</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink21" runat="server" 
                    NavigateUrl="~/Report/frm_DateWise_Payment.aspx">Datewise_Payment</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink11" runat="server" 
                    NavigateUrl="~/Report/frm_Customer.aspx">Customer</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink17" runat="server" 
                    NavigateUrl="~/Report/frm_ProductwiseSaleDetails.aspx">Productwise_Sale_details</asp:HyperLink>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink12" runat="server" 
                    NavigateUrl="~/Report/frm_Sale_Master.aspx">Sale_master</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink18" runat="server" 
                    NavigateUrl="~/Report/frm_SalewiseSaleDetails.aspx">Salewise_Sale_details</asp:HyperLink>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink13" runat="server" 
                    NavigateUrl="~/Report/frm_Sale_details.aspx">Sale_details</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink19" runat="server" 
                    NavigateUrl="~/Report/frm_Salewisepayment.aspx">Salewise_payment</asp:HyperLink>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink14" runat="server" 
                    NavigateUrl="~/Report/frm_Payment.aspx">Payment</asp:HyperLink>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        
    </table>
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
     </div>
      
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
