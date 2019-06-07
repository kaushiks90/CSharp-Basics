using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace OOPS.Others
{
    //"AutoMapper is an object-object mapper
    //which allows you to solve the problem of manually mapping each property of a class with the same properties of another class.".
    //Added a plugin Automapper
    class AutoMappers
    {
        void Method1()
        {
            User uobj = new User();
            uobj.ID = 100;
            uobj.Name = "Susant";
            uobj.Address = "Bangalore";
            uobj.Company = "Accenture";
            uobj.Dept = "IT";
            uobj.Dept = "susant@gmail.com";
            uobj.FatherName = "Mohan";
            uobj.Gender = "Male";
            uobj.maritialstatus = "Unmarried";
            //Maps all the values from user to the patient except  Department
            var mappeddata = AutoMapper.Mapper.Map<User, Patient>(uobj);
            Console.WriteLine(mappeddata.PatientID + Environment.NewLine +
                mappeddata.Name + Environment.NewLine +
                mappeddata.Address + Environment.NewLine +
                mappeddata.Job + Environment.NewLine +
                mappeddata.FatherName + Environment.NewLine +
                 mappeddata.Gender + Environment.NewLine +
                 mappeddata.maritialstatus + Environment.NewLine
                );
            Console.ReadLine();
        }
    }

    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Company { get; set; }
        public string FatherName { get; set; }
        public string Dept { get; set; }
        public string Gender { get; set; }
        public string maritialstatus { get; set; }
    }
    public class Patient
    {
        public int PatientID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Job { get; set; }
        public string FatherName { get; set; }
        public string salary { get; set; }
        public string Gender { get; set; }
        public string maritialstatus { get; set; }

    }
}
