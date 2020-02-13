using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrogrammersWorkshop
{
    public class Packages_Products_SuppliersDB
    {
        //retrieve a list of packages products and suppliers for the table
        public static List<PackagesProductInfo> GetPackProductsSuppliers()
        {
            List<PackagesProductInfo> packProdSup = new List<PackagesProductInfo>(); //empty list
            PackagesProductInfo pkgInfo; // aux for reading

            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "SELECT PackageId, SupName, ProdName " +
                               "FROM Packages_Products_Suppliers AS pps JOIN Products_Suppliers AS ps " +
                               "ON pps.ProductSupplierId = ps.ProductSupplierId " +
                               "join Suppliers AS sup " +
                               "ON ps.SupplierId = sup.SupplierId " +
                               "join Products AS p " +
                               "ON ps.ProductId = p.ProductId " +
                               "ORDER BY PackageId";
                
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        pkgInfo = new PackagesProductInfo();
                        pkgInfo.PackageId = (int)reader["PackageId"];
                        pkgInfo.SupName = reader["SupName"].ToString();
                        pkgInfo.ProdName = reader["ProdName"].ToString();
                        packProdSup.Add(pkgInfo);
                    }
                }
            }
            return packProdSup;
        }
        // retrieve a single package product and supplier data
        public static Packages_Products_Suppliers GetPackProdSup(int PackageID)
        {
            //creating the object to store the orders information
            Packages_Products_Suppliers pkgProdSup = null;
            //opening a connection to SQL and inputting a query to access the specific orderIDs information
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "SELECT * " +
                                "FROM Packages " +
                                "WHERE PackageID = @PackageID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PackageID", PackageID);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        //store values into the order object
                        if (reader.Read())
                        {
                            pkgProdSup = new Packages_Products_Suppliers();
                            pkgProdSup.PackageId = (int)reader["PackageId"];
                            pkgProdSup.ProductSupplierId = (int)reader["ProductSupplierId"];
                        }
                    }
                }
            }
            return pkgProdSup;
        }
        // add item to table
        public static int AddPackProdSup(Packages_Products_Suppliers pps)
        {
            int packageID = -1;
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string insertStatement =
                    "INSERT INTO Packages_Products_Suppliers(ProductSupplierId) " +
                    "VALUES(@ProductSupplierId)";
                using (SqlCommand cmd = new SqlCommand(insertStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@ProductSupplierId", pps.ProductSupplierId);

                    connection.Open();
                    cmd.ExecuteNonQuery(); // INSERT statement
                   // packageID = (int)cmd.ExecuteScalar(); // Its either nonquery or scalar, check this
                }
            }

            return packageID;
        }
        // delete item from table
        public static bool DeletePackProdSup(Packages_Products_Suppliers pps)
        {
            int count = 0; // how many rows deleted
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string deleteStatement =
                    "DELETE FROM Packages_Products_Suppliers " +
                    "WHERE PackageId = @PackageId " + // to identify record
                    "AND ProductSupplierId = @ProductSupplierId"; // the remaining conditions - for optimistic concurrency

                using (SqlCommand cmd = new SqlCommand(deleteStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@PackageId", pps.PackageId);
                    cmd.Parameters.AddWithValue("@ProductSupplierId", pps.ProductSupplierId);
                    connection.Open();
                    count = cmd.ExecuteNonQuery(); // DELETE statement return # affected rows
                }
            }
            return (count > 0);
        }
        // update table
        public static bool UpdatePackProdSup(Packages_Products_Suppliers oldpps, Packages_Products_Suppliers newpps)
        {
            int count; // how many rows updated
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string updateStatement =
                    "UPDATE Packages_Products_Suppliers SET " +
                    "ProductSupplierId = @newProductSupplierId, " +
                    "WHERE PackageId = @PackageId " + // to identify record
                    "AND ProductSupplierId = @oldProductSupplierId"; // remainig conditions - otimistic concurrency
                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@newProductSupplierId", newpps.ProductSupplierId);
                    cmd.Parameters.AddWithValue("@PackageId", oldpps.PackageId);
                    cmd.Parameters.AddWithValue("@oldProductSupplierId", oldpps.ProductSupplierId);
                    connection.Open();
                    count = cmd.ExecuteNonQuery(); // returns how many rows updated
                }
            }
            return (count > 0);
        }
    }
}