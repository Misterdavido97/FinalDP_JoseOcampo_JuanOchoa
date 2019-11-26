using FinalDP_JoseOcampo_JuanOchoa.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalDP_JoseOcampo_JuanOchoa.Core.Services
{
    public interface IQuadraticFunctionService
    {
        QuadraticFunctionResult Calculate(double a, double b, double c);
    }
}
