using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Udemy1.Inputs
{
    public class DefaultInput 
    {

       private DefaultAction _inputs;


        public bool IsForceUp { get; private set; }
        public float LeftRight { get; private set; }


        public DefaultInput()
        {

            
            
            _inputs = new DefaultAction();

            
            _inputs.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();

            _inputs.Rocket.LeftRight.performed += context => LeftRight = context.ReadValue <float>();

            _inputs.Enable();
              
        }


    }



}
