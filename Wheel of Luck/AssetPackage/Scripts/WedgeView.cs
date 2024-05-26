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

        public void InitView(RewardModel rewardModel)
        {
            rewardImage.sprite = FindObjectOfType<RewardSpritesPool>().GetComponent<RewardSpritesPool>()
                .GetSpriteByName(rewardModel.Type);
            rewardAmount.text = rewardModel.Amount.ToString();

            if (!rewardModel.Consumable)
                rewardAmount.gameObject.SetActive(false);
        }
    }
}