using MaerskTask_BusinessRulesEngine;
using MaerskTask_BusinessRulesEngine.Comman.Intefaces;
using MaerskTask_BusinessRulesEngine.CommanUtility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace BusinessRuleEngineTest
{
    [TestClass]
    public class BusinessRuleEngineTests
    {
        private readonly ProcessEngine processEngine;
        private readonly Mock<ProcessEngine> mockprocessengine;
        private Mock<Response> mockResponce;
        private Mock<IProcessEngine> mockIprocessEngine; 
        public BusinessRuleEngineTests()
        {
            processEngine = new ProcessEngine();
            mockprocessengine = new Mock<ProcessEngine>();
            mockResponce = new Mock<Response>();
            mockIprocessEngine = new Mock<IProcessEngine>();

        }

        [TestMethod]
        public void TestMethod1()
        {
        }

        public void Test_Book_Success()
        {
            mockIprocessEngine.Setup(x => x.Process(null)).Returns(mockResponce.Object);
            var ret = processEngine.RunBusinessRuleEngine(PaymentType.BOOK);
            Assert.IsTrue(ret.Status == (int)Status.SUCCESS);
        }
        [TestMethod]
        public void Test_Physical_Product_Success()
        {
            mockIprocessEngine.Setup(x => x.Process(null)).Returns(mockResponce.Object);
            var ret = processEngine.RunBusinessRuleEngine(PaymentType.PHYSICAL_PRODUCT);
            Assert.IsTrue(ret.Status == (int)Status.SUCCESS);
        }


        [TestMethod]
        public void Test_Physical_Membership_Activate_Success()
        {
            mockIprocessEngine.Setup(x => x.Process(null)).Returns(mockResponce.Object);
            var ret = processEngine.RunBusinessRuleEngine(PaymentType.MEMBERSHIP_ACTIVATE);
            Assert.IsTrue(ret.Status == (int)Status.SUCCESS);
        }


        [TestMethod]
        public void Test_Physical_Membership_Upgrade_Success()
        {
            mockIprocessEngine.Setup(x => x.Process(null)).Returns(mockResponce.Object);
            var ret = processEngine.RunBusinessRuleEngine(PaymentType.MEMBERSHIP_UPGRADE);
            Assert.IsTrue(ret.Status == (int)Status.SUCCESS);
        }


        [TestMethod]
        public void Test_Physical_Membership_Video_Success()
        {
            mockIprocessEngine.Setup(x => x.Process(null)).Returns(mockResponce.Object);
            var ret = processEngine.RunBusinessRuleEngine(PaymentType.VIDEO);
            Assert.IsTrue(ret.Status == (int)Status.SUCCESS);
        }
      
    }
}
