using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 練習比對

//class設計, 包含學生姓名, 年紀, 國文, 英文, 數學, 三科成績屬性, 能計算平均以及總分
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Student josh = new Student("Josh.Wang",18,78,56,46.5);
			Console.WriteLine($"HI,{josh.Name}  您的年紀是:{josh.Age}   國英數成績分別是:{josh.Chinese}，{josh.English}，{josh.Math}");
			josh.TotalScore();
			josh.Average();
		}
	}

	public class Student
	{
		public string Name  { get; set; }
        public int Age { get; set; }
        public double Chinese { get; set; }
		public double English { get; set; }
        public double Math { get; set; }

		public Student(string name , int age , double chinese, double english, double meth) 
		{
			Name = name;
			Age = age;
			Chinese = chinese;
			English = english;
			Math = meth;
		}

		public void TotalScore()
		{
			double total = Chinese + English + Math;
			Console.WriteLine("您的總分是:" + total);
		}

		public void Average()
		{
			double average= (Chinese+ English+Math)/3;
			Console.WriteLine("您的平均成績是:"+average);
			Pass(average);
		}
		
		public void Pass(double sum)
		{
			if (sum >= 60) Console.WriteLine("此次測驗及格。");
			else Console.WriteLine("此次測驗不及格。");
		}

	}
}
