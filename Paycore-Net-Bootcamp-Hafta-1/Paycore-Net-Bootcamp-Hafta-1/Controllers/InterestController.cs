using Microsoft.AspNetCore.Mvc;
using Paycore_Net_Bootcamp_Hafta_1.Models;
using Paycore_Net_Bootcamp_Hafta_1.Wrappers;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Paycore_Net_Bootcamp_Hafta_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestController : ControllerBase
    {
        // GET api/<InterestController>/5
        [HttpGet]
        public Response<Interest> Get(double totalBalance,double interestRate,double maturity)
        {
            // validate given parameters
            if (totalBalance<0)
            {
                return new Response<Interest>("Totalbalance must be greater or equal to 0");
            }
            else if (interestRate<0 || interestRate >100)
            {
                return new Response<Interest>("Interestrate must be between 0 and 100");
            }
            else if (maturity<1) // vade en az 1 yıl olmalı
            {
                return new Response<Interest>("Maturity must be greater  or equal 1 ");
            }
            double interestAmount = CalculateInterestAmount(totalBalance, interestRate, maturity);
            var interest = new Interest(interestAmount, interestRate, totalBalance);
            return new Response<Interest>(interest); // wrap with response class
        }

        private static double CalculateInterestAmount(double totalBalance, double interestRate, double maturity)
        {
            return totalBalance * System.Math.Pow(1 + interestRate / 100, maturity);
        }

    }

     

       
    }

