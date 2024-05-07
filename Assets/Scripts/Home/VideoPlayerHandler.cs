using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Home
{
    public class VideoPlayerHandler : MonoBehaviour
    {
        [SerializeField] private UIManager _uiManager;
        [SerializeField] private VideoPlayer _videPlayer;
        [SerializeField] private RenderTexture _videoRenderTexture;
        [SerializeField] private RawImage _videoImage;

        private void Start()
        {
            _videPlayer.targetTexture = _videoRenderTexture;
        }

        public void SetVideoClip(VideoClip clip)
        {
            _videPlayer.clip = clip;
        }

        public void OnClickPlayOrPause()
        {
            PlayOrPauseVideo();
        }

        private void PlayOrPauseVideo()
        {
            if (_videPlayer.isPlaying)
            {
                _videPlayer.Pause();
            }
            else
            {
                _videPlayer.Play();
            }
        }

        public void OnClickStop()
        {
            StopVideo();
        }

        private void StopVideo()
        {
            _videPlayer.Stop();
            _videoRenderTexture.Release();
        }

        public void OnClickBackButton()
        {
            StopVideo();
            _uiManager.ShowProjectListPanel();
        }
    }
}
