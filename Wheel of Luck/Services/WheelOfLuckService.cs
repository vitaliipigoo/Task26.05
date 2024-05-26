using UnityEngine;
using Wheel_of_Luck.AssetPackage.Scripts;
using Wheel_of_Luck.Models;
using Wheel_of_Luck.Scripts.Configurations;
using Constants = Wheel_of_Luck.Scripts.Constants.Constants;

namespace Wheel_of_Luck.Services
{
    public class WheelOfLuckService : IWheelOfLuckService
    {
        private WheelOfLuckPopupAdapter _wofPopupAdapter;
        
        private readonly WheelOfLuckConfiguration _wofConfiguration;

        public WheelOfLuckService(WheelOfLuckConfiguration wofConfiguration)
        {
            _wofConfiguration = wofConfiguration;
        }

        public void OpenWheelOfLuck(Transform canvas)
        {
            Debug.Log("Success");
            InitAdapter(canvas);
        }

        public void OpenWheelOfLuck(WheelOfLuckConfigurationModel config, Transform canvas)
        {
            // TODO: for configurations from remote
        }

        private void InitAdapter(Transform canvas)
        {
            var prefab = Resources.Load<GameObject>(Constants.WheelOfLuckResourceName);
            var instance = Object.Instantiate(prefab, canvas);

            _wofPopupAdapter = new WheelOfLuckPopupAdapter(instance, _wofConfiguration);
            _wofPopupAdapter.Init();
        }
    }
}