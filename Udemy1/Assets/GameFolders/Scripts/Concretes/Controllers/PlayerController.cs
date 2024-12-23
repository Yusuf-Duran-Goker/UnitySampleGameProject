using System.Collections;
using System.Collections.Generic;
using Udemy1.Inputs;
using Udemy1.Managers;
using Udemy1.Movements;
using UnityEngine;


namespace Udemy1.Controllers
{

    public class PlayerController : MonoBehaviour
    {
      [SerializeField] private float _turnspeed = 10f;
      [SerializeField] float _force = 55f;

         
        DefaultInput _input;
        Mover _mover;
        Ratotar _ratotar;
        Fuel _fuel;

        bool _canMove;
        bool _canForceUp;
        float _leftRight;

        public float TurnSpeed => _turnspeed;
        public float Force => _force;

        public bool CanMove => _canMove;

        private void Awake()
        {
              
                 _input = new DefaultInput();
                 _mover = new Mover(this);

                 _ratotar= new Ratotar(this);
                 _fuel = GetComponent<Fuel>(); 
            
        }

        private void Start()
        {
            _canMove = true;
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnEventTriggered;
            GameManager.Instance.OnMissionSucced += HandleOnEventTriggered;
        }



        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnEventTriggered;
            GameManager.Instance.OnMissionSucced -= HandleOnEventTriggered;
        }

        private void Update()
        {
            if (!_canMove)  return;

            //input
            if (_input.IsForceUp && !_fuel.IsEmpty) { 
            
                _canForceUp = true;  
            }
            else
            {
                _canForceUp = false;
                _fuel.FuelIncrease(0.01f);

            }

            _leftRight = _input.LeftRight;  
        }


        private void FixedUpdate()
        {
            //fizik islemleri

            if (_canForceUp) { 
            
               _mover.FixedTick();
                _fuel.FuelDecrease(0.2f);
            }

            _ratotar.FixedTick(_leftRight);
        }

        private void HandleOnEventTriggered()
        {
            _canMove=false;
            _canForceUp=false;
            _leftRight = 0f;
            _fuel.FuelIncrease(0f);
        }

    }

}


