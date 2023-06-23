using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment_1
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter your age: ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the patient's first name: ");
			string firstName = Console.ReadLine();

			Console.Write("Enter the patient's last name: ");
			string lastName = Console.ReadLine();

			Console.Write("Enter the patient's weight (in kg): ");
			int weight = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the patient's height (in cm): ");
			int height = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the patient's SYSTOLIC mm Hg (upper number): ");
			int systolic = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the patient's DIASTOLIC mm Hg (lower number): ");
			int diastonic = Convert.ToInt32(Console.ReadLine());

			// Create an instance of the Patient class using the provided information
			Patient patient = new Patient(firstName, lastName, weight, height);
			
			Console.WriteLine("=====================================");
			Console.WriteLine("Patient Information:");
			Console.WriteLine("=====================================");
			patient.ShowPatientInformation(systolic, diastonic);

			Console.ReadLine();
		}
	}
}
