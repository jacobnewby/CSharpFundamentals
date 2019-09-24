using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_BakerStreetRepository;

namespace _08_BakerStreetRepository
{
    public class Repo
    {
        List<ProductContent> _productList = new List<ProductContent>();

        public void AddToList(ProductContent content)
        {
            _productList.Add(content);
        }

        public List<ProductContent> GetProductList()
        {
            return _productList;
        }

        public void RemoveProductContentFromList(string customerName)
        {
            foreach (ProductContent contents in _productList)
            {
                if (contents.CustomerName == customerName)
                {
                    _productList.Remove(contents);
                    break;
                }
            }
        }

        public void SeedList()
        {
            ProductContent contents = new ProductContent("Black Bread", "Sally", 16, BakeType.Bread);
            ProductContent contentTwo = new ProductContent("Blue Bread", "Silly Billy", 10, BakeType.Bread);

            AddToList(contents);
            AddToList(contentTwo);
        }
    }
}
