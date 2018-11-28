using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ForecastIO;

namespace BrioDevExercise.Helpers
{
    public static class DarkSkyGet
    {
        private static string key = "47dd4c596abbfb16bc6bd4be0ed3c661";
        public static ForecastIOResponse SyncGet()
        {
            var request = new ForecastIORequest(key, 43.4499376f, -79.7880999f, Unit.si);
            return request.Get();
        }

        public static ForecastIOResponse SyncGetLL(double lat, double lon)
        {
            var request = new ForecastIORequest(key, (float)lat, (float)lon, Unit.si);
            return request.Get();
        }
        public static async Task<ForecastIOResponse> AsyncGet()
        {
            var request = new ForecastIORequest(key, 43.4499376f, -79.7880999f, Unit.si);
            return await request.GetAsync();
        }
    }
}