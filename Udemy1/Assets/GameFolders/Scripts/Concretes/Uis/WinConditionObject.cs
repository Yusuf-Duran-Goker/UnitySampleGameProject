using System.Collections;
using System.Collections.Generic;
using Udemy1.Managers;
using Unity.VisualScripting;
using UnityEngine;

namespace Udemy1.Uis
{
    public class WinConditionObject : MonoBehaviour
    {
        [SerializeField] GameObject _winConditionPanel;

        private void Awake()
        {
            if (_winConditionPanel.activeSelf)
            {
                _winConditionPanel.SetActive(false);
            } 
        }

        private void OnEnable()
        {
            GameManager.Instance.OnMissionSucced += HandleOnMissionSucced;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnMissionSucced -= HandleOnMissionSucced;
        }
        private void HandleOnMissionSucced()
        {
            if (!_winConditionPanel.activeSelf)
            {
                _winConditionPanel.SetActive(true);
            }
        }

        
    }
}