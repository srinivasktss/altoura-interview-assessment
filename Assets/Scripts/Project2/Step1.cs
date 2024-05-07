using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project2
{
    public class Step1 : StepAbstract
    {
        [SerializeField] private RectTransform _paneRect;

        public override void DoStep()
        {
            _paneRect.gameObject.SetActive(true);
        }

        public override void CloseStep()
        {
            _paneRect.gameObject.SetActive(false);
        }
    }
}
