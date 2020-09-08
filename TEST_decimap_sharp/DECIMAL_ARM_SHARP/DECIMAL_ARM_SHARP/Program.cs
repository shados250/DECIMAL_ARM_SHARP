/*
 * Created by SharpDevelop.
 * User: OLEG
 * Date: 17.03.2020
 * Time: 11:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace DECIMAL_ARM_SHARP
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			decimal cash = 5.223M;
			
			Console.WriteLine(cash.FormatDecimal(3)); 
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		
		
	}
	
	
	
	/// <summary>
	/// Дополнительный класс расширений типо в АРМ Кассира
	/// </summary>
	public static class Extentions
    {
		
		/// <summary>
		/// Интересный метод, который хитро внедряется в базовый класс Decimal
		/// 
		/// Дописывает автоматически недостающее число нулей до заданной точности (количества)
		/// </summary>
		/// <param name="value"></param>
		/// <param name="precision"></param>
		/// <returns></returns>
		public static string FormatDecimal(this decimal value, int precision = 3)
        {
            if (precision <= 0)
            {
                return Convert.ToString(Convert.ToInt32(value));
            }
            return value.ToString("#0." + new string('0', precision), CultureInfo.InvariantCulture);
        }
		
	}
}