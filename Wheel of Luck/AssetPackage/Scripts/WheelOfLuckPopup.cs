using System;
using UnityEngine;
using UnityEngine.UI;
using Wheel_of_Luck.Models;

namespace Wheel_of_Luck.AssetPackage.Scripts
{
    public class WheelOfLuckPopup : MonoBehaviour
    {
        private static WheelOfLuckPopup _instance;
        
        public Action CloseButtonClick;
        public Action SpinButtonClick;
        
        [SerializeField] private WheelView wheel;
        [SerializeField] private Button closeButton;
        [SerializeField] private Button spinButton;

        public void OnDestroy()
        {
            closeButton.onClick.RemoveAllListeners();
            spinButton.onClick.RemoveAllListeners();
        }

        public void InitView(WheelOfLuckConfigurationModel config)
        {
            wheel.InitView(config);
        }

        private void Awake()
        {
            if (_instance != null)
            {
                Destroy(gameObject);
                return;
            }

            DontDestroyOnLoad(gameObject);
            _instance = this;
            
            AddButtonsListeners();
        }

        private void AddButtonsListeners()
        {
            closeButton.onClick.AddListener(OnCloseClick);
            spinButton.onClick.AddListener(OnSpinClick);
        }

        private void OnCloseClick()
        {
            CloseButtonClick?.Invoke();
            Destroy(gameObject);
        }

        private void OnSpinClick()
        {
            SpinButtonClick?.Invoke();
            wheel.SpinTheWheel();
        }
    }
}