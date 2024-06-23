using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace laba_11
{
    public class Cart
    {
        public List<Course> Products { get; set; }

        public Cart()
        {
            Products = new List<Course>();
        }

        public void AddProduct(Course product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(string name)
        {
            foreach (Course p in Products)
            {
                if (p.Name == name/*product.Name && p.CountHourse == product.CountHourse && p.NameTeacher== product.NameTeacher && p.QuantityLisens == product.QuantityLisens*/)
                {
                    Products.Remove(p);
                    MessageBox.Show("All Correct");
                    return;
                }
            }

            MessageBox.Show("This not");
        }
    }
}
