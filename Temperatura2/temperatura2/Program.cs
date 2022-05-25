using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{

    class MyApplication
    {

        static void Main(string[] args)
        {

            double fahrenheit;

            double celsius = 36;
            Console.WriteLine("Celsius: " + celsius);

            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);

            Console.ReadLine();



            Console.Write("Enter the amount of Celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);

            double celsius;
            double fahrenheit = 97;
            Console.WriteLine("Fahrenheit: " + fahrenheit);
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celsius: " + celsius);
            Console.ReadLine();
            public static Double convertfarenheil(TemperatureScale scale, Double temp)
            {
                Double val = 0;
                switch (scale)
                {
                    case TemperatureScale.Farenheit:
                        val = ConvertFarenheitToRankine(temp);
                        break;
                    case TemperatureScale.Celcius:
                        val = ConvertCelciusToRankine(temp);
                        break;
                    case TemperatureScale.Kelvin:
                        val = ConvertKelvinToRankine(temp);
                        break;
                    case TemperatureScale.Rankine:
                        val = temp;
                        break;
                    default:
                        break;

                }
                return val;
                public static Double ConvertFromRankine(TemperatureScale scale, Double temp)
                {
                    Double val = 0;
                    switch (scale)
                    {
                        case TemperatureScale.Farenheit:
                            val = ConvertRankineToFarenheit(temp);
                            break;
                        case TemperatureScale.Celcius:
                            val = ConvertRankineToCelcius(temp);
                            break;
                        case TemperatureScale.Kelvin:
                            val = ConvertKelvinToRankine(temp);
                            break;
                        case TemperatureScale.Rankine:
                            val = temp;
                            break;
                        default:
                            break;
                    }
                    return val;
                    public static Double ConvertToKelvin(TemperatureScale scale, Double temp)
                    {
                        Double val = 0;
                        switch (scale)
                        {
                            case TemperatureScale.Farenheit:
                                val = ConvertFarenheitToKelvin(temp);
                                break;
                            case TemperatureScale.Celcius:
                                val = ConvertCelciusToKelvin(temp);
                                break;
                            case TemperatureScale.Kelvin:
                                val = temp;
                                break;
                            case TemperatureScale.Rankine:
                                val = ConvertRankineToKelvin(temp);
                                break;
                            default:
                                break;
                                public static Double ConvertFromKelvin(TemperatureScale scale, Double temp)
                                {
                                    Double val = 0;
                                    switch (scale)
                                    {
                                        case TemperatureScale.Farenheit:
                                            val = ConvertKelvinToFarenheit(temp);
                                            break;
                                        case TemperatureScale.Celcius:
                                            val = ConvertKelvinToCelcius(temp);
                                            break;
                                        case TemperatureScale.Kelvin:
                                            val = temp;
                                            break;
                                        case TemperatureScale.Rankine:
                                            val = ConvertKelvinToRankine(temp);
                                            break;
                                            ublic static Double ConvertToCelcius(TemperatureScale scale, Double temp)
                                            {
                                                Double val = 0;
                                                switch (scale)
                                                {
                                                    case TemperatureScale.Farenheit:
                                                        val = ConvertFarenheitToCelcius(temp);
                                                        break;
                                                    case TemperatureScale.Celcius:
                                                        val = temp;
                                                        break;
                                                    case TemperatureScale.Kelvin:
                                                        val = ConvertKelvinToCelcius(temp);
                                                        break;
                                                    case TemperatureScale.Rankine:
                                                        val = ConvertRankineToCelcius(temp);
                                                        break;
                                                        break;
                                                        /// <summary>
                                                        /// Converts the specified temperature value to Farenheit scale.
                                                        /// </summary>
                                                        /// <returns>
                                                        /// The temperature in degrees Farenheit.
                                                        /// </returns>
                                                        /// <param name="scale">
                                                        /// The scale to convert the temperature from.
                                                        /// </param>
                                                        /// <param name="temp">
                                                        /// The temperature value in the specified scale.
                                                        /// </param>
                                                        public static Double ConvertToFarenheit(TemperatureScale scale, Double temp)
                                                        {
                                                            Double val = 0;
                                                            switch (scale)
                                                            {
                                                                case TemperatureScale.Farenheit:
                                                                    val = temp;
                                                                    break;
                                                                case TemperatureScale.Celcius:
                                                                    val = ConvertCelciusToFarenheit(temp);
                                                                    break;
                                                                case TemperatureScale.Kelvin:
                                                                    val = ConvertKelvinToFarenheit(temp);
                                                                    break;
                                                                case TemperatureScale.Rankine:
                                                                    val = ConvertRankineToFarenheit(temp);
                                                                    break;
                                                                default:
                                                                    break;
                                                            }
                                                            return val;
                                                        }

                                                        /// <summary>
                                                        /// Convert the temperature in degrees Farenheit to the specified scale.
                                                        /// </summary>
                                                        /// <returns>
                                                        /// The temperature value in the specified scale.
                                                        /// </returns>
                                                        /// <param name="scale">
                                                        /// The scale to convert to.
                                                        /// </param>
                                                        /// <param name="temp">
                                                        /// The temperature in degrees Farenheit.
                                                        /// </param>
                                                        public static Double ConvertFromFarenheit(TemperatureScale scale, Double temp)
                                                        {
                                                            Double val = 0;
                                                            switch (scale)
                                                            {
                                                                case TemperatureScale.Farenheit:
                                                                    val = temp;
                                                                    break;
                                                                case TemperatureScale.Celcius:
                                                                    val = ConvertFarenheitToCelcius(temp);
                                                                    break;
                                                                case TemperatureScale.Kelvin:
                                                                    val = ConvertFarenheitToKelvin(temp);
                                                                    break;
                                                                case TemperatureScale.Rankine:
                                                                    val = ConvertFarenheitToRankine(temp);
                                                                    break;
                                                                default:
                                                                    break;
                                                            }
                                                            return val;
                                                        }

                                                }
        }
    } }