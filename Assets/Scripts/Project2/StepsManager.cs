using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project2
{
    public class StepsManager : MonoBehaviour
    {
        [SerializeField] private List<StepAbstract> _steps;

        private int _currentActiveStepIndex;

        private void Awake()
        {
            GoToFirstStep();
        }

        private void GoToFirstStep()
        {
            _currentActiveStepIndex = 1;
            ProceedStep(false);
        }

        private void ChangeStepIndex(bool next)
        {
            _currentActiveStepIndex = next ? _currentActiveStepIndex + 1 : _currentActiveStepIndex -1;
            _currentActiveStepIndex = Mathf.Max(0, _currentActiveStepIndex);
            _currentActiveStepIndex = Mathf.Min(_steps.Count - 1, _currentActiveStepIndex);
        }

        private void ProceedStep(bool next)
        {
            if (_currentActiveStepIndex == _steps.Count - 1 && next)
                return;

            if (_currentActiveStepIndex == 0 && !next)
                return;

            ProceedStep(false, _steps[_currentActiveStepIndex]);
            ChangeStepIndex(next);
            ProceedStep(true, _steps[_currentActiveStepIndex]);
        }

        private void ProceedStep(bool doo, StepAbstract step)
        {
            if(doo)
            {
                step.DoStep();
            }
            else
            {
                step.CloseStep();
            }
        }

        public void OnClickBackButton()
        {
            ProceedStep(false);
        }

        public void OnClickNextButton()
        {
            ProceedStep(true);
        }
    }
}
