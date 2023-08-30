using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace CrmSystem.BL.Model.Tests
{
    [TestClass()]
    public class ComputerModelTests
    {
        [TestMethod()]
        public void ComputerModelTest()
        {
            var model = new ComputerModel();
            model.Start();

            Thread.Sleep(1000);
        }
    }
}