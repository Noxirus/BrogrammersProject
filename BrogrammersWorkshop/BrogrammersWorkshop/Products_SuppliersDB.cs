using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrogrammersWorkshop
{
    public class Products_SuppliersDB
    {
        //retrieve a list of packages products and suppliers for the table
        public static List<PackagesProductInfo> GetProductsSuppliers()
        {
            List<PackagesProductInfo> ProdSup = new List<PackagesProductInfo>(); //empty list
            PackagesProductInfo prodSup; // aux for reading

            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "SELECT ProductSupplierId, ProdName, SupName " +
                               "FROM Products_Suppliers AS ps join Suppliers AS s " +
                               "ON ps.SupplierId = s.SupplierId join Products AS p " +
                               "ON ps.ProductId = p.ProductId " +
                               "ORDER BY ProductSupplierId";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        prodSup = new PackagesProductInfo();
                        prodSup.ProductSupplierId = (int)reader["ProductSupplierId"];
                        prodSup.ProdName = reader["ProdName"].ToString();
                        prodSup.SupName = reader["SupName"].ToString();
                        ProdSup.Add(prodSup);
                    }
                }
            }
            return ProdSup;
        }
        // retrieve a single package product and supplier data
        public static Products_Suppliers GetProdSup(int ProductSupplierId)
        {
            //creating the object to store the orders information
            Products_Suppliers prodSup = null;
            //opening a connection to SQL and inputting a query to access the specific orderIDs information
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "SELECT * " +
                                "FROM Products_Suppliers " +
                                "WHERE ProductSupplierId = @ProductSupplierId";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PackageID", ProductSupplierId);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        //store values into the order object
                        if (reader.Read())
                        {
                            prodSup = new Products_Suppliers();
                            prodSup.ProductSupplierId = (int)reader["ProductSupplierId"];
                            prodSup.ProductId = (int)reader["ProductId"];
                            prodSup.SupplierId = (int)reader["SupplierId"];      
                        }
                    }
                }
            }
            return prodSup;
        }
        // add an item to the table
        public static int AddProdSup(Products_Suppliers ps)
        {
            int productsupID = -1;
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string insertStatement =
                    "INSERT INTO Products_Suppliers(ProductId, SupplierId) " +
                    "VALUES(@ProductId, @SupplierId)";
                using (SqlCommand cmd = new SqlCommand(insertStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@ProductId", ps.ProductId);
                    cmd.Parameters.AddWithValue("@SupplierId", ps.SupplierId);
                    connection.Open();
                    cmd.ExecuteNonQuery(); // INSERT statement
                    //productsupID = (int)cmd.ExecuteScalar(); // fixes problem of retrieving ID
                }
            }
            return productsupID;
        }
        // delete item in table
        public static bool DeleteProdSup(Products_Suppliers ps)
        {
            int count = 0; // how many rows deleted
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string deleteStatement =
                    "DELETE FROM Products_Suppliers " +
                    "WHERE ProductSupplierId = @ProductSupplierId " + // to identify record
                    "AND ProductId = @ProductId " + // the remaining conditions - for optimistic concurrency
                    "AND SupplierId = @SupplierId";

                using (SqlCommand cmd = new SqlCommand(deleteStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@ProductSupplierId", ps.ProductSupplierId);
                    cmd.Parameters.AddWithValue("@ProductId", ps.ProductId);
                    cmd.Parameters.AddWithValue("@SupplierId", ps.SupplierId);
                    connection.Open();
                    count = cmd.ExecuteNonQuery(); // DELETE statement return # affected rows
                }
            }
            return (count > 0);
        }
        // update item in table
        public static bool UpdateProdSup(Products_Suppliers oldps, Products_Suppliers newps)
        {
            int count; // how many rows updated
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string updateStatement =
                    "UPDATE Products_Suppliers SET " +
                    " ProductId = @newProductId, " +
                    " SupplierId = @SupplierId, " +
                    "WHERE ProductSupplierId = @ProductSupplierId " + // to identify record
                    " AND ProductId = @oldProductId " + // remainig conditions - otimistic concurrency
                    " AND SupplierId = @oldSupplerId";
                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@newProductId", newps.ProductId);
                    cmd.Parameters.AddWithValue("@newSupplierId", newps.SupplierId);
                    cmd.Parameters.AddWithValue("@ProductSupplierId", oldps.ProductSupplierId);
                    cmd.Parameters.AddWithValue("@oldProductId", oldps.ProductId);
                    cmd.Parameters.AddWithValue("@oldSupplierId", oldps.SupplierId);
                    connection.Open();
                    count = cmd.ExecuteNonQuery(); // returns how many rows updated
                }
            }
            return (count > 0);
        }
    }
}