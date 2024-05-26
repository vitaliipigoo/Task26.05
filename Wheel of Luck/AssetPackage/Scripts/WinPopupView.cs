using UnityEngine;
using UnityEngine.UI;

namespace Wheel_of_Luck.AssetPackage.Scripts
{
    public class WinPopupView : MonoBehaviour
    {
        [SerializeField] private Text winText;

        public void SetText(string type, string amount) => winText.text = $"You won {amount} {type}s";
    }
}