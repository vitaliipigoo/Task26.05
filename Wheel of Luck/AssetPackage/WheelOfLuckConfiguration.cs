using UnityEngine;
using Wheel_of_Luck.Models;

namespace Wheel_of_Luck.AssetPackage
{
    [CreateAssetMenu(fileName = "WheelOfLuckConfiguration", menuName = "GameSettings/WheelOfLuckConfiguration")]
    public class WheelOfLuckConfiguration : ScriptableObject
    {
        public WheelOfLuckConfigurationModel ConfigurationModel => _configurationModel;
        [SerializeField] private WheelOfLuckConfigurationModel _configurationModel;
    }
}