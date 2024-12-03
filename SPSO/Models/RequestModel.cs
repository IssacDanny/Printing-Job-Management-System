using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SPSO.Models
{
    public class RequestModel
    {
        private int StudentId;
        private string StudentName;
        private int PrintingLocation; // C6 = 0, A4 = 1, Thư Viện = 2, A1 = 3
        private int PaperSize; // A1 = 0, A2 = 1, A3 = 2, A4 = 3, A5 = 4
        private int PrintType; // One-sided = 0, Double-sided = 1
        private int Quantity;
        private DateTime RequestDate;
        private TimeSpan RequestTime;

        [Required]
        public int studentId
        {
            get { return StudentId; }
            set { StudentId = value; }
            
        }

        [Required]
        [StringLength(100)]
        public string studentName
        {
            get { return StudentName; }
            set { StudentName = value; }
        }

        [Required] 
        [Range(0, 3, ErrorMessage = "The Location number must be either 0, 1, 2, 3")]
        public int printingLocation
        {
            get { return PrintingLocation; }
            set { PrintingLocation = value; }
        }

        [Required]
        [DisplayName("Khổ Giấy")]
        [Range(0, 4, ErrorMessage = "The PaperSize must be either 0, 1, 2, 3, 4")]
        public int paperSize
        {
            get { return PaperSize; }
            set { PaperSize = value; }
        }

        [Required]
        [Range(0, 1, ErrorMessage = "The PrintType must be either 0, 1")]
        public int printType
        {
            get { return PrintType; }
            set { PrintType = value; }
        }

        [Required]
        [DisplayName("Số Lượng")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
        public int quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }

        [Required]
        [DisplayName("Ngày Yêu Cầu")]
        public DateTime requestDate
        {
            get { return RequestDate; }
            set { RequestDate = value; }
        }

        [Required]
        [DisplayName("Thời Điểm Yêu Cầu")]
        public TimeSpan requestTime
        {
            get { return RequestTime; }
            set { RequestTime = value; }
        }
    }
}
