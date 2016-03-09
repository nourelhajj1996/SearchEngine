using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    class TermsRepository : ICRUD<Terms, int>
    {
        public bool Create(Terms item)
        {
            throw new NotImplementedException();
        }

        public bool CreateAll(List<Terms> item_list)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Terms Read(int id)
        {
            throw new NotImplementedException();
        }

        public List<Terms> ReadAll()
        {
            throw new NotImplementedException();
        }

        public List<Terms> Search(string search)
        {
            throw new NotImplementedException();
        }

        public bool Update(Terms item)
        {
            throw new NotImplementedException();
        }
    }
}
