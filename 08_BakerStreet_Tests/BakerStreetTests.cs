using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using _08_BakerStreetRepository;

namespace _08_BakerStreet_Tests
{
    [TestClass]
    public class BakerStreetTests
    {
        [TestMethod]
        public void ProductContentObject()
        {
            ProductContent content = new ProductContent();

            content.CustomerName = "Ben";
            string expected = "Ben";

            Assert.AreEqual(expected, content.CustomerName);

            ProductContent contentTwo = new ProductContent("Blue Bread", "Ben", 16, 20.0m, BakeType.Bread);

            string expectedProduct = "Blue Bread";
            string expectedName = "Ben";
            int expectedOrderSize = 16;
            decimal expectedCost = 20.0m;
            BakeType expectedType = BakeType.Bread;

            Assert.AreEqual(expectedProduct, contentTwo.ProductName);
            Assert.AreEqual(expectedName, contentTwo.CustomerName);
            Assert.AreEqual(expectedOrderSize, contentTwo.OrderBatchSize);
            Assert.AreEqual(expectedCost, contentTwo.OrderCost);
            Assert.AreEqual(expectedType, contentTwo.Type);
        }

        [TestMethod]
        public void AddToList_AddStreamingContentObject()
        {
            Repo productRepo = new Repo();
            List<ProductContent> content = productRepo.GetProductList();

            ProductContent contents = new ProductContent("Black Bread", "Sally", 16, 20.0m, BakeType.Bread);
            ProductContent contentTwo = new ProductContent("Blue Bread", "Silly Billy", 10, 10.0m, BakeType.Bread);

            int expected = 2;

            productRepo.AddToList(contents);
            productRepo.AddToList(contentTwo);

            int actual = content.Count;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void RemoveProductContentsFromListTest()
        {
            Repo productRepo = new Repo();
            List<ProductContent> content = productRepo.GetProductList();

            ProductContent contents = new ProductContent("Black Bread", "Sally", 16, 20.0m, BakeType.Bread);
            ProductContent contentTwo = new ProductContent("Blue Bread", "Silly Billy", 10, 10.0m, BakeType.Bread);

            int expected = 1;

            productRepo.AddToList(contents);
            productRepo.AddToList(contentTwo);

            productRepo.RemoveProductContentFromList("Sally");

            int actual = content.Count;
            Assert.AreEqual(expected, actual);
        }
    }
}
