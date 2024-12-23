using System.Collections;
using System.Collections.Generic;
using Udemy1.Managers;
using UnityEngine;

namespace Udemy1.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesClicked()
        {
            GameManager.Instance.LoadLevelScene(0);
        }

        public void NoClicked() 
        {
        GameManager.Instance.LoadMenuScene();
        }
    }

}