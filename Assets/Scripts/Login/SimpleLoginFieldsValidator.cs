using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Login
{
    public class SimpleLoginFieldsValidator : AbstractLoginFieldsValidator
    {
        public override bool Validate(LoginFields loginFields)
        {
            if(loginFields == null)
            {
                return false;
            }

            if(string.IsNullOrEmpty(loginFields.UserName) || string.IsNullOrEmpty(loginFields.Password))
            {
                return false;
            }

            return true;
        }
    }
}
