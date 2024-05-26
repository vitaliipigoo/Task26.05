using UnityEngine;
using Wheel_of_Luck.Scripts.Common;

namespace Wheel_of_Luck.AssetPackage.Scripts
{
    public class WheelOfLuckPopupAdapter : BaseAdapter<WheelOfLuckPopup>
    {
        public WheelOfLuckPopupAdapter(GameObject asset) : base(asset)
        {
            SubscribeEvents();
        }

        public override void Init()
        {
            
        }

        public override void CleanUp()
        {
            UnsubscribeEvents();
        }

        private void OnCloseButtonClick()
        {
            // SendAnalytics() if necessary
            UnsubscribeEvents();
        }

        private void OnSpinButtonClick()
        {
            // SendAnalytics() if necessary
        }

        private void SubscribeEvents()
        {
            AssetPackage.CloseButtonClick += OnCloseButtonClick;
            AssetPackage.SpinButtonClick += OnSpinButtonClick;
        }
        
        private void UnsubscribeEvents()
        {
            AssetPackage.CloseButtonClick -= OnCloseButtonClick;
            AssetPackage.SpinButtonClick -= OnSpinButtonClick;
        }
    }
}