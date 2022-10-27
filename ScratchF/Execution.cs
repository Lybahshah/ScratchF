using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools;
using System.Security.Cryptography.X509Certificates;
using AutoIt;
using System.Runtime.Remoting.Channels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Charts;
using static System.Windows.Forms.AxHost;

namespace ScratchF
{
    [TestClass]
    public class Execution : BasePage

    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            set
            {
                testContextInstance = value;
            }
            get { return testContextInstance; }

        }
        Form form=new Form();
        CreatePage cp = new CreatePage();
        LoginFirst login = new LoginFirst();
        LoginSecond log = new LoginSecond();
        SignUp reg = new SignUp();
        BasePage bp = new BasePage();
        [TestCategory("Smoke")]
        [TestMethod]
        public void Cretea()
        {

            //IWebDriver driver = new ChromeDriver();

            editor();

            cp.Mod();

            cp.Bylooks();
            cp.Loop();
            cp.ClickonMotionBlock();
            cp.Event();




        }

        [TestCategory("Smoke")]
        [TestMethod]
        public void Login()
        {
        bp.SeleniumInit();
            //IWebDriver driver = new ChromeDriver();

            string username = "lybahshah00";
        string password = "alidaan12";




        LoginFirst login = new LoginFirst();

            //login.ClickSignInFeature();
            Log.Info("Enter Username");
            login.TypeUserName(username);
            Log.Info("lybahshah");
            Log.Info("Enter password");
            login.TypePassword(password);
            Log.Info("alidaan12");
            login.ClickLogin();
            bp.SeleniumInit2();
            Log.Info("Enter Username");
            log.TypeUserName(username);
            Log.Info("lybahshah");
            Log.Info("Enter password");
            log.TypePassword(password);
            Log.Info("alidaan12");
            bp.SeleniumInit3();

            log.recaptcha();
            Thread.Sleep(15000);
            bp.SeleniumInit4();
           
            //log.ClickLogin();
            //bp.SeleniumInit5();
        }
        [TestCategory("Smoke")]
        [DataSource(@"Microsoft.VisualStudio.TestTools.DataSource.XML", "Pro.xml", "Signup", DataAccessMethod.Sequential)]

        [TestMethod]
        public void SignUPUsingXML()
        {
            bp.SeleniumInit();


            string Username = TestContext.DataRow["user"].ToString();

            string Password = TestContext.DataRow["pass"].ToString();
            string Cnfrmpass = TestContext.DataRow["cnfrm"].ToString();

            reg.ClickOnJoin();
            reg.EnterUsername(Username);
            reg.EnterPassword(Password);
            reg.EnterConfrmPass(Cnfrmpass);
            reg.Checkbox();
            reg.next();

        }
        [TestCategory("Smoke")]
        [TestMethod]
            public void editor()
            {
            bp.SeleniumInit();
            string username = "lybahshah00";
            string password = "alidaan12";
            login.Autoit(username, password);
            cp.ClickonCreateFeature();



            
        }

        [TestCategory("Smoke")]
        [TestMethod]
        public void autoitLogin()
        {

            bp.SeleniumInit();
            string username = "lybahshah00";
            string password = "alidaan12";
            login.Autoit(username, password);
        }
        [TestCategory("Jobs")]
        [DataSource("System.Data.SqlClient", "Data Source=DESKTOP-2LI0BRV;Initial Catalog=master;Integrated Security=True ", "SqaJobs",DataAccessMethod.Sequential)]
        [TestMethod]
        public void apply()
        {
            bp.SeleniumInit();


           string fname = TestContext.DataRow[0].ToString().Trim();
            string Lname = TestContext.DataRow[1].ToString().Trim();
            string Email = TestContext.DataRow[2].ToString().Trim();
            string Add = TestContext.DataRow[3].ToString().Trim();
            string City = TestContext.DataRow[4].ToString().Trim();
            string State = TestContext.DataRow[5].ToString().Trim();
            string Postal = TestContext.DataRow[6].ToString().Trim();
            string Phone = TestContext.DataRow[7].ToString().Trim();
            string Resume = TestContext.DataRow[8].ToString().Trim();
            string Sal = TestContext.DataRow[9].ToString().Trim();
            string Interest = TestContext.DataRow[10].ToString().Trim();
            form.FormFill(fname, Lname, Email, Add, City, State, Postal, Phone, Resume, Sal, Interest);




        }
            
        
    }
}




