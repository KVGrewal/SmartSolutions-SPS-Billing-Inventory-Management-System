using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSolutionsSPS
{
   public static class clsProcedures
    {
       //STORED PROCEDURE TO ADD A NEW PRODUCT
       //CALLING FUNCTIONS
       //FUNCTION : Add_Prod_Data, CLASS : clsProduct.cs
        public static string _AddProd = "addProduct";

       //STORED PROCEDURE TO ADD A NEW PURCHASE
       //CALLING FUNCTIONS
       //FUNCTION : addPurchase, CLASS : clsPurchases
        public static string addPurchase = "addPurchase";

       //STORED PROCEDURE TO ADD A NEW CUSTOMER
       //CALLING FUNCTIONS
       // FUNCTION : addCustomer, CLASS : clsAddCustomer
        public static string addCustomer = "addCustomer";

        //PROCEDURE TO REMOVE A PRODUCT FROM THE DB
        //CALLING FUNCTION
        //FUNCTION : removeProduct, CLASS : clsProduct
        public static string removeProdById = "removeProdById";

       //PROCEDURE TO GET PRODUCTS FROM DB
       //CALLING FUNCTIONS
       //FUNCTION : fillGrid, CLASS : INVENTORY_CLS
        public static string getProducts = "getProducts";

        //PROCEDURE TO UPDATE STOCK OF A PRODUCT
        //CALLING FUNCTIONS
        //FUNCTION : updateStock, CLASS : clsProduct
        public static string updateStock = "updateStock";

        //PROCEDURE TO GET DETAILS OF A PRODUCT
        //CALLING FUNCTIONS
        //FUNCTION : setProperties, CLASS : clsOrder
        public static string getProdDetails = "getProdDetails";

        //PROCEDURE TO SHOW ALL CUSTOMERS
        //CALLING FUNCTIONS
        //FUNCTION : showParties, CLASS : clsPARTIES
        public static string showParties = "showParties";

        //PROCEDURE TO SHOW ALL PURCHASES
        //CALLING FUNCTIONS
        //FUNCTION : fillGrid, CLASS : clsPurchases
        public static string getAllPurchases = "getAllPurchases";

        //PROCEDURE TO SHOW ALL SALES
        //CALLING FUNCTIONS
        //FUNCTION : fillData, CLASS : clsSales
        public static string showAllSales = "showAllSales";

        //PROCEDURE TO SHOW ALL SALES
        //CALLING FUNCTIONS
        //FUNCTION : fillData, CLASS : clsSales
        public static string showDetails = "showDetails";

        //PROCEDURE TO SHOW ALL SALES
        //CALLING FUNCTIONS
        //FUNCTION : addPayment, CLASS : clsSales
        public static string addPayment = "addPayment";

        //PROCEDURE TO SHOW ALL SALES
        //CALLING FUNCTIONS
        //FUNCTION : addPayment, CLASS : clsPurchases
        public static string addPaymentToPurchase = "addPaymentToPurchase";

        //PROCEDURE TO ADD A SALE
        //CALLING FUNCTIONS
        //FUNCTION : saveSale, CLASS : clsSales
        public static string saveSale = "saveSale";

        //PROCEDURE TO LOAD HSN AND THEIR RESPECTIVE GST SLABS
        //CALLING FUNCTIONS
        //FUNCTION : getHSN, CLASS : clsProduct
        public static string getHSN = "getHSN";

        //PROCEDURE TO UPDATE GST SLAB OF A SPECIFIC HSN NUMBER
        //CALLING FUNCTIONS
        //FUNCTION : getGstSlab, CLASS : clsProduct
        public static string updateGstSlab = "updateGstSlab";

        //PROCEDURE TO SHOW ALL SALES
        //CALLING FUNCTIONS
        //FUNCTION : showPurchaseDetails, CLASS : clsPurchases
        public static string showPurchaseDetails = "showPurchaseDetails";

       //PROCUDERE TO GET PAYMENT DETAILS OF A SPECIFIC TRANSACTION
       //CALLING FUNCTIONS
       //FUNCTION : showPayments, CLASS : clsSales
        public static string getPaymentDetails = "getPaymentDetails";

        //PROCUDERE TO GET PAYMENT DETAILS OF A SPECIFIC TRANSACTION
        //CALLING FUNCTIONS
        //FUNCTION : showPayments, CLASS : clsPurchases
        public static string getPurchasePaymentDetails = "getPurchasePaymentDetails";

       //TO GET THE AMOUNT TO BE COLLECTED
       //CALLING FUNCTIONS
       //FUNCTION : getToCollect, CLASS : clsStatistics
        public static string getToCollectAmt = "getToCollectAmt";

        //TO GET THE AMOUNT TO BE COLLECTED
        //CALLING FUNCTIONS
        //FUNCTION : getToPay, CLASS : clsStatistics
        public static string getToPayAmt = "getToPayAmt";

        //TO GET THE TAX TO BE PAID
        //CALLING FUNCTIONS
        //FUNCTION : getTax, CLASS : clsStatistics
        public static string getTax = "getTax";

       //TO GET CREDENTIALS OF A USER
       //CALLING FUNCTIONS
       //FUNCTION : getCredential, FORM - login
        public static string getCredentials = "getCredentials";

        public static string generateBill = "generateBill";


        public static string addSale = "addSale";
        public static string selectById = "selectById";
       
        
        

       //THIS STORED PROCEDURE IS USED IN BUTTON CLICK EVENT OF "REMOVE" BUTTON PRESENT IN VIEW PARTIES FORM TO REMOVE A CUSTOMER FROM THE DATABASE
        public static string removeCustomer = "removeCustomer";

       //THIS STORED PROCEDURE IS USED IN BUTTON CLICK EVENT OF EDIT CUSTOMER TO FILL THE DATA OF THE CUSTOMER IN THE PANEL
        public static string pullCust = "pullCust";

       //THIS STORED PROCEDURE IS USED IN BUTTON CLICK EVENT OF UPDATE CUSTOMER BUTTON PRESENT ON PANEL IN VIEW PARTIES FORM TO UPDATE THE INFO OF
       //A CUSTOMER
        public static string updateCustomer = "updateCustomer";

       //description of procedure        

       

           
 
       

       //PROCUDERE TO GET ID OF A CUSTOMER
        public static string getId = "getId";       

       //PROCUDURE TO DISPLAY PRODUCTS
        public static string showProducts = "showProducts";

       //SELECT BRAND AND ID FROM THE PRODUCTS
        public static string showBrand = "showBrand";             
        
        
    }
}
