/// <summary>
/// Converts between Kelvin, Celsius, and Fahrenheit.
/// </summary>
namespace Helpers
{
	public static class TemperatureConverter
	{
		/// <summary>
		/// Kelvins to Celsius.
		/// </summary>
		/// <param name="kelvin">Kelvin.</param>
		/// <returns>The temperature in Celsius.</returns>
		public static double KelvinToCelsius(double kelvin) => kelvin - 273.15;
	
		/// <summary>
		/// Kelvin to Fahrenheit.
		/// </summary>
		/// <param name="kelvin">Kelvin.</param>
		/// <returns>The temperature in Fahrenheit.</returns>
		public static double KelvinToFahrenheit(double kelvin) => (kelvin * 1.8) - 459.67;
	
		/// <summary>
		/// Celsius to Kelvin.
		/// </summary>
		/// <param name="celsius">Celsius.</param>
		/// <returns>The temperature in Kelvin.</returns>
		public static double CelsiusToKelvin(double celsius) => celsius + 273.15;
	
		/// <summary>
		/// Celsius to Fahrenheit.
		/// </summary>
		/// <param name="celsius">Celsius.</param>
		/// <returns>The temperature in Fahrenheit</returns>
		public static double CelsiusToFahrenheit(double celsius) => (celsius * 1.8) + 32;
	
		/// <summary>
		/// Fahrenheits to kelvin.
		/// </summary>
		/// <param name="fahrenheit">Fahrenheit.</param>
		/// <returns>The temperature in Kelvin.</returns>
		public static double FahrenheitToKelvin(double fahrenheit) => (fahrenheit + 459.67) / 1.8;
	
		/// <summary>
		/// Fahrenheits to Celsius.
		/// </summary>
		/// <param name="fahrenheit">Fahrenheit.</param>
		/// <returns>The temperature in Celsius.</returns>
		public static double FahrenheitToCelsius(double fahrenheit) => (fahrenheit - 32) / 1.8;
	}
}