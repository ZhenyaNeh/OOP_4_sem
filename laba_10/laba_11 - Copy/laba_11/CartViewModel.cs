using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace laba_11
{
    public class CartViewModel
    {
        public Cart Cart { get; set; }
        public CartViewModel()
        {
            Cart = new Cart();
        }

        public void AddProductToCart(string name, int hourse, string teacher, int lisenes)
        {
            var product = new Course { Name = name, CountHourse = hourse, NameTeacher = teacher, QuantityLisens = lisenes };
            Cart.AddProduct(product);
        }

        public void RemoveProductFromCart(string name)
        {
            Cart.RemoveProduct(name);
        }
    }
}
