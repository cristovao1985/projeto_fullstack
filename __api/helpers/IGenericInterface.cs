using domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace helpers
{
    public interface IGenericInterface<T>
    {
        IEnumerable<T> list();
        T get(int id);
        Result delete(int id);
        Result update(int id);
    }
}
