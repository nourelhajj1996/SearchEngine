using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine.DAL
{
    class TermsRepository : ICRUD<Terms, int>
    {
        public void Create(Terms item)
        {
            using (SearchEngineDBEntities db = new SearchEngineDBEntities())
            {
                db.Terms.Add(item);
                db.SaveChanges();
            }
        }

        public void CreateAll(List<Terms> item_list)
        {
            using (SearchEngineDBEntities db = new SearchEngineDBEntities())
            {
                db.Terms.AddRange(item_list);
                db.SaveChanges();
            }
        }

        public Terms Read(int id)
        {
            using (SearchEngineDBEntities db = new SearchEngineDBEntities())
            {
                return db.Terms.SingleOrDefault(term => term.id == id);
            }
        }

        public List<Terms> ReadAll()
        {
            using (SearchEngineDBEntities db = new SearchEngineDBEntities())
            {
                return db.Terms.ToList();
            }
        }

        public List<Terms> Search(string search)
        {
            throw new NotImplementedException();
        }
    }
}
