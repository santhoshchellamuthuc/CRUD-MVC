using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanthoshLibrary
{
    public interface ILocationRepository
    {
        public IEnumerable<LocationEntity> Showall();
        public void Insert(LocationEntity name); 
    }
}
