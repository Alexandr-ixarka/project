using ProjectTaxis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxis.BLL.Iterfaces
{
    public interface ICarSearchable
    {
        IEnumerable<Car> Search(SearchCarModel model);
    }
}
