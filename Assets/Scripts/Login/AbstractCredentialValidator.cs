using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Login
{
    public abstract class AbstractCredentialValidator : MonoBehaviour
    {
        public abstract void Validate(LoginFields fields);
    }
}
