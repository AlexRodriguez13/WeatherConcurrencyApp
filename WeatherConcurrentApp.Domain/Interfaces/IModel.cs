using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherConcurrentApp.Domain.Interfaces
{
   public interface IModel<T>
    {
        void Add(T t);
        void Delete(T t);
        bool Delete(int id);
        List<T> Read();
    }
}
