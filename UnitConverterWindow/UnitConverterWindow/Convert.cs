using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConverterWindow
{
    class Convert
    {
        // NOTE(bora): Permutation(mm, cm, m, km, in, ft, mi) 
        private static Dictionary<string, double> conversionTable = new Dictionary<string, double>() {
            {"cm_mm", 1000},
            {"m_mm", 1000*1000},
            {"km_mm", 1000*1000*1000},
            {"m_cm", 1000},
            {"km_cm", 1000*1000},
            {"km_m", 1000},

            {"ft_in", 12},
            {"mi_in", 63360.23622},
            {"mi_ft", 5280.019685},

            {"in_mm", 25.4},    {"in_cm", 2.54},   {"in_m", 0.0254},  {"in_km", 0.0000254},
            {"ft_mm", 304.8},   {"ft_cm", 30.48},  {"ft_m", 0.3048},  {"ft_km", 0.0003048},
            {"mi_mm", 1609350}, {"mi_cm", 160935}, {"mi_m", 1609.35}, {"mi_km", 1.60935},
        };

        public static double DoConversiton(string unit1, string unit2, double value)
        {
            string key = String.Format("{0}_{1}", unit1, unit2);
            string reverseKey = String.Format("{1}_{0}", unit1, unit2);

            double result;

            if(conversionTable.ContainsKey(key))
            {
                result = value*conversionTable[key];
            }
            else if(conversionTable.ContainsKey(reverseKey))
            {
                result = value/conversionTable[reverseKey];
            } else if( unit1 == unit2)
            {
                result = value;
            }
            else
            {
                throw new NotSupportedException("Specified units are not convertible: [" + unit1 + ", " + unit2 + "]");
            }

            return result;
        }
    }
}
