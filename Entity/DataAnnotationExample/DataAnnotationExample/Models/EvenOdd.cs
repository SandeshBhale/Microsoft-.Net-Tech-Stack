using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotationExample.Models
{
    public class EvenOdd : ValidationAttribute
    {
       public override bool IsValid(object value)
        {
            decimal result = Convert.ToDecimal(value);
            {
                if (result % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}