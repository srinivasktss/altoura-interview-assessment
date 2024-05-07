using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Login
{
    public abstract class AbstractLoginFieldsValidator : MonoBehaviour
    {
        public abstract bool Validate(LoginFields loginFields);
    }
}
