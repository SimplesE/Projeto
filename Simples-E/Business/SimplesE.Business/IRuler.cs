using SimplesE.Model.Core;
using SimplesE.Model.Service;
using System;
using System.Collections.Generic;

namespace SimplesE.Business
{
    public interface IRuler<T>
    {
        T Insert(T item);

        IEnumerable<T> GetAll();
    }
}
