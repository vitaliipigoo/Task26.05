using System;
using UnityEngine;
using UnityEngine.UI;

namespace Wheel_of_Luck.AssetPackage.Scripts
{
    public class WheelOfLuckPopup : MonoBehaviour
    {
        public Action CloseButtonClick;
        public Action SpinButtonClick;
        
        [SerializeField] private Button closeButton;
        [SerializeField] private Button spinButton;

        public void OnDestroy()
        {
            closeButton.onClick.RemoveAllListeners();
            spinButton.onClick.RemoveAllListeners();
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
        }
    }
}