using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace Project2
{
    public class TeleportingStep : StepAbstract
    {
        [SerializeField] private CanvasGroup _transitionCanvasGroup;
        [SerializeField] private Transform _platformPosition1;
        [SerializeField] private Transform _platformPosition2;
        [SerializeField] private Transform _playerTransform;


        public override void DoStep()
        {
            DOTween.Sequence()
                .Insert(0, _transitionCanvasGroup.DOFade(1f, 0.1f))
                .Insert(1, _playerTransform.DOMoveZ(_platformPosition2.position.z, 1f))
                .Insert(1, _transitionCanvasGroup.DOFade(0, 0.5f));
        }

        public override void CloseStep()
        {
            DOTween.Sequence()
                .Insert(0, _transitionCanvasGroup.DOFade(1f, 0.1f))
                .Insert(1, _playerTransform.DOMoveZ(_platformPosition1.position.z, 1f))
                .Insert(1, _transitionCanvasGroup.DOFade(0, 0.5f));
        }
    }
}
