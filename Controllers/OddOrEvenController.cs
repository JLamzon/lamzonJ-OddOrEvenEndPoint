//Jessie Lamzon
//10/25/22
//Odd or Even End Point
//Have endpoints configured to complete Mini Challenge # 6
//Peer review: BY N. HARRISON WILKINS : I LIKE THE DATA VALIDATION, CODE IS EASY TO READ AND VERY DIGESTABLE.   OVERALL VERY NICE, VERY NEAT WORK!!! GREAT JOB!
//

using Microsoft.AspNetCore.Mvc;

namespace lamzonJ_OddOrEvenEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
    [HttpGet]
    [Route("OddOrEven/{numberOne}")]

    public string OddOrEven(string numberOne)
    {
        bool trueNum1 = true;
        int realNum = 0;

        trueNum1 = Int32.TryParse(numberOne, out realNum);

        if (trueNum1 == true)
        {
            if (realNum % 2 == 0)
            {
                return $"{realNum} is an even number";
            }
            else
            {
                return $"{realNum} is an odd number";
            }
        }
        else
        {
            return "Enter numbers only";
        }
    }
}
