namespace Wheel_of_Luck.Models
{
    public class RewardModel
    {
        public string Type { get; set; }
        public int Amount { get; set; }
        public int Priority { get; set; }
        public bool Consumable { get; set; }
    }
}