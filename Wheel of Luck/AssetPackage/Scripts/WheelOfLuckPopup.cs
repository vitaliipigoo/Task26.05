using System;
using UnityEngine;
using UnityEngine.UI;
using Wheel_of_Luck.Models;

namespace Wheel_of_Luck.AssetPackage.Scripts
{
    public class WheelOfLuckPopup : MonoBehaviour
    {
        public Action CloseButtonClick;
        public Action SpinButtonClick;
        
        [SerializeField] private WheelView wheel;
        [SerializeField] private Button closeButton;
        [SerializeField] private Button spinButton;

        private WheelOfLuckConfigurationModel _config;
        private int _spinCounter;

        public void OnDestroy()
        {
            closeButton.onClick.RemoveAllListeners();
            spinButton.onClick.RemoveAllListeners();
        }

        public void InitView(WheelOfLuckConfigurationModel config)
        {
            _config = config;
            wheel.InitView(config.Rewards);
        }

        private void Awake()
        {
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

            _spinCounter++;
            if (_spinCounter > _config.Attempts)
                return;
            
            wheel.SpinTheWheel();
        }
    }
}