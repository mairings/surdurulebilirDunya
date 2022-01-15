using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnimalEscape.Movement
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] Transform _target;
        float _speed = 2f;

        void Update()
        {
            transform.position = Vector3.Lerp(transform.position, _target.position, _speed * Time.deltaTime);
        }
    }
}

