using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Login
{
    [Serializable]
    public class LoginFields
    {
        [SerializeField] private string _userName;
        public string UserName { get => _userName; }
        [SerializeField] private string _password;
        public string Password { get => _password; }

        public LoginFields(string userName, string password)
        {
            _userName = userName;
            _password = password;
        }

        public override bool Equals(object obj)
        {
            if(obj == this) return false;

            if (obj is not LoginFields other) return false;

            return (this.UserName.Equals(other.UserName) && this.Password.Equals(other.Password));
        }

        public void SetUserName(string userName)
        {
            _userName = userName;
        }

        public void SetPassword(string password)
        {
            _password = password;
        }
    }
}
