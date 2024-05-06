using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Login
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private LoginManager _loginManager;

        [SerializeField] private TMP_InputField _userNameInputField;
        [SerializeField] private TMP_InputField _passwordInputField;
        [SerializeField] private TMP_Text _errorMessage;
        [SerializeField] private Button _loginButton;

        private LoginFields _fields;

        private void Awake()
        {
            HideErrorDialogActive();
            SetLoginButtonInteractable(true);
            _fields = new LoginFields(null, null);
        }

        public void OnClickLoginButton()
        {
            SetLoginButtonInteractable(false);
            HideErrorDialogActive();
            _fields.SetUserName(_userNameInputField.text.Trim());
            _fields.SetPassword(_passwordInputField.text.Trim());
            CheckLogin();
        }

        private void CheckLogin()
        {
            try
            {
                _loginManager.DoLogin(_fields);
            }
            catch(Exception e)
            {
                Debug.LogException(e);
                SetLoginButtonInteractable(true);
                ShowErrorDialogActive();
            }
        }

        private void ShowErrorDialogActive(bool hideInDelay = true, float delayTime = 2f)
        {
            _errorMessage.gameObject.SetActive(true);
            if(hideInDelay)
            {
                Invoke(nameof(HideErrorDialogActive), delayTime);
            }
        }

        private void HideErrorDialogActive()
        {
            _errorMessage.gameObject.SetActive(false);
        }

        private void SetLoginButtonInteractable(bool interactable)
        {
            _loginButton.interactable = interactable;
        }
    }
}
