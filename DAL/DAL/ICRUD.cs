using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine.DAL
{
    public interface ICRUD<T, K>
    {
        void Create(T item);

        void CreateAll(List<T> item_list);

        List<T> ReadAll();

        T Read(K id);

        List<T> Search(string search);
    }
}
