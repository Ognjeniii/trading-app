using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftverZaTrgovinu.Classes
{
    public class Article
    {
        public int Id { get; set; }
        public string Naziv_artikla { get; set; }
        public double Cena { get; set; }
        public string Jedinica_mere { get; set; }
        public int Kategorija_id { get; set; }


        public Article getArticleById(int id, SqlConnection connection)
        {
            using (SqlCommand cmd = new SqlCommand("select * from Artikli where id = @id", connection))
            {
                Article article = new Article();
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        article.Id = (int)rdr["id"];
                        article.Naziv_artikla = rdr["naziv_artikla"].ToString();
                        article.Cena = Convert.ToDouble(rdr["cena"]);
                        article.Jedinica_mere = rdr["jedinica_mere"].ToString();
                        article.Kategorija_id = (int)rdr["kategorija_id"];
                    }
                    connection.Close();
                }
                return article;
            }
        }

        public Article getArticleByName(string name, SqlConnection connection)
        {
            using (SqlCommand cmd = new SqlCommand("select * from Artikli where naziv_artikla = @naziv_artikla", connection))
            {
                Article article = new Article();
                cmd.Parameters.AddWithValue("@naziv_artikla", name);
                connection.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        article.Id = (int)rdr["id"];
                        article.Naziv_artikla = rdr["naziv_artikla"].ToString();
                        article.Cena = Convert.ToDouble(rdr["cena"]);
                        article.Jedinica_mere = rdr["jedinica_mere"].ToString();
                        article.Kategorija_id = (int)rdr["kategorija_id"];
                    }
                    connection.Close();
                }
                return article;
            }
        }

        public void reloadLvArticles
            (
            SqlConnection connection,
            ListView lvArticles,
            TextBox tbArticleName,
            TextBox tbArticlePrice,
            TextBox tbMeasuremenetUnit
            )
        {
            if (lvArticles.Items.Count > 0)
            {
                lvArticles.Items.RemoveAt(0);
                lvArticles.Items.Clear();

                tbArticleName.Text = string.Empty;
                tbArticlePrice.Text = string.Empty;
                tbMeasuremenetUnit.Text = string.Empty;
            }

            DataTable dt;
            SqlDataAdapter da;
            DataSet ds;

            SqlCommand cmd = new SqlCommand("Select * from Artikli", connection);

            connection.Open();

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Artikli");


            dt = ds.Tables["Artikli"];
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                lvArticles.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                lvArticles.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                lvArticles.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                lvArticles.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
            }
            connection.Close();
        }

        public void fillDropDownMenu(SqlConnection connection, ComboBox cbCategory)
        {
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            var categories = new List<Category>();

            using (SqlCommand cmd = new SqlCommand("select * from Kategorije", connection))
            {
                connection.Open();

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        categories.Add(new Category() { Id = (int)rdr["id"], Naziv_kategorije = rdr["naziv_kategorije"].ToString() });
                    }
                    cbCategory.DataSource = categories;
                    cbCategory.DisplayMember = "Naziv_Kategorije";
                    cbCategory.ValueMember = "Id";

                    connection.Close();
                }
            }
        }

        public void loadArticles(SqlConnection connection, ListView lvArticles)
        {
            DataTable dt;
            SqlDataAdapter da;
            DataSet ds;

            lvArticles.Columns.Add("Id", 30);
            lvArticles.Columns.Add("Naziv", 120, HorizontalAlignment.Left);
            lvArticles.Columns.Add("Cena", 100, HorizontalAlignment.Left);
            lvArticles.Columns.Add("Jedinica mere", 100, HorizontalAlignment.Left);
            lvArticles.View = View.Details;

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Artikli", connection);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Artikli");

            dt = ds.Tables["Artikli"];
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                lvArticles.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                lvArticles.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                lvArticles.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                lvArticles.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
            }

            connection.Close();
        }

        public List<Button> createArticlesButtonsById(int id, SqlConnection connection)
        {
            List<Button> buttons = new List<Button>();
            using (SqlCommand cmd = new SqlCommand("select * from Artikli where kategorija_id = " + id, connection))
            {
                connection.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        buttons.Add(new Button
                        {
                            Text = rdr["naziv_artikla"].ToString(),
                            Name = "btn" + rdr["id"].ToString(),
                            BackColor = Color.Bisque,
                            Cursor = Cursors.Hand,
                            //Font = new Font("Arial", 7)
                        });
                    }
                }
                connection.Close();
            }
            return buttons;
        }

    }
}
