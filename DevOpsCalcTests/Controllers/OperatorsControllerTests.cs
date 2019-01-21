using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevOpsCalc.Models;
using DevOpsCalc.Controllers;
using System.Web.Mvc;
  
namespace DevOpsCalc.Controllers.Tests
{
    [TestClass()]
    public class OperatorsControllerTests
    {
        [TestMethod()]
        public void TestAdd()
        {
            // arrange

 
            OperatorsModel model = new OperatorsModel {FirstNum = 10.0, SecondNum = 2.0};
            OperatorsController controller = new OperatorsController();
            double expected = 12.0;

            // act
             ActionResult result = controller.Index(model, "add");
            // assert
            Assert.AreEqual(expected, model.Answer);
        }

        [TestMethod()]
        public void TestSubtract()
        {
            // arrange
            OperatorsModel model = new OperatorsModel { FirstNum = 10.0, SecondNum = 2.0 };
            OperatorsController controller = new OperatorsController();
            double expected = 8.0;

            // act
            ActionResult result = controller.Index(model, "subtract");
            // assert
            Assert.AreEqual(expected, model.Answer);
        }

    }
}