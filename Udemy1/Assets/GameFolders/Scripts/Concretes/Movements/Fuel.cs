using System.Collections;
using System.Collections.Generic;
using Udemy1.Managers;
using UnityEngine;

namespace Udemy1.Movements
{
    public class Fuel : MonoBehaviour
    {
        [SerializeField] float _maxFuel = 100f;
        [SerializeField] float _currentFuel;
        [SerializeField] ParticleSystem _particle;

        public bool IsEmpty => _currentFuel < 1f;
        public float CurrentFuel => _currentFuel / _maxFuel;

        private void Awake()
        {
            _currentFuel = _maxFuel;
            SoundManager.Instance.StopSound(0);
        }

        private void Start()
        {
            if (_particle != null && !_particle.isPlaying)
            {
                _particle.Play();
            }
        }

        public void FuelIncrease(float increase)
        {
            _currentFuel += increase;
            _currentFuel = Mathf.Min(_currentFuel, _maxFuel);

            if (_particle != null && _particle.isPlaying)
            {
                _particle.Stop();
            }
        }

        public void FuelDecrease(float decrease)
        {
            _currentFuel -= decrease;
            _currentFuel = Mathf.Max(_currentFuel, 0f);

            if (_particle != null && _particle.isStopped)
            {
                _particle.Play();
            }

            SoundManager.Instance.PlaySound(0);
        }
    }
}
