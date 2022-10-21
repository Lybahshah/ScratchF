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
        [TestMethod]
        public void apply()
        {
            bp.SeleniumInit();
            form.FormFill("laiba","riaz", "laibariaz0@gmail.com", "Raiwind", "Lahore","Punjab","1234","03216708300", "C:\\Users\\Admin\\Downloads\\bug.doc","500", "Hi,My name is laiba,I saw this job opening on Scratch,I'm an automation tester");
        }
    }
}




