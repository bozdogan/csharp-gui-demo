using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CurrencyConverter
{
    class Currency
    {
        public readonly static Dictionary<string, float> exchangeRates =
        new Dictionary<string, float>() {
            {"USD_TRY", 8.6923f}, {"TRY_USD", 1/8.6923f},
            {"USD_EUR", 0.8475f}, {"EUR_USD", 1/0.8475f},
            {"EUR_TRY", 10.2387f}, {"TRY_EUR", 1/10.2387f}
        };

        public readonly static Hashtable symbols = new Hashtable() {
            {"USD", "$"},
            {"TRY", "₺"},
            {"EUR", "€"}
        };

        public readonly static Hashtable longNames = new Hashtable() {
            {"USD", "US Dollars"},
            {"TRY", "Turkish Lira"},
            {"EUR", "Euro"}
        };
    }
}
