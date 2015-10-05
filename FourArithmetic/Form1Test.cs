using Elementary_Arithmetic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace FourArithmetic
{
    
    
    /// <summary>
    ///这是 Form1Test 的测试类，旨在
    ///包含所有 Form1Test 单元测试
    ///</summary>
    [TestClass()]
    public class Form1Test
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Form1 构造函数 的测试
        ///</summary>
        [TestMethod()]
        public void Form1ConstructorTest()
        {
            Form1 target = new Form1();
            Assert.Inconclusive("TODO: 实现用来验证目标的代码");
        }

        /// <summary>
        ///Dispose 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Elementary Arithmetic.exe")]
        public void DisposeTest()
        {
            Form1_Accessor target = new Form1_Accessor(); // TODO: 初始化为适当的值
            bool disposing = false; // TODO: 初始化为适当的值
            target.Dispose(disposing);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///Form1_Load 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Elementary Arithmetic.exe")]
        public void Form1_LoadTest()
        {
            Form1_Accessor target = new Form1_Accessor(); // TODO: 初始化为适当的值
            object sender = null; // TODO: 初始化为适当的值
            EventArgs e = null; // TODO: 初始化为适当的值
            target.Form1_Load(sender, e);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///InitializeComponent 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Elementary Arithmetic.exe")]
        public void InitializeComponentTest()
        {
            Form1_Accessor target = new Form1_Accessor(); // TODO: 初始化为适当的值
            target.InitializeComponent();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///RandomNum 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Elementary Arithmetic.exe")]
        public void RandomNumTest()
        {
            Form1_Accessor target = new Form1_Accessor(); // TODO: 初始化为适当的值
            target.RandomNum();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///button1_Click 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Elementary Arithmetic.exe")]
        public void button1_ClickTest()
        {
            Form1_Accessor target = new Form1_Accessor(); // TODO: 初始化为适当的值
            object sender = null; // TODO: 初始化为适当的值
            EventArgs e = null; // TODO: 初始化为适当的值
            target.button1_Click(sender, e);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///button1_KeyDown 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Elementary Arithmetic.exe")]
        public void button1_KeyDownTest()
        {
            Form1_Accessor target = new Form1_Accessor(); // TODO: 初始化为适当的值
            object sender = null; // TODO: 初始化为适当的值
            KeyEventArgs e = null; // TODO: 初始化为适当的值
            target.button1_KeyDown(sender, e);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///button2_Click 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Elementary Arithmetic.exe")]
        public void button2_ClickTest()
        {
            Form1_Accessor target = new Form1_Accessor(); // TODO: 初始化为适当的值
            object sender = null; // TODO: 初始化为适当的值
            EventArgs e = null; // TODO: 初始化为适当的值
            target.button2_Click(sender, e);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///button2_KeyDown 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Elementary Arithmetic.exe")]
        public void button2_KeyDownTest()
        {
            Form1_Accessor target = new Form1_Accessor(); // TODO: 初始化为适当的值
            object sender = null; // TODO: 初始化为适当的值
            KeyEventArgs e = null; // TODO: 初始化为适当的值
            target.button2_KeyDown(sender, e);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///button3_Click 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Elementary Arithmetic.exe")]
        public void button3_ClickTest()
        {
            Form1_Accessor target = new Form1_Accessor(); // TODO: 初始化为适当的值
            object sender = null; // TODO: 初始化为适当的值
            EventArgs e = null; // TODO: 初始化为适当的值
            target.button3_Click(sender, e);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///button3_KeyDown 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Elementary Arithmetic.exe")]
        public void button3_KeyDownTest()
        {
            Form1_Accessor target = new Form1_Accessor(); // TODO: 初始化为适当的值
            object sender = null; // TODO: 初始化为适当的值
            KeyEventArgs e = null; // TODO: 初始化为适当的值
            target.button3_KeyDown(sender, e);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///button4_Click 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Elementary Arithmetic.exe")]
        public void button4_ClickTest()
        {
            Form1_Accessor target = new Form1_Accessor(); // TODO: 初始化为适当的值
            object sender = null; // TODO: 初始化为适当的值
            EventArgs e = null; // TODO: 初始化为适当的值
            target.button4_Click(sender, e);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///button4_KeyDown 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Elementary Arithmetic.exe")]
        public void button4_KeyDownTest()
        {
            Form1_Accessor target = new Form1_Accessor(); // TODO: 初始化为适当的值
            object sender = null; // TODO: 初始化为适当的值
            KeyEventArgs e = null; // TODO: 初始化为适当的值
            target.button4_KeyDown(sender, e);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///button5_Click 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Elementary Arithmetic.exe")]
        public void button5_ClickTest()
        {
            Form1_Accessor target = new Form1_Accessor(); // TODO: 初始化为适当的值
            object sender = null; // TODO: 初始化为适当的值
            EventArgs e = null; // TODO: 初始化为适当的值
            target.button5_Click(sender, e);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///button6_Click 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Elementary Arithmetic.exe")]
        public void button6_ClickTest()
        {
            Form1_Accessor target = new Form1_Accessor(); // TODO: 初始化为适当的值
            object sender = null; // TODO: 初始化为适当的值
            EventArgs e = null; // TODO: 初始化为适当的值
            target.button6_Click(sender, e);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///button6_KeyDown 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Elementary Arithmetic.exe")]
        public void button6_KeyDownTest()
        {
            Form1_Accessor target = new Form1_Accessor(); // TODO: 初始化为适当的值
            object sender = null; // TODO: 初始化为适当的值
            KeyEventArgs e = null; // TODO: 初始化为适当的值
            target.button6_KeyDown(sender, e);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }
    }
}
