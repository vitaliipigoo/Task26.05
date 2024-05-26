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

        private string _type;
        private int _amount;

        public void InitView(RewardModel rewardModel)
        {
            _type = rewardModel.Type;
            _amount = rewardModel.Amount;
            
            rewardImage.sprite = FindObjectOfType<RewardSpritesPool>().GetComponent<RewardSpritesPool>()
                .GetSpriteByName(_type);
            rewardAmount.text = _amount.ToString();

            if (!rewardModel.Consumable)
                rewardAmount.gameObject.SetActive(false);
        }
    }
}