using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Home
{
    public class AssetsHolder : MonoBehaviour
    {
        #region Singleton
        private static AssetsHolder _instance;
        public static AssetsHolder Instance
        {
            get => _instance;
            set { if(_instance == null) _instance = value; }
        }

        private void Awake()
        {
            if(Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                DestroyImmediate(gameObject);
                return;
            }
        }
        #endregion

        [SerializeField] private GameObject _project2Asset;
        public GameObject Project2Asset { get => _project2Asset; }

        public void SetProject2Asset(GameObject project2Asset)
        {
            _project2Asset = project2Asset;
        }
    }
}
