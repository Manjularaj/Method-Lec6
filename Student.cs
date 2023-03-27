using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Lec6
{
    public class Student
    {

        //Field
        string _firstName;
        string _lastName;
        double _csiGrade;
        double _genEdGrade;

        //Constructor


        //public Student(string firstName)
        //{
        //    this._firstName = firstName;

        //}

        public Student(string firstName, string lastName, double csiGrade, double genEdGrade)
        {
            _firstName = firstName;
            _lastName = lastName;
            _csiGrade = csiGrade;
            _genEdGrade = genEdGrade;
        }

        //Properties

        public string FirstName
        {

            get
            {
                return _firstName;

            }
            set
            {

                _firstName = value;
            }
        }

        public string LastName { get => _lastName; set => _lastName = value; }
        public double CsiGrade { get => _csiGrade; set => _csiGrade = value; }
        public double GenEdGrade { get => _genEdGrade; set => _genEdGrade = value; }

        //s.FirstName + " " +s.LastName + " " + s.CsiGrade + " " + s.GenEdGrade;
        public double StudentAverage() //Average calculation
        {
            return (_csiGrade + _genEdGrade) / 2;

        }


        // overide to sting
        //First Name Last Name - CSI Grade - Gen Grade
        public override string ToString()
        {
            return $"{this._firstName} {this._lastName} - Gem Ed Grade; {this._genEdGrade} - CSI Grade {this._csiGrade} - Average {StudentAverage()}";
            //ToString

        }

        
    }

    

    
    

        
    
}
