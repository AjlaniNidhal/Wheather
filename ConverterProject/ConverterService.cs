using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.ConverterProject
{
    class ConverterService : IDisposable
    {
        public double GetFernhaitFromCelcius(double CL)
        {
            return (CL * 9.0f / 5.0f) + 32;
        }

        public double GetCelciusFromFernhait(double FR)
        {
            return (FR - 32) * 5.0f / 9.0f;
        }

        public void Dispose()
        {
            //Commit Dispose
            //Dispose();
            //GC.SuppressFinalize(this);
        }
    }
}
