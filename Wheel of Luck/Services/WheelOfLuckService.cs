using UnityEngine;
using Wheel_of_Luck.AssetPackage.Scripts;
using Wheel_of_Luck.Models;
using Wheel_of_Luck.Scripts.Configurations;
using Zenject;
using Constants = Wheel_of_Luck.Scripts.Constants.Constants;

namespace Wheel_of_Luck.Services
{
    public class WheelOfLuckService : IWheelOfLuckService, IInitializable
    {
        private WheelOfLuckPopupAdapter _wofPopupAdapter;
        private readonly WheelOfLuckConfiguration _wofConfiguration;

        public WheelOfLuckService(WheelOfLuckConfiguration wofConfiguration)
        {
            _wofConfiguration = wofConfiguration;
            
            Initialize();
        }

        public void Initialize()
        {
            InitAdapter();
        }

        private void InitAdapter()
        {
            var prefab = Resources.Load<GameObject>(Constants.WheelOfLuckResourceName);
            var instance = Object.Instantiate(prefab);

            _wofPopupAdapter = new WheelOfLuckPopupAdapter(instance);
        }

        public void OpenWheelOfLuck(Transform canvas)
        {
            
        }

        public void OpenWheelOfLuck(WheelOfLuckConfigurationModel config, Transform canvas)
        {
            
        }
    }
}