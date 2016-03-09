using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    public class DocumentsRepository : ICRUD<Documents, int>
    {
        public bool Create(Documents item)
        {
            throw new NotImplementedException();
        }

        public bool CreateAll(List<Documents> item_list)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Documents Read(int id)
        {
            throw new NotImplementedException();
        }

        public List<Documents> ReadAll()
        {
            throw new NotImplementedException();
        }

        public List<Documents> Search(string search)
        {
            throw new NotImplementedException();
        }

        public bool Update(Documents item)
        {
            throw new NotImplementedException();
        }
    }
}
