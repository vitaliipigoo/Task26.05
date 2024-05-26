using System.Collections.Generic;

namespace Wheel_of_Luck.Models
{
    public class WheelOfLuckConfigurationModel
    {
        public int Attempts { get; set; }
        public bool IsFirstAttemptFree { get; set; }
        public List<RewardModel> Rewards { get; set; }
    }
}