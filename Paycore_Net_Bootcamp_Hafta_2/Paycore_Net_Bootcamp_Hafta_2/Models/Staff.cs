using Paycore_Net_Bootcamp_Hafta_2.Validator;
using System;
using System.ComponentModel.DataAnnotations;

namespace Paycore_Net_Bootcamp_Hafta_2.Models
{
    /// <summary>
    /// Summary:
    ///     Staff object that has attirubes of [Id,Name,Lastname,DateOfBirth,Email,PhoneNumber,Salary]
    /// </summary>
    public class Staff
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public double Salary { get; set; }
    }
}
