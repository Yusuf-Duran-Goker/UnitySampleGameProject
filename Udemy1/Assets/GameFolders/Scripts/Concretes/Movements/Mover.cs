using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Udemy1.Controllers;
using UnityEngine;



namespace Udemy1.Movements
{
   
    public class Mover
    {

        Rigidbody _rigidbody;
        PlayerController _playerController;


        public Mover(PlayerController  playerController)
        {
            _playerController = playerController;
            _rigidbody =playerController.GetComponent<Rigidbody>(); 
        }

        public void FixedTick()
        {
            _rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * _playerController.Force);


        }
    }
    
   
       
}


