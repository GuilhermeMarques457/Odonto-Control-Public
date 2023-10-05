﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoControl.Core.CustomValidators
{
    public class TimeSpanValidator : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is TimeSpan)
            {
                return true;
            }

            return false;
        }
    }
}
