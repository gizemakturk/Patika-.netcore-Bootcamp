using Microsoft.AspNetCore.Mvc;
using Paycore_Net_Bootcamp_Hafta_2.Models;
using Paycore_Net_Bootcamp_Hafta_2.Services;
using Paycore_Net_Bootcamp_Hafta_2.Validator;
using Paycore_Net_Bootcamp_Hafta_2.Wrappers;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Paycore_Net_Bootcamp_Hafta_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {

       private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }
        /// <summary>
        /// returns all staff
        /// </summary>
        /// <returns>staff list</returns>
        // GET: api/<StaffController>
        [HttpGet]
        public Response<IEnumerable<Staff>> Get()
        {
           
            return new Response<IEnumerable<Staff>>(_staffService.StaffList);
        }
        /// <summary>
        /// Returns the staff according to the id entered
        /// </summary>
        /// <param name="id">specific staff id to be brought</param>
        /// <returns> the desired staff</returns>
        // GET api/<StaffController>/5
        [HttpGet("{id}")]
        public Response<Staff> Get(int id)
        {
            return new Response<Staff>(_staffService.StaffList.Find(s => s.Id == id));
        }
        /// <summary>
        /// s creates the entered staff
        /// </summary>
        /// <param name="request">taff to be created</param>
        /// <returns>id of the created staff</returns>
        // POST api/<StaffController>
        [HttpPost]
        //[Route("StaffRegister")]
        public Response<int> Post([FromBody] Staff request)
        {
              if (request==null )
            {
                return new Response<int>("Request can not be null");
            }
            //  StaffValidator validationRules = new StaffValidator();
            //var result = validationRules.Validate(request);
            //if (!result.IsValid)
            //{
            //    string errors = "";

            //    foreach (var error in result.Errors)
            //        errors += error + "\n";
            //    return new Response<int>(errors);

            //}
            _staffService.StaffList.Add(request);

            return new Response<int>(request.Id);
        }
        /// <summary>
        /// updates the staff with the entered data
        /// </summary>
        /// <param name="id">staff id to update</param>
        /// <param name="request">staff with data to be updated</param>
        /// <returns> a message that it has been successfully updated.</returns>
        // PUT api/<StaffController>/5
        [HttpPut("{id}")]
        public Response<string> Put(int id, [FromBody] Staff request)
        {
            var staff = _staffService.StaffList.Find(s =>s.Id == id);
            if (staff == null)
            {
                return new Response<string>($"There is no staff with id {id}");
            }
            staff.Id = request.Id;  
            staff.Name = request.Name;
            staff.Lastname = request.Lastname;
            staff.Email = request.Email;
            staff.PhoneNumber = request.PhoneNumber;
            staff.DateOfBirth = request.DateOfBirth;
            staff.Salary = request.Salary;

            return new Response<string>($"Staff with id {id} has successfully updated.",null);
        }
        /// <summary>
        /// Deletes the staff based on the entered id
        /// </summary>
        /// <param name="id">the id of the staff to be deleted</param>
        /// <returns>id of the deleted staff</returns>
        // DELETE api/<StaffController>/5
        [HttpDelete("{id}")]
        public Response<int> Delete(int id)
        {
            var staff = _staffService.StaffList.Find(s => s.Id == id);
            if (staff == null)
            {
                return new Response<int>($"There is no staff with id {id}");
            }
            _staffService.StaffList.Remove(staff);
            return new Response<int>(staff.Id);
        }
    }
}
