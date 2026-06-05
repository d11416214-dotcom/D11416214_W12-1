using System;
using System.Data;
using System.Numerics;
using System.Reflection;

public class Student
{
	public int Mid;
	public int Final;
	public Student(int m,int f)
	{
		Mid = m;
		Final = f;
	}
	public float Plus(float a,float b)
	{
		float temp;
		temp = (a + b) / 2.0f;
		return temp;
	}
	public static Student operator +(Student a, Student b) 
	{
		Student temp=new Student(0,0);
		temp.Mid = (a.Mid + b.Mid) / 2;
		temp.Final = (a.Final + b.Final) / 2;
		return temp;
	}
}
