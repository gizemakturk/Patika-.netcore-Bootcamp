using Paycore_Net_Bootcamp_Hafta_2.Models;
using System.Collections.Generic;

namespace Paycore_Net_Bootcamp_Hafta_2.Services
{
    /// <summary>
    /// Initilize the Staff List to has one instance
    /// </summary>
    public class StaffService : IStaffService
    {
        public List<Staff> StaffList;

        public StaffService ()
        {
        StaffList = new List<Staff>
        {
            new Staff()
            {
                Id = 1,
                Name = "Deny",
                Lastname = "Sellen",
                DateOfBirth = new System.DateTime(1989, 01, 01),
                Email = "deny@gmail.com",
                PhoneNumber = "+905554443366",
                Salary = 5446
            },
            new Staff()
            {
                Id = 2,
                Name = "Deny2",
                Lastname = "Sellen",
                DateOfBirth = new System.DateTime(1989, 01, 01),
                Email = "deny@gmail.com",
                PhoneNumber = "+905554443366",
                Salary = 5446
            }
        };
        }

        List<Staff> IStaffService.StaffList { get => StaffList; }
    }
}
