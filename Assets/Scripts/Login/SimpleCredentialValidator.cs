using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Login
{
    public class SimpleCredentialValidator : AbstractCredentialValidator
    {
        [SerializeField] private List<LoginFields> _fieldsDB = new List<LoginFields>();

        public override bool Validate(LoginFields fields)
        {
            if(fields == null)
            {
                return false;
            }

            if(string.IsNullOrEmpty(fields.UserName) || string.IsNullOrEmpty(fields.Password))
            {
                return false;
            }

            return CheckCredentials(fields);
        }

        private bool CheckCredentials(LoginFields fields)
        {
            foreach(LoginFields field in _fieldsDB)
            {
                if(field.Equals(fields))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
