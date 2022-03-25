using System;

namespace Task_3
{
    delegate double DelegateConvertTemperature(double a);
    class TemperatureConverterImp
    {
        public double CelsiusToFahrenheit(double degC) => degC * 9 / 5.0 + 32;
        public double FahrenheitToCelsius(double degF) => (degF - 32) * 5 / 9.0;
    }
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureConverterImp temperatureConverterImp = new();
            DelegateConvertTemperature delegateConvertTemperature = temperatureConverterImp.CelsiusToFahrenheit;
            delegateConvertTemperature += temperatureConverterImp.FahrenheitToCelsius;
            double temp = 25;
            foreach (var @delegate in delegateConvertTemperature.GetInvocationList())
            {
                var method = (DelegateConvertTemperature) @delegate;
                Console.WriteLine($"Temp = {temp = method(temp)} " + (method.Method.Name == "CelsiusToFahrenheit" ? "F" : "C"));
            }
        }
    }
}