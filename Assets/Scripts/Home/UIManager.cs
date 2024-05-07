using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

namespace Home
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private GameObject _projectListPanel;
        [SerializeField] private GameObject _videoPanel;
        [SerializeField] private VideoPlayerHandler _videoPlayerHandler;

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
            _project1AssetLoader.LoadAsset<VideoClip>((videoClip) =>
            {
                _videoPlayerHandler.SetVideoClip(videoClip);
                ShowVideoPanel();
            });
        }

        private void LoadProject2Asset()
        {
            _project2AssetLoader.LoadAsset<GameObject>((gameObject) =>
            {
                Instantiate(gameObject);
            });
        }
    }
}
