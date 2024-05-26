using System;
using UnityEngine;
using UnityEngine.UI;

namespace Wheel_of_Luck.AssetPackage.Scripts
{
    public class PurchasePopupView : MonoBehaviour
    {
        public Action PurchaseButtonClick;

        [SerializeField] private Button purchaseButton;

        private void Awake() => AddButtonListeners();

        private void OnDestroy() => purchaseButton.onClick.RemoveAllListeners();

        private void AddButtonListeners() => purchaseButton.onClick.AddListener(OnPurchaseButtonClick);

        private void OnPurchaseButtonClick()
        {
            PurchaseButtonClick?.Invoke();
        }
    }
}