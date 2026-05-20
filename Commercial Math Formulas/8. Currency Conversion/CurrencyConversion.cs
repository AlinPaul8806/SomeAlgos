using System;
using System.Collections.Generic;

namespace CommercialMathFormulas.CurrencyConversion
{
    public class CurrencyConversion
    {
        // A simple in-memory exchange rate store. In practice, you'd fetch from an API.
        private readonly Dictionary<string, decimal> _exchangeRates = new()
        {
            ["USD"] = 1.00m,
            ["EUR"] = 0.92m,
            ["GBP"] = 0.79m,
            ["JPY"] = 148.50m
        };


        // Converts an amount from one currency to another.
        public decimal Convert(decimal amount, string fromCurrency, string toCurrency)
        {
            if (!_exchangeRates.ContainsKey(fromCurrency) || !_exchangeRates.ContainsKey(toCurrency))
            {
                throw new ArgumentException("Unsupported currency.");
            } 

            // Convert to USD first (as base), then to target
            decimal inUsd = amount / _exchangeRates[fromCurrency];
            return inUsd * _exchangeRates[toCurrency];
        }


        // Updates an exchange rate (e.g., from an API).
        public void SetExchangeRate(string currency, decimal rate)
        {
            _exchangeRates[currency] = rate;
        }
    }
}