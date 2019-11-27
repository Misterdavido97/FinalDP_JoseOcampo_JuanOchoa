using FinalDP_JoseOcampo_JuanOchoa.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalDP_JoseOcampo_JuanOchoa.Core.Services
{
    public class QuadraticFunctionService : IQuadraticFunctionService
    {

        public QuadraticFunctionResult Calculate(double a, double b, double c)
        {
            try
            {
                double RootContent = (Math.Pow(b, 2) - (4 * a * c));
                double Root = Math.Sqrt(RootContent);
                double PositiveNumerator = -b + Root;
                double NegativeNumerator = -b - Root;
                double Denominator = (2 * a);
                if (Denominator == 0)
                {
                    return new QuadraticFunctionResult()
                    {
                        X1 = 0,
                        X2 = 0
                    };
                }

                double X1 = PositiveNumerator / Denominator;
                double X2 = NegativeNumerator / Denominator;

                QuadraticFunctionResult result = new QuadraticFunctionResult()
                {
                    X1 = X1,
                    X2 = X2
                };

                return result;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

    }
}
