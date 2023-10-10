using SoftverZaTrgovinu.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftverZaTrgovinu.Forms
{
    public partial class frmAdministracija : Form
    {
        public frmAdministracija()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("server=DESKTOP-DETU8RQ\\SQLEXPRESS01;Initial Catalog=SoftverZaTrgovinuDb;Integrated Security=True");
        Category categoryHelper = new Category();
        Article articleHelper = new Article();


       
        private void frmAdministracija_Load(object sender, EventArgs e)
        {
            categoryHelper.loadCategories(connection, lvCategories);
            articleHelper.loadArticles(connection, lvArticles);

            lvCategories.TileSize = new Size(20, 20);

            btnChangeCategory.Enabled = false;
            btnDeleteCategory.Enabled = false;

            articleHelper.fillDropDownMenu(connection, cbCategory);
        }

        #region UPDATE CATEGORY


        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (tbCategoryName.Text == string.Empty)
            {
                MessageBox.Show
                    (
                    "You must enter the name of category.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );

                return;
            }
            else
            {
                using (SqlCommand cmd = new SqlCommand("insert into Kategorije (naziv_kategorije) values (@naziv_kategorije)", connection))
                {
                    cmd.Parameters.AddWithValue("@naziv_kategorije", tbCategoryName.Text);

                    try
                    {
                        connection.Open();

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully added.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();

                        categoryHelper.reloadLvCategories(connection, lvCategories, tbCategoryName);
                        articleHelper.fillDropDownMenu(connection, cbCategory);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                }                
            }
        }

        private void lvCategories_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = lvCategories.SelectedItems[0];
            Int32.TryParse(selectedItem.Text, out int id);
            object result = categoryHelper.getNameById(id,connection);
            tbCategoryName.Text = result.ToString();

            btnChangeCategory.Enabled = true;
            btnDeleteCategory.Enabled = true;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (lvCategories.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvCategories.SelectedItems[0];
                Int32.TryParse(selectedItem.Text, out int id);
           
                using (SqlCommand cmd = new SqlCommand("update kategorije set naziv_kategorije = @naziv_kategorije where id = @id", connection))
                {
                    cmd.Parameters.AddWithValue("@naziv_kategorije", tbCategoryName.Text);
                    cmd.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbCategoryName.Text = string.Empty;

                        categoryHelper.reloadLvCategories(connection, lvCategories, tbCategoryName);
                        articleHelper.fillDropDownMenu(connection, cbCategory);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show
                    (
                    "You must select the filed you want to update.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }

        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (lvCategories.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvCategories.SelectedItems[0];
                int id = Int32.Parse(selectedItem.Text);

                using (SqlCommand cmd = new SqlCommand("delete from kategorije where id = " + id, connection))
                {
                    connection.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();

                        categoryHelper.reloadLvCategories(connection, lvCategories, tbCategoryName);
                        articleHelper.fillDropDownMenu(connection, cbCategory);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }   
                } 
            }
            else
            {
                MessageBox.Show
                    (
                    "You need to select field you want to delete.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void tbCategoryName_TextChanged(object sender, EventArgs e)
        {
            if(tbCategoryName.Text != string.Empty)
            {
                btnAddCategory.Enabled = true;
                btnChangeCategory.Enabled = true;
                btnDeleteCategory.Enabled = true;
            }
            else
            {
                btnAddCategory.Enabled = false;
                btnChangeCategory.Enabled = false;
                btnDeleteCategory.Enabled = false;
            }
        }

        #endregion


        #region UPDATE ARTICLE

        

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            if (
                tbArticleName.Text == string.Empty ||
                tbArticlePrice.Text == string.Empty ||
                tbMeasuremenetUnit.Text == string.Empty
               )
            {
                MessageBox.Show("All fileds needs to be filled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                var cmdCheck = new SqlCommand("select * from Artikli where naziv_artikla = @naziv_artikla", connection);
                connection.Open();

                cmdCheck.Parameters.AddWithValue("@naziv_artikla", tbArticleName.Text);
                var checker = cmdCheck.ExecuteScalar();


                if (checker != null)
                {
                    MessageBox.Show("Article already exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    connection.Close();
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand("insert into Artikli (naziv_artikla, cena, jedinica_mere, kategorija_id)" +
                        "values (@naziv_artikla, @cena, @jedinica_mere, @kategorija_id)", connection))
                    {
                        
                        cmd.Parameters.AddWithValue("@naziv_artikla", tbArticleName.Text);
                        try
                        {
                            if(tbArticlePrice.Text.Contains(","))
                            {
                                string aPrice = tbArticlePrice.Text.Replace(',', '.');
                                cmd.Parameters.AddWithValue("@cena", Convert.ToDouble(aPrice));
                            }
                            else
                                cmd.Parameters.AddWithValue("@cena", Convert.ToDouble(tbArticlePrice.Text));
                        }
                        catch
                        {
                            MessageBox.Show
                                (
                                "You must enter only the numbers in this field.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                                );
                            return;
                        }
                        cmd.Parameters.AddWithValue("@jedinica_mere", tbMeasuremenetUnit.Text);
                        cmd.Parameters.AddWithValue("@kategorija_id", cbCategory.SelectedValue);
                        try
                        {
                            var result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Successfully added.", "Notification");
                                connection.Close();

                                tbArticleName.Text = string.Empty;
                                tbArticlePrice.Text = string.Empty;
                                tbMeasuremenetUnit.Text = string.Empty;

                                articleHelper.reloadLvArticles(connection, lvArticles, tbArticleName, tbArticlePrice, tbMeasuremenetUnit);
                            }
                            else
                            {
                                MessageBox.Show("Something went wrong.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                connection.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void lvArticles_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = lvArticles.SelectedItems[0];
            Int32.TryParse(selectedItem.Text, out int id);
            Article article = articleHelper.getArticleById(id, connection);

            tbArticleName.Text = article.Naziv_artikla;
            tbArticlePrice.Text = article.Cena.ToString();
            tbMeasuremenetUnit.Text = article.Jedinica_mere;
        }

        private void btnUpdateArticle_Click(object sender, EventArgs e)
        {
            if (lvArticles.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvArticles.SelectedItems[0];
                Int32.TryParse(selectedItem.Text, out int id);

                using (SqlCommand cmd = new SqlCommand
                    (
                    "update Artikli set" +
                    " naziv_artikla = @naziv_artikla," +
                    " cena = @cena," +
                    " jedinica_mere = @jedinica_mere," +
                    " kategorija_id = @kategorija_id" +
                    " where id = @id",
                    connection
                    ))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@naziv_artikla", tbArticleName.Text);
                    try
                    {
                        cmd.Parameters.AddWithValue("@cena", Convert.ToDouble(tbArticlePrice.Text));
                    }
                    catch
                    {
                        MessageBox.Show("You must enter only numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    cmd.Parameters.AddWithValue("@jedinica_mere", tbMeasuremenetUnit.Text);
                    cmd.Parameters.AddWithValue("@kategorija_id", cbCategory.SelectedValue);

                    connection.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        connection.Close();

                        articleHelper.reloadLvArticles(connection, lvArticles, tbArticleName, tbArticlePrice, tbMeasuremenetUnit);
                    }
                    catch (Exception ee)
                    {
                        //MessageBox.Show("Updating failed", "Warning");
                        MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("You must select the filed you want to change.", "Notification");
            }
        }

        private void btnDeleteArticle_Click(object sender, EventArgs e)
        {
            if (lvArticles.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvArticles.SelectedItems[0];
                int id = Int32.Parse(selectedItem.Text);

                using (SqlCommand cmd = new SqlCommand("delete from Artikli where id = " + id, connection))
                {
                    connection.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();

                        articleHelper.reloadLvArticles(connection, lvArticles, tbArticleName, tbArticlePrice, tbMeasuremenetUnit);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Delete failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show
                    (
                    "You need to select field you want to delete.",
                    "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        #endregion
    }
}
