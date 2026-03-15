using UnityEngine;
using System;

namespace ConsoleApp2
{
    class characterscript : MonoBehaviour
    {
        public Transform target;
        private Vector3 _startedPos;
        private float _speed = 5f;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _startedPos = transform.position;
        }
        // Update is called once per frame
        void Update()
        {
            var targetCamera = transform.position + _startedPos;
            transform.position = Vector3.Lerp(transform.position, targetCamera, _speed * Time.deltaTime);
            transform.LookAt(target);

        }
    }
}