using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Login
{
    public class LoginManager : MonoBehaviour
    {
        [SerializeField] private AbstractLoginFieldsValidator _fieldValidator;
        [SerializeField] private AbstractCredentialValidator _credentialValidator;
        [SerializeField] private UIManager _uiManager;

        public void DoLogin(LoginFields loginFields)
        {
            try
            {
                _fieldValidator.Validate(loginFields);
                _credentialValidator.Validate(loginFields);
            }
            catch(Exception e)
            {
                throw e;
            }

        }
    }
}
