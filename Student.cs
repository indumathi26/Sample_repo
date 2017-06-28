using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace dotnetLabInternal

{
public class student
    {
public int rollno = 0;
public string branch;

    }

public class Test : student
    {
public float sub1;
public float sub2;
public float total_marks;
public string sport, name;

public void getdata()
        {
//float sub1,sub2;
//float total_marks;
try
            {
Console.WriteLine("Enter the Name,Rollno,Branch,Marks");
Console.WriteLine("Enter the name of student");
name = Console.ReadLine();

Console.WriteLine("Enter the Roll No");
rollno = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the Branch");
branch = Console.ReadLine();

Console.WriteLine("Enter sports which are played by a student");
sport = Console.ReadLine();

Console.WriteLine("Enter sub1 marks");
                sub1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter sub2 marks");
                sub2 = Convert.ToInt32(Console.ReadLine());

total_marks = sub1 + sub2;
            }
catch (Exception e)
            {
Console.WriteLine(e);
            }
        }

public class Result : Test, student
{
private Result()
{
Console.WriteLine("the sport played by the student having name" +name+"is"+sport);
}
public static Result Result1()
{
return new Result();
}
}



public void display()
        {
Console.WriteLine("\nDisplaying Records");
Console.WriteLine("Name= " + name);
Console.WriteLine("Roll No = " + rollno);
Console.WriteLine("Branch =" + branch);
Console.WriteLine("Sub1=" + sub1);
Console.WriteLine("Sub2=" + sub2);

Console.WriteLine("Total Marks scored by " + name + " of branch " + branch + " in sub1 and sub2 =" + total_marks);
        }
    }


interface ISports
    {
	void sports_played(string name, string branch);

    }



class Program : Test, ISports
    {
	public void sports_played(string name, string branch)
        {
		Console.WriteLine("Sports played by " + name + "is " + sport);
        }



public static void Main(string[] args)
        {
	Console.WriteLine(" Student Database ");
	int size;
	int choice;


try
            {
Console.WriteLine("Enter the number of students");
size = Convert.ToInt16(Console.ReadLine());

Test[] tst = newTest[size];

for (int i = 0; i < size; i++)
                {
tst[i] = newTest();
                }

while (true)
                {
Console.WriteLine("\nChoose your choice...");
Console.WriteLine("1. Select 1 to enter the student name,rollno, branch and marks");
Console.WriteLine("2. To display");
Console.WriteLine("3.to give result of sport");
Console.WriteLine("Enter your choice");
choice = Convert.ToInt16(Console.ReadLine());

switch (choice)
                    {
case 1:
for (int i = 0; i < size; i++)
                            {
tst[i].getdata();
                            }
break;
case 2: for (int i = 0; i < size; i++)
tst[i].display();
break;

case 3:
	Result[] res=new Result[size];

 	for (int i = 0; i < size; i++)
            
	    {
              res[i] = Result.Result1();
            }


case 4:
	break;
                    }

                }
            }
catch (Exception ex)
            {
Console.WriteLine(ex);
            }
Console.ReadLine();
        }

    }
}


 
 