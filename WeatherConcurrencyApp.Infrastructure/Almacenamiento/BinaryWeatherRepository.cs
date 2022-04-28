using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherConcurrencyApp.Infrastructure.Almacenamiento
{
   public class BinaryWeatherRepository
    {
        private RAFContext Context;
        private const int Size = 220;

        public BinaryWeatherRepository()
        {
            this.Context = new RAFContext("Clima", Size);
        }

        //public void Add(Empleado t)
        //{

        //    Context.Create<Empleado>(t);
        //}

        //public void Delete(Empleado t)
        //{
        //    Context.Delete(t.Id);
        //}

        //public bool Delete(int id)
        //{
        //    return Context.Delete(id);
        //}

        //public List<Empleado> Read()
        //{
        //    return Context.GetAll<Empleado>();
        //}

        //public Empleado GetById(int id)
        //{
        //    return Context.Get<Empleado>(id);
        //}

        //public void Update(Empleado Empleado)
        //{
        //    Context.Update<Empleado>(Empleado);
        //}

        public List<OpenWeather> findWByCity(Expression<Func<OpenWeather, bool>> where)
        {
            return Context.Find<OpenWeather>(where);
        }

        public void Add(OpenWeather t)
        {
            Context.Create<OpenWeather>(t);
        }

        public void Delete(OpenWeather t)
        {
            Context.Delete(t.Id);
        }

        public List<OpenWeather> Read()
        {
            return Context.GetAll<OpenWeather>();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

