using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPSO.Models
{
    public interface IOwnerRepository
    {
        void Edit(OwnerModel ownerModel);
        List<OwnerModel> GetData();
    }
}
