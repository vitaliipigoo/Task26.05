using UnityEngine;

namespace Wheel_of_Luck.Scripts.Configurations
{
    [CreateAssetMenu(fileName = "WheelOfLuckConfiguration", menuName = "GameSettings/WheelOfLuckConfiguration")]
    public class WheelOfLuckConfiguration : ScriptableObject
    {
        public int Attempts => attempts;
        public bool IsFirstAttemptFree => isFirstAttemptFree;

        [SerializeField] private int attempts;
        [SerializeField] private bool isFirstAttemptFree;
    }
}