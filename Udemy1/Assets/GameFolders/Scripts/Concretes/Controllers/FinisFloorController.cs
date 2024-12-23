using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Udemy1.Controllers
{
    public class FinisController : MonoBehaviour
    {
        [SerializeField] GameObject _finishFireWork;
        [SerializeField] GameObject _finisLigth;

        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();  

            if (player == null) return;

            if (other.GetContact(0).normal.y == -1)
            {
                _finishFireWork.gameObject.SetActive(true);
                _finisLigth.gameObject.SetActive(true);
            }
            else { 
                   //GameOver
                     
                 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
                
            }
        }

    }

}

