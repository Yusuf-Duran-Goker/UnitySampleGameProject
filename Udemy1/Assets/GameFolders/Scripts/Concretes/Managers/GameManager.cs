using System;
using System.Collections;
using System.Collections.Generic;
using Udemy1.Abstracts.Utilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Udemy1.Managers
{
    public class GameManager : SingletonThisObject <GameManager>
    {

        public event System.Action OnGameOver;
        public event System.Action OnMissionSucced;


        private void Awake()
        {
            SingletonThisGameObject(this);
           
        }

        public void GameOver()
        {
            //if (OnGameOver != null)
            //{
            //    OnGameOver();
            //}

            //Kisa yazim

            OnGameOver?.Invoke();

        }

        public void MissionSucced() 
        { 
        OnMissionSucced?.Invoke();
        }
            
        public void LoadLevelScene(int levelIndex = 0)
        {
           StartCoroutine(LoadLevelSceneAsync(levelIndex));
        }

        private IEnumerator LoadLevelSceneAsync(int levelIndex)

        {
            SoundManager.Instance.StopSound(1);
            yield return  SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);
            SoundManager.Instance.PlaySound(2);
        }
        
        public void LoadMenuScene()
        {
            SoundManager.Instance.StopSound(2);
            StartCoroutine(LoadMenuSceneAysnc());
            SoundManager.Instance.PlaySound(1);

        }

        private IEnumerator LoadMenuSceneAysnc()
        {
            yield return SceneManager.LoadSceneAsync("Menu");
        }

        public void Exit()
        {
            Debug.Log("Exit procces on triggered");
            Application.Quit();
        }
    }
    
}
