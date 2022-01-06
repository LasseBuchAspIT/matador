using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg1
{
    class Student
    {
        string name;
        string currentCourse;
        DateTime admissionDate;

        protected string Name { get => name; set => name = value; }
        protected string CurrentCourse { get => currentCourse; set => currentCourse = value; }
        protected DateTime AdmissionDate { get => admissionDate; set => admissionDate = value; }


        public Student(string studentName, string studentCourse, DateTime studentAdmissionDate)
        {
            if (studentName == null)
            {
                throw new ArgumentException("Elev skal have et navn");
            }
            if (studentCourse == null)
            {
                throw new ArgumentException("Elev skal have et navn");
            }

            name = studentName;
            currentCourse = studentCourse;
            admissionDate = studentAdmissionDate;
        }

        public override string ToString()
        {
            return $"navn: {name}\nLinje: {currentCourse}\nadmissionsdato: {admissionDate.ToShortDateString()}\ndage til eksamen: {TimeUntilGraduation().Days}\ndage siden admission: {TimeSinceAdmission().Days}\n\n";
        }

        public TimeSpan TimeUntilGraduation()
        {
            TimeSpan timeToGrad = admissionDate.AddYears(3) - DateTime.Now;
            return timeToGrad;
        }
        public TimeSpan TimeSinceAdmission()
        {
            TimeSpan timeSinceAdmission = DateTime.Now - admissionDate;
            return timeSinceAdmission;
        }

    }
}
