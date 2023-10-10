namespace SoftverZaTrgovinu.Forms
{
    partial class frmAdministracija
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabAzuriranjeArtikala = new System.Windows.Forms.TabPage();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbArticleName = new System.Windows.Forms.Label();
            this.tbArticleName = new System.Windows.Forms.TextBox();
            this.lbArticlePrice = new System.Windows.Forms.Label();
            this.tbArticlePrice = new System.Windows.Forms.TextBox();
            this.lbMeasurementUnit = new System.Windows.Forms.Label();
            this.tbMeasuremenetUnit = new System.Windows.Forms.TextBox();
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.btnUpdateArticle = new System.Windows.Forms.Button();
            this.btnDeleteArticle = new System.Windows.Forms.Button();
            this.lvArticles = new System.Windows.Forms.ListView();
            this.tabAzuriranjeKategorija = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnChangeCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.lvCategories = new System.Windows.Forms.ListView();
            this.lbMessage = new System.Windows.Forms.Label();
            this.tabConAdministracija = new System.Windows.Forms.TabControl();
            this.tabAzuriranjeArtikala.SuspendLayout();
            this.tabAzuriranjeKategorija.SuspendLayout();
            this.tabConAdministracija.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAzuriranjeArtikala
            // 
            this.tabAzuriranjeArtikala.Controls.Add(this.lvArticles);
            this.tabAzuriranjeArtikala.Controls.Add(this.btnDeleteArticle);
            this.tabAzuriranjeArtikala.Controls.Add(this.btnUpdateArticle);
            this.tabAzuriranjeArtikala.Controls.Add(this.btnAddArticle);
            this.tabAzuriranjeArtikala.Controls.Add(this.tbMeasuremenetUnit);
            this.tabAzuriranjeArtikala.Controls.Add(this.tbArticlePrice);
            this.tabAzuriranjeArtikala.Controls.Add(this.tbArticleName);
            this.tabAzuriranjeArtikala.Controls.Add(this.lbMeasurementUnit);
            this.tabAzuriranjeArtikala.Controls.Add(this.lbArticlePrice);
            this.tabAzuriranjeArtikala.Controls.Add(this.lbArticleName);
            this.tabAzuriranjeArtikala.Controls.Add(this.lbCategory);
            this.tabAzuriranjeArtikala.Controls.Add(this.cbCategory);
            this.tabAzuriranjeArtikala.Location = new System.Drawing.Point(4, 28);
            this.tabAzuriranjeArtikala.Name = "tabAzuriranjeArtikala";
            this.tabAzuriranjeArtikala.Padding = new System.Windows.Forms.Padding(3);
            this.tabAzuriranjeArtikala.Size = new System.Drawing.Size(696, 340);
            this.tabAzuriranjeArtikala.TabIndex = 1;
            this.tabAzuriranjeArtikala.Text = "Update Articles";
            this.tabAzuriranjeArtikala.UseVisualStyleBackColor = true;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(9, 25);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(318, 27);
            this.cbCategory.TabIndex = 0;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(8, 3);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(81, 19);
            this.lbCategory.TabIndex = 1;
            this.lbCategory.Text = "Category:";
            // 
            // lbArticleName
            // 
            this.lbArticleName.AutoSize = true;
            this.lbArticleName.Location = new System.Drawing.Point(8, 55);
            this.lbArticleName.Name = "lbArticleName";
            this.lbArticleName.Size = new System.Drawing.Size(105, 19);
            this.lbArticleName.TabIndex = 2;
            this.lbArticleName.Text = "Article name:";
            // 
            // tbArticleName
            // 
            this.tbArticleName.Location = new System.Drawing.Point(9, 77);
            this.tbArticleName.Name = "tbArticleName";
            this.tbArticleName.Size = new System.Drawing.Size(318, 27);
            this.tbArticleName.TabIndex = 3;
            // 
            // lbArticlePrice
            // 
            this.lbArticlePrice.AutoSize = true;
            this.lbArticlePrice.Location = new System.Drawing.Point(8, 107);
            this.lbArticlePrice.Name = "lbArticlePrice";
            this.lbArticlePrice.Size = new System.Drawing.Size(102, 19);
            this.lbArticlePrice.TabIndex = 4;
            this.lbArticlePrice.Text = "Article price:";
            // 
            // tbArticlePrice
            // 
            this.tbArticlePrice.Location = new System.Drawing.Point(9, 129);
            this.tbArticlePrice.Name = "tbArticlePrice";
            this.tbArticlePrice.Size = new System.Drawing.Size(318, 27);
            this.tbArticlePrice.TabIndex = 5;
            // 
            // lbMeasurementUnit
            // 
            this.lbMeasurementUnit.AutoSize = true;
            this.lbMeasurementUnit.Location = new System.Drawing.Point(8, 159);
            this.lbMeasurementUnit.Name = "lbMeasurementUnit";
            this.lbMeasurementUnit.Size = new System.Drawing.Size(143, 19);
            this.lbMeasurementUnit.TabIndex = 6;
            this.lbMeasurementUnit.Text = "Measurement unit:";
            // 
            // tbMeasuremenetUnit
            // 
            this.tbMeasuremenetUnit.Location = new System.Drawing.Point(9, 181);
            this.tbMeasuremenetUnit.Name = "tbMeasuremenetUnit";
            this.tbMeasuremenetUnit.Size = new System.Drawing.Size(318, 27);
            this.tbMeasuremenetUnit.TabIndex = 7;
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddArticle.Location = new System.Drawing.Point(9, 215);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(318, 36);
            this.btnAddArticle.TabIndex = 8;
            this.btnAddArticle.Text = "Add article";
            this.btnAddArticle.UseVisualStyleBackColor = true;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // btnUpdateArticle
            // 
            this.btnUpdateArticle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateArticle.Location = new System.Drawing.Point(9, 257);
            this.btnUpdateArticle.Name = "btnUpdateArticle";
            this.btnUpdateArticle.Size = new System.Drawing.Size(318, 36);
            this.btnUpdateArticle.TabIndex = 9;
            this.btnUpdateArticle.Text = "Update article";
            this.btnUpdateArticle.UseVisualStyleBackColor = true;
            this.btnUpdateArticle.Click += new System.EventHandler(this.btnUpdateArticle_Click);
            // 
            // btnDeleteArticle
            // 
            this.btnDeleteArticle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteArticle.Location = new System.Drawing.Point(9, 301);
            this.btnDeleteArticle.Name = "btnDeleteArticle";
            this.btnDeleteArticle.Size = new System.Drawing.Size(318, 36);
            this.btnDeleteArticle.TabIndex = 10;
            this.btnDeleteArticle.Text = "Delete article";
            this.btnDeleteArticle.UseVisualStyleBackColor = true;
            this.btnDeleteArticle.Click += new System.EventHandler(this.btnDeleteArticle_Click);
            // 
            // lvArticles
            // 
            this.lvArticles.HideSelection = false;
            this.lvArticles.Location = new System.Drawing.Point(333, 7);
            this.lvArticles.Name = "lvArticles";
            this.lvArticles.Size = new System.Drawing.Size(357, 330);
            this.lvArticles.TabIndex = 11;
            this.lvArticles.UseCompatibleStateImageBehavior = false;
            this.lvArticles.Click += new System.EventHandler(this.lvArticles_Click);
            // 
            // tabAzuriranjeKategorija
            // 
            this.tabAzuriranjeKategorija.Controls.Add(this.lbMessage);
            this.tabAzuriranjeKategorija.Controls.Add(this.lvCategories);
            this.tabAzuriranjeKategorija.Controls.Add(this.btnDeleteCategory);
            this.tabAzuriranjeKategorija.Controls.Add(this.btnChangeCategory);
            this.tabAzuriranjeKategorija.Controls.Add(this.btnAddCategory);
            this.tabAzuriranjeKategorija.Controls.Add(this.tbCategoryName);
            this.tabAzuriranjeKategorija.Controls.Add(this.label1);
            this.tabAzuriranjeKategorija.Location = new System.Drawing.Point(4, 28);
            this.tabAzuriranjeKategorija.Name = "tabAzuriranjeKategorija";
            this.tabAzuriranjeKategorija.Padding = new System.Windows.Forms.Padding(3);
            this.tabAzuriranjeKategorija.Size = new System.Drawing.Size(696, 340);
            this.tabAzuriranjeKategorija.TabIndex = 0;
            this.tabAzuriranjeKategorija.Text = "Update Category";
            this.tabAzuriranjeKategorija.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category name:";
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Location = new System.Drawing.Point(8, 79);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(393, 27);
            this.tbCategoryName.TabIndex = 2;
            this.tbCategoryName.TextChanged += new System.EventHandler(this.tbCategoryName_TextChanged);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.Location = new System.Drawing.Point(8, 123);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(393, 41);
            this.btnAddCategory.TabIndex = 3;
            this.btnAddCategory.Text = "Add category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnChangeCategory
            // 
            this.btnChangeCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeCategory.Location = new System.Drawing.Point(8, 170);
            this.btnChangeCategory.Name = "btnChangeCategory";
            this.btnChangeCategory.Size = new System.Drawing.Size(395, 41);
            this.btnChangeCategory.TabIndex = 4;
            this.btnChangeCategory.Text = "Update category";
            this.btnChangeCategory.UseVisualStyleBackColor = true;
            this.btnChangeCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCategory.Location = new System.Drawing.Point(8, 217);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(393, 41);
            this.btnDeleteCategory.TabIndex = 5;
            this.btnDeleteCategory.Text = "Delete category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // lvCategories
            // 
            this.lvCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvCategories.HideSelection = false;
            this.lvCategories.Location = new System.Drawing.Point(413, 7);
            this.lvCategories.Name = "lvCategories";
            this.lvCategories.Size = new System.Drawing.Size(272, 324);
            this.lvCategories.TabIndex = 6;
            this.lvCategories.UseCompatibleStateImageBehavior = false;
            this.lvCategories.Click += new System.EventHandler(this.lvCategories_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbMessage.Location = new System.Drawing.Point(6, 261);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(401, 76);
            this.lbMessage.TabIndex = 7;
            this.lbMessage.Text = "\r\nBy clicking on the id you get the possibility to change and delete categories.\r" +
    "\n";
            // 
            // tabConAdministracija
            // 
            this.tabConAdministracija.Controls.Add(this.tabAzuriranjeKategorija);
            this.tabConAdministracija.Controls.Add(this.tabAzuriranjeArtikala);
            this.tabConAdministracija.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConAdministracija.Location = new System.Drawing.Point(0, 0);
            this.tabConAdministracija.Name = "tabConAdministracija";
            this.tabConAdministracija.SelectedIndex = 0;
            this.tabConAdministracija.Size = new System.Drawing.Size(704, 372);
            this.tabConAdministracija.TabIndex = 0;
            // 
            // frmAdministracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 371);
            this.Controls.Add(this.tabConAdministracija);
            this.Name = "frmAdministracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.frmAdministracija_Load);
            this.tabAzuriranjeArtikala.ResumeLayout(false);
            this.tabAzuriranjeArtikala.PerformLayout();
            this.tabAzuriranjeKategorija.ResumeLayout(false);
            this.tabAzuriranjeKategorija.PerformLayout();
            this.tabConAdministracija.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabAzuriranjeArtikala;
        private System.Windows.Forms.ListView lvArticles;
        private System.Windows.Forms.Button btnDeleteArticle;
        private System.Windows.Forms.Button btnUpdateArticle;
        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.TextBox tbMeasuremenetUnit;
        private System.Windows.Forms.TextBox tbArticlePrice;
        private System.Windows.Forms.TextBox tbArticleName;
        private System.Windows.Forms.Label lbMeasurementUnit;
        private System.Windows.Forms.Label lbArticlePrice;
        private System.Windows.Forms.Label lbArticleName;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TabPage tabAzuriranjeKategorija;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.ListView lvCategories;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnChangeCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabConAdministracija;
    }
}