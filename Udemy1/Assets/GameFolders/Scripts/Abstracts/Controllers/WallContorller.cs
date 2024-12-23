using System.Collections;
using System.Collections.Generic;
using Udemy1.Controllers;
using Udemy1.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Udemy1.Abstracts.Controllers
{
    public abstract class WallContorller : MonoBehaviour
    {

        private void OnCollisionEnter(Collision other)
        {
            
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player != null && player.CanMove) 
            {


                GameManager.Instance.GameOver();

            }
        }
    }
}
