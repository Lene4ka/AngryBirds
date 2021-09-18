using System;

namespace AngryBirds
{
	public static class AngryBirdsTask
	{
		// Ниже — это XML документация, её использует ваша среда разработки, 
		// чтобы показывать подсказки по использованию методов. 
		// Но писать её естественно не обязательно.
		/// <param name="v">Начальная скорость</param>
		/// <param name="distance">Расстояние до цели</param>
		/// <returns>Угол прицеливания в радианах от 0 до Pi/2</returns>
		/// <param name="g">Ускорение свободного падения</param>
		public static double FindSightAngle(double v, double distance,double g = 9.8)
		{
			var sin2A = distance * g / (v * v);
			return 0.5 * Math.Asin(sin2A);
		}
	}
}