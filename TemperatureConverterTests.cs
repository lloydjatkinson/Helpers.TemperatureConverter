namespace Helpers.Test
{
	public class TemperatureConverterTests
	{
		[Theory]
		[InlineData(-10.0d, -283.15d)]
		[InlineData(0.0d, -273.15d)]
		[InlineData(10.0d, -263.15d)]
		[InlineData(20.0d, -253.15d)]
		[InlineData(25.55d, -247.6d)]
		public void ConvertingKelvinToCelsiusReturnsExpectedValue(double kelvin, double expected)
		{
			var calculated = TemperatureConverter.KelvinToCelsius(kelvin);
			Assert.Equal(expected, calculated, 3);
		}
	
		[Theory]
		[InlineData(-10.0d, -477.67d)]
		[InlineData(0.0d, -459.67d)]
		[InlineData(10.0d, -441.67d)]
		[InlineData(20.0d, -423.67d)]
		[InlineData(25.55d, -413.68)]
		public void ConvertingKelvinToFahrenheitReturnsExpectedValue(double kelvin, double expected)
		{
			var calculated = TemperatureConverter.KelvinToFahrenheit(kelvin);
			Assert.Equal(expected, calculated, 3);
		}
	
		[Theory]
		[InlineData(-10.0d, 263.15d)]
		[InlineData(0.0d, 273.15d)]
		[InlineData(10.0d, 283.15d)]
		[InlineData(20.0d, 293.15d)]
		[InlineData(25.55d, 298.7d)]
		public void ConvertingCelsiusToKelvinReturnsExpectedValue(double celsius, double expected)
		{
			var calculated = TemperatureConverter.CelsiusToKelvin(celsius);
			Assert.Equal(expected, calculated, 3);
		}
	
		[Theory]
		[InlineData(-10.0d, 14.0d)]
		[InlineData(0.0d, 32.0d)]
		[InlineData(10.0d, 50.0d)]
		[InlineData(20.0d, 68.0d)]
		[InlineData(25.55d, 77.99d)]
		public void ConvertingCelsiusToFahrenheitReturnsExpectedValue(double celsius, double expected)
		{
			var calculated = TemperatureConverter.CelsiusToFahrenheit(celsius);
			Assert.Equal(expected, calculated, 3);
		}
	
		[Theory]
		[InlineData(-10.0d, 249.817d)]
		[InlineData(0.0d, 255.372d)]
		[InlineData(10.0d, 260.928d)]
		[InlineData(20.0d, 266.483d)]
		[InlineData(25.55d, 269.567d)]
		public void ConvertingFahrenheitToKelvinReturnsExpectedValue(double fahrenheit, double expected)
		{
			var calculated = TemperatureConverter.FahrenheitToKelvin(fahrenheit);
			Assert.Equal(expected, calculated, 3);
		}
	
		[Theory]
		[InlineData(-10.0d, -23.333d)]
		[InlineData(0.0d, -17.778d)]
		[InlineData(10.0d, -12.222d)]
		[InlineData(20.0d, -6.667d)]
		[InlineData(25.55d, -3.583d)]
		public void ConvertingFahrenheitToCelsiusReturnsExpectedValue(double fahrenheit, double expected)
		{
			var calculated = TemperatureConverter.FahrenheitToCelsius(fahrenheit);
			Assert.Equal(expected, calculated, 3);
		}
	}	
}