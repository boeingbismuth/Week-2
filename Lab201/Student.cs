using System;

namespace Lab201
{
	class Student
	{
		private string name;
		private string Student_Id;
		private int yearofbirth;
		private bool IsActive;




		public Student()
		{
			name = "John Doe";
			yearofbirth = 1995;
			IsActive = false;
			Student_Id = "Unknown";
		}
		public Student(string name, string Student_Id)
		{
			this.name = name;
			this.Student_Id = Student_Id;
			yearofbirth = 1995;
			IsActive = true;
		}
		public Student(string name, string Student_Id, int yearofbirth)
		{
			this.name = name;
			this.Student_Id = Student_Id;
			this.yearofbirth = yearofbirth;
			IsActive = true;
		}
		public Student(string name, string Student_Id, int yearofbirth, bool IsActive)
		{
			this.name = name;
			this.Student_Id = Student_Id;
			this.yearofbirth = yearofbirth;
			this.IsActive = IsActive;
		}
			
		public string student_Id
		{
			get
			{
				return Student_Id;
			}
			set 
			{
				Student_Id = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set 
			{
				name = value;
			}
		}

		public int YearOfBirth
		{
			get
			{
				return yearofbirth;
			}
			set 
			{
				

				if(value >= 1950 && value <= 2000)
				{
					yearofbirth = YearOfBirth;
				}
				else
				{
					Console.WriteLine("{0}: error try setting invalid year-of-birth value !" , student_Id);

				}
			}
		}

		public bool isActive
		{
			get 
			{
				return IsActive;
			}
			set 
			{
				IsActive = value;
			}
		}

		public int age()
		{
			

				
				
			return DateTime.Now.Year - YearOfBirth;

		}
		public override string ToString ()
		{
			string x;
			if (IsActive == true) 
			{
				x = "is";
			} else 
			{
				x = "is NOT";
			}
			return "Student : " + Name + "(" + Student_Id + ")" + " , Age = " + age() + ", " + x + " active Student";
		}

	}
}