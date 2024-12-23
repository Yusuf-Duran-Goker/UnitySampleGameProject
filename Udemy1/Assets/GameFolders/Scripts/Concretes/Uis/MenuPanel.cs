using System.Collections;
using System.Collections.Generic;
using Udemy1.Managers;
using UnityEngine;


namespace Udemy1.Uis
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

        public void ExitClicked()
        {
            GameManager.Instance.Exit();
        }
       
    }

}
