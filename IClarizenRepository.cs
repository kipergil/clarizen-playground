using System.Collections.Generic;
using Ekin.Clarizen;

namespace BBHPro.Playground
{
    public interface IClarizenRepository<T> where T : EntityId
    {
        T GetById(string id);
        bool Insert(T entity);
        bool Update(T entity);
        bool Upsert(T entity);
        bool Delete(T entity);
        bool DeleteById(string id);
        List<T> LoadAll(string customCondition = "", bool readFromFile = false, bool useCache = false, int cacheDuration = 60);
    }
}
