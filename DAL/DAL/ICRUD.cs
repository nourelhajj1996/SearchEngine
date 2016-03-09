using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    public interface ICRUD<T, K>
    {
        bool Create(T item);

        bool CreateAll(List<T> item_list);

        List<T> ReadAll();

        T Read(K id);

        bool Update(T item);

        bool Delete(K id);

        List<T> Search(string search);
    }
}
