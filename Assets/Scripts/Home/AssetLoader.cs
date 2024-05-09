using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Video;

namespace Home
{
    public class AssetLoader : MonoBehaviour
    {
        [SerializeField] private AssetReference _assetReference;

        private AsyncOperationHandle _handle;

        public async void LoadAsset<T>(Action<T> callback)
        {
            T result = default;
            if (_handle.IsValid())
            {
                result = (T)_handle.Result;
            }
            else
            {
                _handle = _assetReference.LoadAssetAsync<T>();

                await _handle.Task;

                if (_handle.Status == AsyncOperationStatus.Failed)
                {
                    Debug.LogError("Asset Loading Error: " + _handle.Task.Exception.ToString());
                }
                else if (_handle.Status == AsyncOperationStatus.Succeeded)
                {
                    Debug.Log("Asset Loaded Successfully");
                    result = (T)_handle.Result;
                }
            }

            callback?.Invoke(result);
        }

        private void OnDestroy()
        {
            /*if (_handle.IsValid())
            {
                _assetReference.ReleaseAsset();
            }*/
        }
    }
}
