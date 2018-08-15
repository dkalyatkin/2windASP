using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class news : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["2wind"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        SqlCommand command = new SqlCommand("Select text From news WHERE id = 3", con);
        object result = command.ExecuteScalar();
        Label1.Text = Convert.ToString(result);         // Вывод текста в Label        
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        string txtBig = editor1.Value;
        TextBox3.Text = txtBig;        
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["2wind"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        SqlCommand command = new SqlCommand("INSERT INTO news (text ) VALUES (@a)", con);   // Запись из TextArea в БД
        command.Parameters.AddWithValue("@a", editor1.Value);
        command.ExecuteNonQuery();
        con.Close();
       // MessageBox
        string script = "alert(\"Запись успешно сохранена в БД!\");";
        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
    }
}