using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftverZaTrgovinu.Classes
{
    public class BillHelper
    {
        public string ArticleName { get; set; }
        public double Quantity { get; set; }
        public string MeasurementUnit { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return ArticleName + "(" + Quantity + " " + MeasurementUnit + ")"; 
        }

        public bool isLaterThanTen()
        {
            var currentTime = DateTime.Now.Hour.ToString();
            if (Int32.Parse(currentTime) >= 22)
            {
                return true;
            }
            return false;
        }

        public bool isItAlcohol(int id, SqlConnection connection)
        {
            using (SqlCommand cmd = new SqlCommand("select naziv_kategorije from Kategorije where id = @id", connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                object catName = cmd.ExecuteScalar();
                connection.Close();
                string categoryName = catName.ToString();
                if (categoryName == "Alkoholna pića" || categoryName == "Alkoholna pica")
                {
                    return true;
                }
                return false;
            }
        }

        public void createPdf(ListBox listBoxFinishBill)
        {
            string[] arrayStr = new string[listBoxFinishBill.Items.Count];
            for (int i = 0; i < arrayStr.Length; i++)
            {
                arrayStr[i] = listBoxFinishBill.Items[i].ToString();
            }

            int billId = nextBillId(@"C:\Users\Ogi\Desktop\Bills\");

            string outPath = "C:\\Users\\Ogi\\Desktop\\Bills\\bill_" + billId + ".pdf";

            using (FileStream fs = new FileStream(outPath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (Document doc = new Document(PageSize.A6, 55, 55, 30, 30))
                {
                    try
                    {
                        PdfWriter pdfWriter = PdfWriter.GetInstance(doc, fs);
                        doc.Open();

                        foreach (var item in arrayStr)
                        {
                            Paragraph paragraph = new Paragraph(item);
                            doc.Add(paragraph);
                        }

                        doc.Close();
                        pdfWriter.Close();

                        MessageBox.Show
                            (
                            "You have successfully printed a pdf file.",
                            "Pdf file", MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public int nextBillId(string path)
        {
            string[] result = Directory.GetFiles(path);
            int[] arr = new int[result.Length];
            if (result.Length == 0)
            {
                return 1;
            }

            for (int i = 0; i < result.Length; i++)
            {
                string helpStr = result[i].Substring(result[i].IndexOf("_") + 1);
                helpStr = helpStr.Remove(helpStr.IndexOf("."));
                int billNum = int.Parse(helpStr);

                arr[i] = billNum;
            }

            return arr.Max() + 1;
        }

        public double getMeasureOfArticle(string mUnit)
        {
            int mUnitLength = mUnit.Length;
            string mUnitSub = mUnit.Substring(mUnit.LastIndexOf(" "));
            string num = mUnit.Substring(0, mUnitLength - mUnitSub.Length);

            return Convert.ToDouble(num);
        }
    }
}
