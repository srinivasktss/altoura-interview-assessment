using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Login
{
    public class LoginManager : MonoBehaviour
    {
        [SerializeField] private AbstractLoginFieldsValidator _fieldValidator;
        [SerializeField] private AbstractCredentialValidator _credentialValidator;
        [SerializeField] private UIManager _uiManager;

        public bool DoLogin(LoginFields loginFields)
        {
            try
            {
                if(_fieldValidator.Validate(loginFields))
                {
                    if(_credentialValidator.Validate(loginFields))
                    {
                        SceneManager.LoadScene("HomeScene");
                        return true;
                    }
                }

                return false;
            }
            catch(Exception e)
            {
                throw e;
            }

        }
    }
}
