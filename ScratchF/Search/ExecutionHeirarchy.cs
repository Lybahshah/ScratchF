using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScratchF
{
    [TestClass]
    public class ExecutionHeirarchy
    {

        Execution ex = new Execution();
        BasePage BP = new BasePage();
        Assertion As = new Assertion();
        Search srch = new Search();

        public TestContext TestContext
        {
            get;
            set;
        }
        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
            //MessageBox.Show("Assembly Initialization " + " " + context.TestName);
        }

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
          //  MessageBox.Show("Class Initialization " + " " + context.TestName);
        }

        [TestInitialize()]
        public void Initialize()
        {
           // MessageBox.Show("TestMethod Initiazlization");
        }
        [TestMethod]

        public void search()
        {
            string dat = "The Warrior Cat Game";
            BP.SeleniumInit();

            srch.searchField(dat);
            srch.serachButton();
            srch.enterClick();

          


        }
        [TestMethod]
        public void VerifySearch()
        {

           
            search();
            As.SearchAssertion();

           




        }
        [TestCleanup()]
        public void Cleanup()
        {
            //MessageBox.Show("TestMethod Cleanup");
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            //MessageBox.Show("Class Cleanup");
        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
            //MessageBox.Show("Assembly Cleanup");
        }




    }
}
