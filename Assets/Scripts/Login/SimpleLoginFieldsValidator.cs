using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Login
{
    public class SimpleLoginFieldsValidator : AbstractLoginFieldsValidator
    {
        public override void Validate(LoginFields loginFields)
        {
            if(loginFields == null)
            {
                throw new Exception("LoginField is null");
            }

            if(string.IsNullOrEmpty(loginFields.UserName) || string.IsNullOrEmpty(loginFields.Password))
            {
                throw new Exception("Not a valid credentials");
            }
        }
    }
}
