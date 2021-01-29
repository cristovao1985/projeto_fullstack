using api.domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace api.Helper
{
    public interface IGenericInterface<T>
    {
        IEnumerable<T> list();
        T get(int id);
        Result delete(int id);
        Result update(int id);
    }
}
