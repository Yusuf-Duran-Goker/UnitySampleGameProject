using System.Collections;
using System.Collections.Generic;
using Udemy1.Managers;
using UnityEngine;

namespace Udemy1.Uis
{
    public class GameOverObjects : MonoBehaviour
    {
        [SerializeField] GameObject _gameOverPanel;

        private void Awake()
        {
            if (_gameOverPanel.activeSelf)
            {
                _gameOverPanel.SetActive(false);    
            }
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnGameOver;
        }

     
        private void OnDisable()
        {
                GameManager.Instance.OnGameOver -= HandleOnGameOver;
        }

        private void HandleOnGameOver()
        {
            if (!_gameOverPanel.activeSelf)
            {
                _gameOverPanel.SetActive(true); 
            }
        }

    }

}
