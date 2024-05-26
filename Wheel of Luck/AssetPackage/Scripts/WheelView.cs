using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Wheel_of_Luck.Models;
using Random = UnityEngine.Random;

namespace Wheel_of_Luck.AssetPackage.Scripts
{
    public class WheelView : MonoBehaviour
    {
        [SerializeField] private List<WedgeView> wedgeViews;
        [SerializeField] private WinPopupView winPopup;
        
        private WheelOfLuckConfigurationModel _config;
        private int _winSector;
        private int _numberOfTurns;
        private int _winAngle;
        private float _speed;
        private bool _canWeSpin;
        private int _spinCounter;

        private void Start() => _canWeSpin = true;
        
        public void InitView(WheelOfLuckConfigurationModel config)
        {
            _config = config;
            
            var shuffledNumbers = _config.Rewards.GetRange(0, 8).OrderBy(x => Guid.NewGuid()).ToList();
            for (int i = 0; i < wedgeViews.Count; i++) 
                wedgeViews[i].InitView(shuffledNumbers[i]);
        }

        public void SpinTheWheel()
        {
            if (!_canWeSpin)
                return;
            
            _spinCounter++;
            if (_spinCounter > _config.Attempts)
                return;

            StartCoroutine(SpinTheWheelInternal());
        }

        private IEnumerator SpinTheWheelInternal()
        {
            _canWeSpin = false;

            _numberOfTurns = Random.Range(70, 100);
            _speed = 0.01f;

            for (int i = 0; i < _numberOfTurns; i++)
            {
                transform.Rotate(0, 0, 22.5f);

                if (i > Mathf.RoundToInt(_numberOfTurns * 0.5f)) 
                    _speed = 0.02f;
                if (i > Mathf.RoundToInt(_numberOfTurns * 0.7f)) 
                    _speed = 0.03f;
                if (i > Mathf.RoundToInt(_numberOfTurns * 0.9f)) 
                    _speed = 0.04f;

                yield return new WaitForSeconds(_speed);
            }

            if (Mathf.Round(transform.eulerAngles.z) % 45 != 0) 
                transform.Rotate(0, 0, 22.5f);

            _winAngle = Mathf.RoundToInt(transform.eulerAngles.z);
            _winSector = GetWinSector(_winAngle);
            yield return new WaitForSeconds(1);
            ShowWinPopup();

            _canWeSpin = true;
        }

        private void ShowWinPopup()
        {
            var winWedge = wedgeViews[_winSector];
            winPopup.gameObject.SetActive(true);
            winPopup.SetText(winWedge.type, winWedge.amount.ToString());
            winWedge.InitView(_config.Rewards[7+_spinCounter]);
        }

        private int GetWinSector(int whatWeWin)
        {
            var winSector = whatWeWin switch
            {
                0 => 0,
                45 => 1,
                90 => 2,
                135 => 3,
                180 => 4,
                225 => 5,
                270 => 6,
                315 => 7,
                _ => 0
            };
            
            return winSector;
        }
    }
}