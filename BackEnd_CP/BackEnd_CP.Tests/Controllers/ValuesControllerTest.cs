using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BackEnd_CP;
using BackEnd_CP.Controllers;

namespace BackEnd_CP.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Упорядочение
            UserController controller = new UserController();

            // Действие
            IEnumerable<string> result = controller.Get();

            // Утверждение
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Упорядочение
            UserController controller = new UserController();

            // Действие
            string result = controller.Get(5);

            // Утверждение
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Упорядочение
            UserController controller = new UserController();

            // Действие
            controller.Post("value");

            // Утверждение
        }

        [TestMethod]
        public void Put()
        {
            // Упорядочение
            UserController controller = new UserController();

            // Действие
            controller.Put(5, "value");

            // Утверждение
        }

        [TestMethod]
        public void Delete()
        {
            // Упорядочение
            UserController controller = new UserController();

            // Действие
            controller.Delete(5);

            // Утверждение
        }
    }
}
