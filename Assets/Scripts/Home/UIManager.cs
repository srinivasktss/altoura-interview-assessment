using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Home
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private GameObject _projectListPanel;
        [SerializeField] private GameObject _videoPanel;
        [SerializeField] private VideoPlayerHandler _videoPlayerHandler;
        [SerializeField] private Button _project1Button;
        [SerializeField] private Button _project2Button;

        [Header("Asser Loaders")]
        [SerializeField] private AssetLoader _project1AssetLoader;
        [SerializeField] private AssetLoader _project2AssetLoader;

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
            LoadProject1Asset();
        }

        public void OnClickProject2Button()
        {
            LoadProject2Asset();
        }

        private void LoadProject1Asset()
        {
            _project1Button.interactable = false;
            _project1AssetLoader.LoadAsset<VideoClip>((videoClip) =>
            {
                _project1Button.interactable = true;
                _videoPlayerHandler.SetVideoClip(videoClip);
                ShowVideoPanel();
            });
        }

        private void LoadProject2Asset()
        {
            _project2Button.interactable = false;
            _project2AssetLoader.LoadAsset<GameObject>((gameObject) =>
            {
                _project2Button.interactable = true;
                AssetsHolder.Instance.SetProject2Asset(gameObject);
                SceneManager.LoadScene("Project2");
            });
        }
    }
}
