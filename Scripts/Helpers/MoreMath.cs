namespace Kiwi.Helpers
{
	public static class MoreMath
	{
		public static double Map(double value, double x1, double y1, double x2, double y2)
		{
			return (value - x1) / (y1 - x1) * (y2 - x2) + x2;
		}
		
		public static float Map(float value, float x1, float y1, float x2, float y2)
		{
			return (value - x1) / (y1 - x1) * (y2 - x2) + x2;
		}
		
		public static int Map(int value, int x1, int y1, int x2, int y2)
		{
			return (value - x1) / (y1 - x1) * (y2 - x2) + x2;
		}
	}
}