using iTextSharp.text;
using iTextSharp.text.pdf;
using SoftverZaTrgovinu.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftverZaTrgovinu.Forms
{
    public partial class frmProdaja : Form
    {
        public frmProdaja()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("server=DESKTOP-DETU8RQ\\SQLEXPRESS01;Initial Catalog=SoftverZaTrgovinuDb;Integrated Security=True");
        public static double bill = 0.0;

        Category categoryHelper = new Category();
        Article articleHelper = new Article();
        BillHelper billHelper = new BillHelper();

        private async void frmProdaja_Load(object sender, EventArgs e)
        {
            var buttons = await categoryHelper.createCategoryButtons(connection);
            categoryHelper.fillPanelWithCategoryButtons(buttons, panelCategory);

            addEventForEachCategoryButton(buttons);
            lbTotalBill.Text = bill + " RSD";

            listBoxBill.HorizontalScrollbar = true;
        }

        private void addEventForEachCategoryButton(List<Button> buttons)
        {
            for(int i = 0; i <= buttons.Count - 1; i++)
            {
                buttons[i].Click += new EventHandler(categoryButton_Click);
            }
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.IndianRed;

            int articleId = Int32.Parse(btn.Name.Substring(3));

            List<Button> buttons = articleHelper.createArticlesButtonsById(articleId, connection);
            fillPanelWithArticleButtons(buttons);
        }

        private void fillPanelWithArticleButtons(List<Button> buttons)
        {
            panelArticles.Controls.Clear();

            int baseX = panelCategory.Location.X;
            int baseY = panelCategory.Location.Y;

            for(int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Left = baseX;
                buttons[i].Top = baseY;
                buttons[i].Size = new Size(75, 75);
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].FlatAppearance.BorderColor = Color.Black;

                if(baseX < 188)
                {
                    baseX += 76;
                }
                else
                {
                    baseX = panelCategory.Location.Y;
                    baseY += 76;
                }
                

                panelArticles.Controls.Add(buttons[i]);

                addEventForEachArticleButton(buttons);
            }
        }

        private void addEventForEachArticleButton(List<Button> buttons)
        {
            for(int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Click += new EventHandler(articleButton_Click);
            }
        }

        private void articleButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            tbArticles.Text = btn.Text;
            tbArticles.ReadOnly = true;
        }

        


        //private void removeDuplicatesFromListBox(BillHelper billHelper, double quantity)
        //{
        //    int currentQuantity = 0;
        //    string itemForRemove = "";

        //    foreach(var item in listBoxBill.Items)
        //    {
        //        if (item.GetType() == typeof(string))
        //        {
        //            string itemStr = item.ToString();
        //            string articleNameFromLB = itemStr.Remove(itemStr.LastIndexOf("("));

        //            if(articleNameFromLB == billHelper.ArticleName)
        //            {
        //                currentQuantity = int.Parse(itemStr.Substring(itemStr.LastIndexOf(" ") + 1));

        //                listBoxBill.Items.Add(billHelper + " x " + (currentQuantity + quantity).ToString());

        //                itemForRemove = itemStr;
        //                break;
        //            }
        //        }
        //    }
        //    listBoxBill.Items.Remove(itemForRemove);
        //}

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (tbArticles.Text != string.Empty)
            {
                string input;
                double quantity = 1;

                if (tbArticles.Text.Contains(" x "))
                {
                    input = tbArticles.Text.Remove(tbArticles.Text.LastIndexOf(" x "));
                    quantity = Double.Parse(tbArticles.Text.Substring(tbArticles.Text.LastIndexOf(" ") + 1));
                }
                else
                {
                    input = tbArticles.Text;
                }
                
                Article article = articleHelper.getArticleByName(input, connection);

                if (billHelper.isItAlcohol(article.Kategorija_id, connection) && billHelper.isLaterThanTen())
                {
                    MessageBox.Show
                        (
                        "It is later than ten o'clock at the moment, you cant buy alcohol.",
                        "Warning", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop
                        );

                    return;
                }
                else
                {
                    bill = Math.Round(bill += article.Cena * quantity, 2);
                    lbTotalBill.Text = bill + " RSD";

                    BillHelper helper = new BillHelper
                    {
                        ArticleName = article.Naziv_artikla,
                        MeasurementUnit = article.Jedinica_mere.Substring(article.Jedinica_mere.LastIndexOf(" ")),
                        Price = article.Cena * quantity,
                        Quantity = billHelper.getMeasureOfArticle(article.Jedinica_mere)
                    };

                    // checking if article is from fruit/vegetables categroy (kg)
                    if (article.Kategorija_id == 2)
                    {
                        listBoxBill.Items.Add(helper);
                    }
                    else
                    {
                        //removeDuplicatesFromListBox(helper, quantity);

                        helper.Quantity = billHelper.getMeasureOfArticle(article.Jedinica_mere);
                        if(quantity > 1)
                        {
                            listBoxBill.Items.Add(helper + " x " + quantity.ToString());
                        }
                        else
                        {
                            listBoxBill.Items.Add(helper);
                        }
                    }

                    tbArticles.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show
                    (
                    "You need to select article from tab.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            tbArticles.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(listBoxBill.Items.Count > 0 && listBoxBill.SelectedIndex <= -1)
            {
                DialogResult dialogResult = MessageBox.Show
                    (
                "Are you sure that you want to delete all current bill?",
                "Delete current bill",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                    );

                if (dialogResult == DialogResult.Yes)
                {
                    listBoxBill.Items.Clear();

                    bill = 0;
                    lbTotalBill.Text = bill + " RSD";
                }
            }
            else if(listBoxBill.SelectedItems.Count > 0)
            {

                if (listBoxBill.SelectedItem.GetType() == typeof(BillHelper))
                {
                    BillHelper helper = listBoxBill.SelectedItem as BillHelper;
                    listBoxBill.Items.Remove(helper);
                    bill -= helper.Price;
                    lbTotalBill.Text = bill + " RSD";
                }
                else if(listBoxBill.SelectedItem.GetType() == typeof(string))
                {
                    object helper = listBoxBill.SelectedItem;
                    string helperStr = helper.ToString();
                    string endOfStr = helperStr.Substring(helperStr.LastIndexOf(")") + 4);
                    int quantity = Int32.Parse(endOfStr);

                    string articleName = helperStr.Remove(helperStr.IndexOf("("));

                    Article article = articleHelper.getArticleByName(articleName, connection);
                    listBoxBill.Items.Remove(helper);

                    bill -= article.Cena * quantity;
                    lbTotalBill.Text = bill + " RSD";
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (listBoxBill.Items.Count > 0)
            {
                tabControlBill.SelectTab("tabBill");
                tbArticles.Text = string.Empty;

                btn0.Enabled = false;
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btnTimes.Enabled = false;
                btnComma.Enabled = false;
                btnInput.Enabled = false;
                btnUndo.Enabled = false;
                btnDelete.Enabled = false;
                btnNext.Enabled = false;

                tbArticles.Enabled = false;

                listBoxFinishBill.Items.Add("=========Final bill===========");
                listBoxFinishBill.Items.Add("\n");
                foreach (var item in listBoxBill.Items)
                {
                    if (item.GetType() == typeof(BillHelper))
                    {
                        BillHelper helper = (BillHelper)item;
                        listBoxFinishBill.Items.Add(helper.ArticleName + "  -  " + helper.Price);
                    }
                    else if (item.GetType() == typeof(string))
                    {
                        string helper = item.ToString();
                        string endOfStr = helper.Substring(helper.LastIndexOf(")") + 4);
                        int quantity = Int32.Parse(endOfStr);

                        string articleName = helper.Remove(helper.IndexOf("("));

                        Article article = articleHelper.getArticleByName(articleName, connection);
                        listBoxFinishBill.Items.Add(article.Naziv_artikla + "  -  " + article.Cena * quantity);
                    }
                }

                listBoxFinishBill.Items.Add("____________________________");
                listBoxFinishBill.Items.Add("\nTotal: " + bill + " rsd");
                listBoxFinishBill.Items.Add("\n\r" + DateTime.Now.ToString("G"));
            }
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            tabControlBill.SelectTab("tabInput");
            listBoxBill.Items.Clear();
            bill = 0;
            lbTotalBill.Text = bill + " RSD";

            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnTimes.Enabled = true;
            btnComma.Enabled = true;
            btnInput.Enabled = true;
            btnUndo.Enabled = true;
            btnDelete.Enabled = true;
            btnNext.Enabled = true;

            tbArticles.Enabled = true;

            listBoxFinishBill.Items.Clear();
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            if (listBoxFinishBill.Items.Count > 0)
            {
                billHelper.createPdf(listBoxFinishBill);
            }
            listBoxFinishBill.Items.Clear();
        }


        #region DIGIT BUTTONS
        private void buttonHelper(string character)
        {
            if (tbArticles.Text.Length > 0)
            {
                if (tbArticles.Text.Contains(" x "))
                {
                    tbArticles.Text += character;
                }
                else
                {
                    tbArticles.Text += " x " + character;
                }
            }
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            if (tbArticles.Text.Length > 0)
            {
                if (!tbArticles.Text.Contains(" x "))
                {
                    tbArticles.Text += " x ";
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            buttonHelper("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            buttonHelper("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            buttonHelper("9");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            buttonHelper("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            buttonHelper("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            buttonHelper("6");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            buttonHelper("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            buttonHelper("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            buttonHelper("3");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            buttonHelper("0");
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (tbArticles.Text.Length > 0)
            {
                tbArticles.Text += ".";
            }
        }

        #endregion

    }
}
