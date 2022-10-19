using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace BallGame
{
    public sealed class InputController : IExecute
    {
        private readonly CharacterData _characterData;

        public InputController()
        {
            _characterData = Data.Instance.Character;
        }
        
        public void Execute()
        {
            if (!Services.Instance.LoadLevelService.IsLvlLoaded())
            {
                return;
            }

            var moveHorizontal = 0f;
            var moveVertical = 0f;
            if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor)
            {

                moveHorizontal = -Input.GetAxis("Horizontal");
                moveVertical = -Input.GetAxis("Vertical");
            }

            if (Application.platform == RuntimePlatform.Android)
            {
                EnabledGiro();
                moveHorizontal = -Input.acceleration.x;
                moveVertical = -Input.acceleration.y;

            }

            // Перемещение шара
            var movement = new Vector3(moveHorizontal, 0, moveVertical);
            _characterData.CharacterBehaviour.Move(movement);
        }

        private void EnabledGiro()
        {
            if (!SystemInfo.supportsGyroscope)
            {
                Application.Quit();
            }

            Input.gyro.enabled = true;
        }
    }
}
