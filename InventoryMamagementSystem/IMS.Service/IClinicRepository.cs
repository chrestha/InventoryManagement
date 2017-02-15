using System;
using System.Collections.Generic;
using IMS.Data;
using IMS.Model;

namespace IMS.Service
{
    public interface IClinicRepository: IDisposable
    {
        Clinic GetById(Int32 id);
        List<Clinic> GetAll();
        void Insert(Clinic model);
        void Update(Clinic model);
        void Delete(Clinic model);
        IEnumerable<Clinic> Find(Func<Clinic, bool> predicate);

    }
}
