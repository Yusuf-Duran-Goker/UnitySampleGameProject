using System.Collections;
using System.Collections.Generic;
using Udemy1.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Udemy1.Controllers
{
    public class FinisFloorController : MonoBehaviour
    {
        [SerializeField] GameObject _finishFireWork;
        [SerializeField] GameObject _finisLigth;

        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player == null || !player.CanMove) return;

            if (other.GetContact(0).normal.y == -1)
            {
                _finishFireWork.gameObject.SetActive(true);
                _finisLigth.gameObject.SetActive(true);
                GameManager.Instance.MissionSucced();
            }
            else {

                GameManager.Instance.GameOver();

            }
        }

    }

}

