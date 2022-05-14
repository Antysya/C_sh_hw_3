using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace hw_3
{
    class Student
    {
        string firstname;
        string lastname;
        int age;
        double avg_bal;

        public Student()
        {

        }

        public Student(string _firstname, string _lastname, int _age, double _avg_bal)
        {
            firstname = _firstname;
            lastname = _lastname;
            age = _age;
            avg_bal = _avg_bal;
        }

        public void Print()
        {
            WriteLine($" {firstname}  {lastname}  {age}  {avg_bal} ");
        }

        public override string ToString()
        {
            return $" {firstname}  {lastname}  {age}  {avg_bal} ";
        }

        public static int operator +(Student _st1, Student _st2)
        {
            return _st1.age + _st2.age;
        }

        public static bool operator >(Student _st1, Student _st2)
        {
            if (_st1.lastname.CompareTo(_st2.lastname) <= 0)
                return false;
            else
                return true;
        }

        public static bool operator <(Student _st1, Student _st2)
        {
            if (_st1.lastname.CompareTo(_st2.lastname) <= 0)
                return true;
            else
                return false;
        }

        public static bool operator ==(Student _st1, Student _st2)
        { 
            if (_st1.avg_bal.Equals(_st2.avg_bal))
                return true;
            else
                return false;
        }

        public static bool operator !=(Student _st1, Student _st2)
        {
            if (_st1.avg_bal.Equals(_st2.avg_bal))
                return false;
            else
                return true;
        }

        public static void Sort(Student _st1, Student _st2)
        {
            if (_st1 < _st2)
            {
                _st1.Print();
                _st2.Print();
            }
            else
            {
                _st2.Print();
                _st1.Print();
            }
        }

        public static void Best(Student _st1, Student _st2)
        {
            if (_st1.avg_bal > _st2.avg_bal)
                WriteLine($" Лучший студент: {_st1.firstname}  {_st1.lastname} ");
            else
                WriteLine($" Лучший студент: {_st2.firstname}  {_st2.lastname} ");
        }
    }
}

