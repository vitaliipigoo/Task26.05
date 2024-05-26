using UnityEngine;
using Wheel_of_Luck.Models;

namespace Wheel_of_Luck.Services
{
    public interface IWheelOfLuckService
    {
        void OpenWheelOfLuck(Transform canvas);
        void OpenWheelOfLuck(WheelOfLuckConfigurationModel config, Transform canvas);
    }
}