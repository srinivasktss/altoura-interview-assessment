using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Home
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private GameObject _projectListPanel;
        [SerializeField] private GameObject _videoPanel;

        private void Awake()
        {
            ShowProjectListPanel();
        }

        public void ShowProjectListPanel()
        {
            _videoPanel.SetActive(false);
            _projectListPanel.SetActive(true);
        }

        public void ShowVideoPanel()
        {
            _projectListPanel.SetActive(false);
            _videoPanel.SetActive(true); 
        }

        public void OnClickProject1Button()
        {
            ShowVideoPanel();
        }
    }
}
