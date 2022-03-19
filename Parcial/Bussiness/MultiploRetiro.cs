using Parcial.Models;
using Parcial.Services;

namespace Parcial.Bussiness
{
    public class MultiploRetiro : IMultiploRetiro
    {
        public double RetiroMultiplo(Multiplo multiplo)
        {
            return ( multiplo.Monto % 5);
        }
    }
}
