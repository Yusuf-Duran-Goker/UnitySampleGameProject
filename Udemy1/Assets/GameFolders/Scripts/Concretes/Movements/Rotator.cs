using System.Collections;
using System.Collections.Generic;
using Udemy1.Controllers;
using UnityEngine;



namespace Udemy1.Movements
{
    public class Ratotar
    {

        Rigidbody _rigidbody;
        PlayerController _playerController;

        public Ratotar(PlayerController   playerController  )
        {
            _playerController = playerController;
            _rigidbody = playerController.GetComponent<Rigidbody>();    
        }

        public void FixedTick(float direction )
        {
            if(direction == 0)
            {
                if (_rigidbody.freezeRotation) _rigidbody.freezeRotation = false;

                return;

            }



            if (!_rigidbody.freezeRotation) _rigidbody.freezeRotation = true;

            _playerController.transform.Rotate(Vector3.back * Time.deltaTime * direction * _playerController.TurnSpeed);
        }
    }
}


