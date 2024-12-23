using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Udemy1.Controllers
{
    public class Startflorr : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player != null)
            {
                Destroy(this.gameObject);
            }
        }
    }
}