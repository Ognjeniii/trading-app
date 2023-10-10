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
    public class Category
    {
        public int Id { get; set; }
        public string Naziv_kategorije { get; set; }


        public void loadCategories(SqlConnection connection, ListView lvCategories)
        {
            DataTable dt;
            SqlDataAdapter da;
            DataSet ds;

            lvCategories.Columns.Add("Id", 50);
            lvCategories.Columns.Add("Naziv", 120, HorizontalAlignment.Left);
            lvCategories.View = View.Details;

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Kategorije", connection);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Kategorije");

            dt = ds.Tables["Kategorije"];
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                lvCategories.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                lvCategories.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
            }

            connection.Close();
        }

        public object getNameById(int id, SqlConnection connection)
        {
            using (SqlCommand cmd = new SqlCommand("select naziv_kategorije from kategorije where id like " + id, connection))
            {
                connection.Open();
                var result = cmd.ExecuteScalar();
                connection.Close();

                if (result != null)
                {
                    return result;
                }
                else
                {
                    return "";
                }
            }
        }

        public async Task<List<Button>> createCategoryButtons(SqlConnection connection)
        {
            List<Button> buttons = new List<Button>();
            using (SqlCommand cmd = new SqlCommand("select * from Kategorije", connection))
            {
                connection.Open();
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        buttons.Add(new Button()
                        {
                            Text = reader["naziv_kategorije"].ToString(),
                            BackColor = Color.LightPink,
                            Name = "btn" + reader["id"].ToString(),
                            Cursor = Cursors.Hand,
                            //Font =  new Font("Arial", 7)
                        });
                    }
                }
                connection.Close();
            }

            return buttons;
        }

        public void fillPanelWithCategoryButtons(List<Button> buttons, Panel panelCategory)
        {
            int baseX = panelCategory.Location.X;

            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Left = baseX;
                buttons[i].Top = 0;
                buttons[i].Size = new Size(80, 51);
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].FlatAppearance.BorderColor = Color.Black;

                baseX += 82;

                panelCategory.Controls.Add(buttons[i]);
            }
        }

        public void reloadLvCategories(SqlConnection connection, ListView lvCategories, TextBox tbCategoryName)
        {

            if (lvCategories.Items.Count > 0)
            {
                lvCategories.Items.RemoveAt(0);
                lvCategories.Items.Clear();
                tbCategoryName.Text = "";
            }

            DataTable dt;
            SqlDataAdapter da;
            DataSet ds;

            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from Kategorije", connection);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Kategorije");


            dt = ds.Tables["Kategorije"];
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                lvCategories.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                lvCategories.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());

            }

            connection.Close();
        }
    }
}
