using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SPSO.Models;
using System.ComponentModel.DataAnnotations;
namespace SPSO._Repositories
{
    public class OwnerRepository : BaseRepository, IOwnerRepository
    {
        //Constructor
        public OwnerRepository(string connectionString) 
        { 
            this.connectionString = connectionString;
        }
        //Methods
        public void Edit(OwnerModel ownerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE TheOwner SET 
                                        last_name =@LName, first_name = @FName, 
                                        email = @Email, phone_number = @PNumber 
                                        WHERE update_mark = 'UI'";

                command.Parameters.Add("@LName", SqlDbType.NVarChar).Value = ownerModel.LastName;
                command.Parameters.Add("@FName", SqlDbType.NVarChar).Value = ownerModel.FirstName;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = ownerModel.Email;
                command.Parameters.Add("@PNumber", SqlDbType.NVarChar).Value = ownerModel.PhoneNumber;
                command.ExecuteNonQuery();
            }
        }

        public List<OwnerModel> GetData()
        {
            var ownerInfo = new List<OwnerModel>();
            using(var connection = new SqlConnection(connectionString))
            using(var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM TheOwner";
                using (var reader = command.ExecuteReader()) 
                {
                    while (reader.Read())
                    {
                        var ownerModel = new OwnerModel();
                        ownerModel.LastName = reader["last_name"].ToString();
                        ownerModel.FirstName = reader["first_name"].ToString();
                        ownerModel.Email = reader["email"].ToString();
                        ownerModel.PhoneNumber = reader["phone_number"].ToString();
                        ownerInfo.Add(ownerModel);
                    }

                }
            }
            return ownerInfo;
        }
    }
}
