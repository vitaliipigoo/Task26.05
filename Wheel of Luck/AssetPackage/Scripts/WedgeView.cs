using UnityEngine;
using UnityEngine.UI;
using Wheel_of_Luck.Models;
using Wheel_of_Luck.Scripts.Common;

namespace Wheel_of_Luck.AssetPackage.Scripts
{
    public class WedgeView : MonoBehaviour
    {
        [SerializeField] private Image rewardImage;
        [SerializeField] private Text rewardAmount;

        public string type;
        public int amount;

        public void InitView(RewardModel rewardModel)
        {
            type = rewardModel.Type;
            amount = rewardModel.Amount;
            
            rewardImage.sprite = FindObjectOfType<RewardSpritesPool>().GetComponent<RewardSpritesPool>()
                .GetSpriteByName(type);
            rewardAmount.text = amount.ToString();
            rewardAmount.gameObject.SetActive(rewardModel.Consumable);
        }
    }
}