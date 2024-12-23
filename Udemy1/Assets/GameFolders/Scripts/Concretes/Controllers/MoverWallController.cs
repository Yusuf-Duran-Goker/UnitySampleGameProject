using System.Collections;
using System.Collections.Generic;
using Udemy1.Abstracts.Controllers;
using UnityEngine;

namespace Udemy1.Controllers
{
    public class MoverWallController : WallContorller
    {
        [SerializeField] Vector3 _direction;
        [SerializeField] float _speed;
       
        
        Vector3 _startPosition;
        float _factor;
        const float FULL_CIRCLE = Mathf.PI * 2f;

        private void Awake()
        {
            _startPosition = transform.position;
        }

        private void Update()
        {
            float cycle = Time.time / _speed;
            float sinWawe = Mathf.Sin(cycle*FULL_CIRCLE);

            //_factor = Mathf.Abs(sinWawe);
            _factor = sinWawe / 2f + 0.5f;

           Vector3 offset =_direction * _factor;
           transform.position =offset + _startPosition;    

        }
    }

}