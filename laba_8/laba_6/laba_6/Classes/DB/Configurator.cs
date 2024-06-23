using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace laba_6
{
    public static class Configurator
    {
        public static void AddManyItems()
        {
            var list = CreatorItems.list_PC;
            foreach (var el in list)
            {

                using (var item = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString()))
                {
                    item.Open();

                    string sqlQuery = "insert Configurators (Image, Price, CPU, GPU, Description_En, Description_Ru)" +
                        "values (@Img, @Price, @CPU, @GPU, @DescriptionEn, @DescriptionRu)";
                    using (var command = new SqlCommand(sqlQuery, item))
                    {

                        command.Parameters.AddWithValue("@Img", el.Image);
                        command.Parameters.AddWithValue("@Price", el.Price);
                        command.Parameters.AddWithValue("@CPU", el.CPU);
                        command.Parameters.AddWithValue("@GPU", el.GPU);
                        command.Parameters.AddWithValue("@DescriptionEn", el.Description_En);
                        command.Parameters.AddWithValue("@DescriptionRu", el.Description_Ru);

                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public static void RemoveItem(double price)
        {
            using (var item = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString()))
            {
                item.Open();
                SqlTransaction transaction = item.BeginTransaction();

                string sqlQuery = "delete Configurators where Price = @price";
                using (var command = new SqlCommand(sqlQuery, item, transaction))
                {
                    command.Parameters.AddWithValue("@price", price);
                    command.ExecuteNonQuery();

                    if(price == null)
                    {
                        transaction.Rollback();
                        return;
                    }

                    transaction.Commit();
                }
            }
        }

        public static void AddItem(string source, double price, string CPU, string GPU, string description_EN, string description_RU)
        {
            using (var item = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString()))
            {
                item.Open();

                string sqlQuery = "insert Configurators (Image, Price, CPU, GPU, Description_En, Description_Ru)" +
                    "values (@Img, @Price, @CPU, @GPU, @DescriptionEn, @DescriptionRu)";
                using (var command = new SqlCommand(sqlQuery, item))
                {

                    command.Parameters.AddWithValue("@Img", source);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@CPU", CPU);
                    command.Parameters.AddWithValue("@GPU", GPU);
                    command.Parameters.AddWithValue("@DescriptionEn", description_EN);
                    command.Parameters.AddWithValue("@DescriptionRu", description_RU);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
