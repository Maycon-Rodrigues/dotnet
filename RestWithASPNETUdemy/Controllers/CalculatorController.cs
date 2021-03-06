﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestWithASPNETUdemy.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CalculatorController : ControllerBase
  {

    [HttpGet("sum/{firstNumber}/{secondNumber}")]
    public IActionResult Sum(string firstNumber, string secondNumber)
    {
      if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
      {
        var sum = ConvertDecimal(firstNumber) + ConvertDecimal(secondNumber);
        return Ok(sum);
        // return Ok(sum.ToString());
      }

      return BadRequest("Invalid Input");
    }

    [HttpGet("sub/{firstNumber}/{secondNumber}")]
    public IActionResult Sub(string firstNumber, string secondNumber)
    {
      if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
      {
        var sub = ConvertDecimal(firstNumber) - ConvertDecimal(secondNumber);
        return Ok(sub);
      }

      return BadRequest("Invalid Input");
    }

    [HttpGet("mult/{firstNumber}/{secondNumber}")]
    public IActionResult Mult(string firstNumber, string secondNumber)
    {
      if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
      {
        var mult = ConvertDecimal(firstNumber) * ConvertDecimal(secondNumber);
        return Ok(mult);
      }

      return BadRequest("Invalid Input");
    }

    [HttpGet("div/{firstNumber}/{secondNumber}")]
    public IActionResult Div(string firstNumber, string secondNumber)
    {
      if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
      {
        var div = ConvertDecimal(firstNumber) / ConvertDecimal(secondNumber);
        return Ok(div);
      }

      return BadRequest("Invalid Input");
    }

    [HttpGet("med/{firstNumber}/{secondNumber}")]
    public IActionResult Med(string firstNumber, string secondNumber)
    {
      if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
      {
        var med = ConvertDecimal(firstNumber) + ConvertDecimal(secondNumber) / 2;
        return Ok(med);
      }

      return BadRequest("Invalid Input");
    }

    private bool IsNumeric(string strNumber)
    {
      double number;
      bool isNumber = double.TryParse(
          strNumber,
          System.Globalization.NumberStyles.Any,
          System.Globalization.NumberFormatInfo.InvariantInfo,
          out number);
      return isNumber;
    }
    private decimal ConvertDecimal(string strNumber)
    {
      decimal decimalValue;
      if (decimal.TryParse(strNumber, out decimalValue))
      {
        return decimalValue;
      }
      return 0;
    }

  }
}
