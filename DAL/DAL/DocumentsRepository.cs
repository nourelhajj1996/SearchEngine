using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine.DAL
{
    public class DocumentsRepository : ICRUD<Documents, int>
    {
        public void Create(Documents item)
        {
            using (SearchEngineDBEntities db = new SearchEngineDBEntities())
            {
                db.Documents.Add(item);
                db.SaveChanges();
            }
        }

        public void CreateAll(List<Documents> item_list)
        {
            using (SearchEngineDBEntities db = new SearchEngineDBEntities())
            {
                db.Documents.AddRange(item_list);
                db.SaveChanges();
            }
        }

        public Documents Read(int id)
        {
            using (SearchEngineDBEntities db = new SearchEngineDBEntities())
            {
                return db.Documents.SingleOrDefault(doc => doc.id == id);
            }
        }

        public List<Documents> ReadAll()
        {
            using (SearchEngineDBEntities db = new SearchEngineDBEntities())
            {
                return db.Documents.ToList();
            }
        }

        public List<Documents> Search(string search)
        {
            throw new NotImplementedException();
        }
    }
}
