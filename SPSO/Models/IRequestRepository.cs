using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPSO.Models
{
    public interface IRequestRepository
    {
        void Add(RequestModel requestModel);
        IEnumerable<RequestModel> GetAll();
        IEnumerable<RequestModel> GetByValue(string value); //Searchs
    }
}
