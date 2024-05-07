using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Login
{
    public abstract class AbstractCredentialValidator : MonoBehaviour
    {
        public abstract bool Validate(LoginFields fields);
    }
}
