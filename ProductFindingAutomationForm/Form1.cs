using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Entities;
using BusinessLayer;


namespace ProductFindingAutomationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        ChromeDriver driver;
        public ChromeDriver driverUsing()
        {
            CheckForIllegalCrossThreadCalls = false;
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            driver = new ChromeDriver(service);
            driver.Navigate().GoToUrl("https://www.n11.com/");
            driver.Manage().Window.Maximize();
            return driver;
        }

        public void closeDriver()
        {
            driver.Close();
        }
        DataTable dtp;
        ProductBLL productBll;
        private void btnProductSearch_Click(object sender, EventArgs e)
        {

            if (ckSiteName.Checked)
            {
                var driver = driverUsing();


                var text = driver.FindElement(By.CssSelector("#searchData"));
                var searchbutton = driver.FindElement(By.XPath("//header/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[1]/span[1]"));
                if (text != null)
                {
                    Actions actions = new Actions(driver);
                    actions.MoveToElement(text);

                    if (txtProductSearch.Text != string.Empty)
                    {
                        productBll = new ProductBLL();
                        dtp = new DataTable();
                        dtp.Columns.Add("UrunId", typeof(int));
                        dtp.Columns.Add("Urun_Adı", typeof(string));
                        dtp.Columns.Add("Fiyatı", typeof(string));
                        dtp.Columns.Add("Site Adı", typeof(string));
                        dtp.Columns.Add("Listeleme Tarihi", typeof(DateTime));
                        dtp.Columns.Add("Anahtar Kelime", typeof(string));

                        actions.Click(text);
                        actions.SendKeys(txtProductSearch.Text);
                        actions.Click(searchbutton);
                        actions.Build().Perform();

                        List<IWebElement> productName = driver.FindElements(By.ClassName("productName")).ToList();
                        List<IWebElement> price = driver.FindElements(By.TagName("ins")).ToList();


                        for (int i = 0; i < productName.Count; i++)
                        {
                            Product newproduct = new Product();
                            newproduct.ProductName = productName[i].Text;
                            try
                            {
                                newproduct.Price = price[i].Text;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message.ToString());
                            }


                            newproduct.SiteName = "N11";
                            newproduct.ListDate = Convert.ToDateTime(DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss"));
                            bool result = productBll.Add(newproduct);
                            if (result == true)
                            {
                                dtp.Rows.Add(newproduct.ProductId,
                                             newproduct.ProductName,
                                             newproduct.Price,
                                             newproduct.SiteName,
                                             newproduct.ListDate);
                            }
                        }
                        dtListProduct.DataSource = dtp;
                        closeDriver();
                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtProductSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtProductSearch.Text != null)
                txtProductSearch.Text = "";
        }

        

        private void txtProductFilter_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtProductFilter.Text != null)
                txtProductFilter.Text = "";
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            if (txtProductFilter.Text != null)
            {
                DataView dv = dtp.DefaultView;
                dv.RowFilter = "Urun_Adı LIKE '%" + txtProductFilter.Text + "%'";
                dtListProduct.DataSource = dv;
            }
        }
    }
}
