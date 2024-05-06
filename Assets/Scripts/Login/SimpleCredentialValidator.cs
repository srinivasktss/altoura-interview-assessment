using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Login
{
    public class SimpleCredentialValidator : AbstractCredentialValidator
    {
        [SerializeField] private List<LoginFields> _fieldsDB = new List<LoginFields>();

        public override void Validate(LoginFields fields)
        {
            if(fields == null)
            {
                throw new Exception("Field is null");
            }

            if(string.IsNullOrEmpty(fields.UserName) || string.IsNullOrEmpty(fields.Password))
            {
                throw new Exception("Invalid Credentials");
            }

            CheckCredentials(fields);
        }

        private void CheckCredentials(LoginFields fields)
        {
            foreach(LoginFields field in _fieldsDB)
            {
                if(field.Equals(fields))
                {
                    return;
                }
            }

            throw new Exception("Wrong Credentials");
        }
    }
}
