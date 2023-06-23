using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment_1
{
	public class Patient
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Weight { get; set; }
		public int Height { get; set; }

		//custom contror to create new patient with all properties value set 
		public Patient(string firstName, string lastName, int weight, int height)
		{
			FirstName = firstName;
			LastName = lastName;
			Weight = weight;
			Height = height;
		}

		public string GetBloodPressureResult(int systolic, int diastonic)
		{
			string bloodPressureCategory = string.Empty;
			if (systolic < 120 && diastonic < 80)
			{
				bloodPressureCategory = "NORMAL";
			}
			else if (systolic <= 129 && diastonic < 80)
			{
				bloodPressureCategory = "ELEVATED";
			}
			else if (systolic <= 139 && diastonic <= 89)
			{
				bloodPressureCategory = "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
			}
			else if (systolic <= 139 && diastonic <= 89)
			{
				bloodPressureCategory = "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
			}
			else if (systolic <= 180 && diastonic <= 120)
			{
				bloodPressureCategory = "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
			}
			else if (systolic > 180 && diastonic > 120)
			{
				bloodPressureCategory = "HYPERTENSIVE CRISIS (consult your doctor immediately)";
			}
			else
			{
				bloodPressureCategory = "Invalid Input. Please Enter Proper value.";
			}

			return bloodPressureCategory;
		}

		public double CalculateBMI()
		{
			double m = Height / 100.00;
			double bmi = Weight / (m * m);
			return bmi;
		}

		public void ShowPatientInformation(int systolic, int diastonic)
		{
			double bmi = CalculateBMI();
			string bmiStatus = string.Empty;
			if (bmi >= 25.0)
			{
				bmiStatus= "Overweight";
			}
			else if (bmi >= 18.5 && bmi <= 24.9)
			{
				bmiStatus = "Normal (In the healthy range)";
			}
			else
			{
				bmiStatus = "Underweight";
			}

			Console.WriteLine("Full Name: " + FirstName + " " + LastName);
			Console.WriteLine("Weight: " + Weight);
			Console.WriteLine("Height: " + Height);
			Console.WriteLine("Blood Pressure Result: " + GetBloodPressureResult(systolic, diastonic));
			Console.WriteLine("BMI Numeric Value: " + bmi);
			Console.WriteLine("BMI Status: " + bmiStatus);
		}
	}
}
