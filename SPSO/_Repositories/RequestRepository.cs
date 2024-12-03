using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SPSO.Models;
using System.Drawing.Printing;

namespace SPSO._Repositories
{
    public class RequestRepository : BaseRepository, IRequestRepository
    {
        //Constructor
        public RequestRepository(string connectionString) 
        { 
            this.connectionString = connectionString;
        }
        //Methods
        public void Add(RequestModel requestModel)
        {
            var requestList = new List<RequestModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Requests " +
                                      "VALUES(@student_id, @student_name, " +
                                      "@paper_size, @print_type, " +
                                      "@quantity, @RequestDate, " +
                                      "@RequestTime, @PrintingLocation)";

                command.Parameters.Add("@student_id", SqlDbType.Int).Value = requestModel.studentId;
                command.Parameters.Add("@student_name", SqlDbType.VarChar).Value = requestModel.studentName;
                command.Parameters.Add("@paper_size", SqlDbType.VarChar).Value = GetPaperSize(requestModel.paperSize);
                command.Parameters.Add("@print_type", SqlDbType.VarChar).Value = GetPrintType(requestModel.printType);
                command.Parameters.Add("@quantity", SqlDbType.Int).Value = requestModel.quantity;
                command.Parameters.Add("@RequestDate", SqlDbType.Date).Value = requestModel.requestDate;
                command.Parameters.Add("@RequestTime", SqlDbType.Time).Value = requestModel.requestTime;
                command.Parameters.Add("@PrintingLocation", SqlDbType.Int).Value = requestModel.printingLocation;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<RequestModel> GetAll()
        {
            var requestList = new List<RequestModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Requests ORDER BY RequestDate DESC, RequestTime DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var requestModel = new RequestModel();
                        requestModel.studentId = (int)reader["student_id"];
                        requestModel.studentName = reader["student_name"].ToString();
                        requestModel.printingLocation = (int)reader["printingLocation"];
                        requestModel.paperSize = GetPaperSizeValue(reader["paper_size"].ToString());
                        requestModel.printType = GetPrintTypeValue(reader["print_type"].ToString());
                        requestModel.quantity = (int)reader["quantity"];
                        requestModel.requestDate = (DateTime)reader["RequestDate"];
                        requestModel.requestTime = (TimeSpan)reader["RequestTime"];
                        requestList.Add(requestModel);
                    }
                }
            }
            return requestList;
        }

        public IEnumerable<RequestModel> GetByValue(string value)
        {
            var requestList = new List<RequestModel>();
            DateTime requestDate = DateTime.TryParse(value, out _)?Convert.ToDateTime(value) : DateTime.MaxValue;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Requests 
                                        WHERE RequestDate=@Date 
                                        ORDER BY RequestDate DESC, RequestTime DESC ";
                command.Parameters.Add("@Date", SqlDbType.Date).Value = requestDate;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var requestModel = new RequestModel();
                        requestModel.studentId = (int)reader["student_id"];
                        requestModel.studentName = reader["student_name"].ToString();
                        requestModel.printingLocation = (int)reader["printingLocation"];
                        requestModel.paperSize = GetPaperSizeValue(reader["paper_size"].ToString());
                        requestModel.printType = GetPrintTypeValue(reader["print_type"].ToString());
                        requestModel.quantity = (int)reader["quantity"];
                        requestModel.requestDate = (DateTime)reader["RequestDate"];
                        requestModel.requestTime = (TimeSpan)reader["RequestTime"];
                        requestList.Add(requestModel);
                    }
                }
            }
            return requestList;
        }

        private int GetPaperSizeValue(string paperSize)
        {
            if (paperSize == "A1")
                return 0;
            else if (paperSize == "A2")
                return 1;
            else if (paperSize == "A3")
                return 2;
            else if (paperSize == "A4")
                return 3;
            else if (paperSize == "A5")
                return 4;
            else
                throw new InvalidOperationException("Invalid paper size selected.");
        }

        private string GetPaperSize(int paperSizeValue)
        {
            if (paperSizeValue == 0)
                return "A1";
            else if (paperSizeValue  == 1)
                return "A2";
            else if (paperSizeValue  == 2)
                return "A3";
            else if (paperSizeValue  == 3)
                return "A4";
            else if (paperSizeValue  == 4)
                return "A5";
            else
                throw new InvalidOperationException("Invalid paper size value selected.");
        }

        private int GetPrintTypeValue(string printType)
        {
            if (printType == "One-sided")
                return 0;
            else if (printType == "Double-sided")
                return 1;
            else
                throw new ArgumentException("Invalid print type.");
        }

        private string GetPrintType(int printTypeValue)
        {
            if (printTypeValue == 0)
                return "One-sided";
            else if (printTypeValue == 1)
                return "Double-sided";
            else
                throw new ArgumentException("Invalid print type value.");
        }

    }
}
