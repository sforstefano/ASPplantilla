using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }




    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        float importe = 0;
        string dia;

        dia = DropDownList1.SelectedValue;

        float.TryParse(precio.Text, out importe);

        switch (dia)
        {


        }

        
    }
}