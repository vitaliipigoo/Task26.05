using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Wheel_of_Luck.Models;
using Wheel_of_Luck.Scripts.Common;
using Wheel_of_Luck.Scripts.Configurations;

namespace Wheel_of_Luck.AssetPackage.Scripts
{
    public class WheelOfLuckPopupAdapter : BaseAdapter<WheelOfLuckPopup>
    {
        private readonly WheelOfLuckConfiguration _wheelOfLuckConfiguration;

        public WheelOfLuckPopupAdapter(
            GameObject asset, 
            WheelOfLuckConfiguration wheelOfLuckConfiguration) 
            : base(asset)
        {
            _wheelOfLuckConfiguration = wheelOfLuckConfiguration;
            
            SubscribeEvents();
        }

        public override void Init()
        {
            var config = GetConfigurationModel();
            AssetPackage.InitView(config);
        }

        public override void CleanUp()
        {
            UnsubscribeEvents();
        }

        private WheelOfLuckConfigurationModel GetConfigurationModel()
        {
            var config = new WheelOfLuckConfigurationModel
            {
                Attempts = _wheelOfLuckConfiguration.Attempts,
                IsFirstAttemptFree = _wheelOfLuckConfiguration.IsFirstAttemptFree,
                Rewards = GetRewards()
            };

            return config;
        }

        private List<RewardModel> GetRewards()
        {
            var rewardsConfig = new List<RewardModel>(RewardsConfigurations.Config);
            var sortedRewards = rewardsConfig.OrderByDescending(x => x.Priority).ToList();

            return sortedRewards;
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