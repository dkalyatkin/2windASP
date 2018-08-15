using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Media.Imaging;
using System.Windows.Forms;

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

    protected void Button9_Click(object sender, EventArgs e)
    {
      /*  BitmapImage bitmap = new BitmapImage();         // Выбор изображения
        im = image1;
        im.Source = null;
        OpenFileDialog dialog = new OpenFileDialog();
        dialog.InitialDirectory = "C:\\бла бла бла\\Desktop";
        dialog.Filter = "Image files (*.jpg)|*.jpg|All Files (*.*)|*.*";
        dialog.RestoreDirectory = true;
        if (dialog.ShowDialog() == true)
        {

            selectedFileName = dialog.FileName;
            filename = selectedFileName;
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(selectedFileName);
            bitmap.EndInit();
            im.MaxWidth = 480;
            im.Height = bitmap.Height;
            im.Width = bitmap.Width;
            im.Source = bitmap;     
        }   */
    }
}