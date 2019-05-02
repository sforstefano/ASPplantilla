using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    public int random;
    public int intents;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Label3.Text == "¿?")
        {
            random = new Random().Next(1000, 9999);
            Label3.Text = Convert.ToString(random);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {


        String a = TextBox1.Text;
        TextBox1.Enabled = false;
        

        if (intents < 0)
        {
            intents = intents * -1;
        }

        intents = Convert.ToInt32(a);
        Label2.Text = a;
        TextBox1.Attributes.Add("readonly", "readonly");




    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        intents = Convert.ToInt32(Label2.Text);
        intents--;
        Label2.Text = Convert.ToString(intents);
        TextBox1.Text = Convert.ToString(intents);


        if (intents >= 1)
        {
            random = Convert.ToInt32(Label3.Text);
            int numero = Convert.ToInt16(TextBox2.Text);
            if (numero > random)
            {
                Label1.Text = "Hm... proba menys";
            }
            else if (numero < random)
            {
                Label1.Text = "Hm... proba un poc més";
                
            }
            else {
                Label1.Text = "Bingo!";
                Button2.Enabled = false;
            }
            

            
            
            Label3.Text = Convert.ToString(random);



        }
        else
        {
            Label1.Text = "Has perdut";
            TextBox2.Enabled = false;
            Button2.Enabled = false;
        }
        

    }
}