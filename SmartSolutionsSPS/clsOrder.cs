using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SmartSolutionsSPS
{
    class clsOrder
    {
        
            public string Name { get; set; }
            public string Brand { get; set; }

            public string Bill_no { get; set; }//PURCHASE
            public decimal Tax { get; set; }//PURCHASE


            public int prod_id { get; set; }//SALE - PURCHASE
            public int Quantity { get; set; }//SALE - PURCHASE
            public decimal Price { get; set; }//SALE - PURCHASE
            public decimal Taxable_amt { get; set; }//SALE - PURCHASE                  
            public decimal Amount { get; set; }//SALE - PURCHASE


            public int hsn { get; set; }//SALE
            public decimal CGST { get; set; }//SALE
            public decimal SGST { get; set; }//SALE
            public decimal GST { get; set; }//SALE                        
            

            public int stocks { get; set; }

            //FUNCTION GET DETAILS OF A PRODUCT
            //CALLING FUNCTIONS
            //FUNCTION : BUTTON CLICK EVENT ADD MORE ITEMS, CLASS : DASHBOARD - FORM, Add_Purchases - FORM
            public void setProperties(int value)
            {
                DataSet ds = new DataSet();
                string[] arr = { "tbl_product", "tbl_HSCIN" };
                SqlParameter[] objParam = new SqlParameter[2];

                objParam[0] = new SqlParameter("@id", SqlDbType.Int);
                objParam[0].Value = value;

                objParam[1] = new SqlParameter("@cond", SqlDbType.Int);
                objParam[1].Value = 1;

                SqlHelper.FillDataset(ConnClass.getConnectionString(), CommandType.StoredProcedure, clsProcedures.getProdDetails, ds, arr, objParam);
                this.hsn = Convert.ToInt32(ds.Tables[0].Rows[0]["hsn"]);
                this.Name = ds.Tables[0].Rows[0]["product_name"].ToString();
                this.Brand = ds.Tables[0].Rows[0]["brand"].ToString();
                //this.price = Convert.ToDecimal(ds.Tables[0].Rows[0]["price"]);
                this.GST = Convert.ToInt32(ds.Tables[0].Rows[0]["gst"]);
                this.stocks = Convert.ToInt32(ds.Tables[0].Rows[0]["stock"]);

                this.Taxable_amt = this.Price * this.Quantity;
                this.CGST = this.SGST = (this.Taxable_amt * GST) / 200;
                this.Tax = this.CGST + this.SGST;
                this.Amount = this.Taxable_amt + this.CGST + this.SGST;
            }


            //FUNCTION GET AVAILABLE STOCK OF A PRODUCT
            //CALLING FUNCTIONS
            //FUNCTION : INDEX CHANGE EVENT OF DATAGRIDVIEW BRAND, CLASS : DASHBOARD - FORM, Add_Purchases - FORM
            public int getStocks(int id)
            {
                DataSet ds = new DataSet();
                string[] arr = { "tbl_product", "tbl_HSCIN" };
                SqlParameter[] objParam = new SqlParameter[2];

                objParam[0] = new SqlParameter("@id", SqlDbType.Int);
                objParam[0].Value = id;

                objParam[1] = new SqlParameter("@cond", SqlDbType.Int);
                objParam[1].Value = 0;

                SqlHelper.FillDataset(ConnClass.getConnectionString(), CommandType.StoredProcedure, clsProcedures.getProdDetails, ds, arr, objParam);
                return (int)ds.Tables[0].Rows[0]["stock"];
            }
        
    }
}
