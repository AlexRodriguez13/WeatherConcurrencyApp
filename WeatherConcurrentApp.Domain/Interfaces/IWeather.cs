using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using WeatherConcurrentApp.Domain.Entities;

namespace WeatherConcurrentApp.Domain.Interfaces
{
   public interface IWeather: IModel<OpenWeather>
    {
        List<OpenWeather> findWByCity(Expression<Func<OpenWeather, bool>> where);
    }
}
