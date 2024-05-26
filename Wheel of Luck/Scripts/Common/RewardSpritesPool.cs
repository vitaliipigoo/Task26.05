using System.Linq;
using UnityEngine;

namespace Wheel_of_Luck.Scripts.Common
{
    public class RewardSpritesPool : MonoBehaviour
    {
        [SerializeField] private Sprite[] rewardSprites;
        
        private const string DefaultSpiteName = "coins";
        
        public Sprite GetSpriteByName(string spriteName)
        {
            var sprite = rewardSprites.FirstOrDefault(x => x.name == spriteName);
            return sprite ? sprite : rewardSprites.FirstOrDefault(x => x.name == DefaultSpiteName);
        }
    }
}