using System;

namespace Lab202
{

	public class Course
	{
		private string name;
		private string courseid;
		private string lecturer;
		private int maxstudents;
		private int numstudents;

		public Course ()
		{
			name = "Boeing";
			courseid = "123456";
			lecturer = "staff";
			maxstudents = 30;
			numstudents = 0;

		}
		public Course(string NAME,string Courseid)
		{
			name = NAME;
			courseid = Courseid;
			lecturer = "staff";
			maxstudents = 30;
			numstudents = 0;
		}
		public Course(string NAME,string Courseid,string Lecturer)
		{
			name = NAME;
			courseid = Courseid;
			lecturer = Lecturer;
			maxstudents = 30;
			numstudents = 0;
		}
		public Course(string NAME,string Courseid,string Lecturer,int MaxStudents)
		{
			name = NAME;
			courseid = Courseid;
			lecturer = Lecturer;
			maxstudents = MaxStudents;
			numstudents = 0;
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
		public string CourseID 
		{
			get 
			{
				return courseid;
			}
			set 
			{
				if (value.Length == 6) 
				{
					int x = 0;
					for (int i = 0; i < 6; i++) {
						if (char.IsDigit (value [i])) 
						{
							x = x+1;

						}
					}
					if (x == 6) 
					{
						courseid = value;
					} else 
					{
						Console.WriteLine ("{0}: error try setting invalid CourseID!", courseid);
					}
				} 
				else 
				{
					Console.WriteLine ("{0}: error try setting invalid CourseID!", courseid);
				}
			}
		}
		public string Lecturer 
		{
			get 
			{
				return lecturer;
			}
			set 
			{
				lecturer = value;
			}
		}
		public int MaxStudents 
		{
			get 
			{
				return maxstudents;
			}
			set 
			{
				if (value > 0 && value <= 80 && value >= numstudents) 
				{
					maxstudents = value;	
				} else 
				{
					Console.WriteLine ("{0}: error try setting invalid Max No. Students!", courseid);
				}
			}
		}
		public int NumStudents 
		{
			get 
			{
				return numstudents;
			}
			set 
			{
				if (value >= 0 && value <= maxstudents) 
				{
					numstudents = value;	
				} else 
				{
					Console.WriteLine ("{0}: error try setting invalid No. Students!", courseid);
				}

			}
		}
		public override string ToString ()
		{
			return string.Format ("[Course: {0} ({1}), Lecturer={2}, has {3} students, max={4}]" , Name , CourseID , Lecturer , NumStudents , MaxStudents);

		}


	}
}

