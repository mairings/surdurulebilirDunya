using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace PanteonRunnerDemo.Movement
{
    public class VerticalMove : MonoBehaviour
    {
        [SerializeField] float _moveValue;
        [SerializeField] float _speed;

        void Start()
        {
            VerticalMoveObstacle();
        }

        void VerticalMoveObstacle()
        {
            transform.DOLocalMoveY(transform.localPosition.y - _moveValue, _speed).OnComplete(() => {
                transform.DOLocalMoveY(transform.localPosition.y + _moveValue, _speed).OnComplete(() => { VerticalMoveObstacle(); });
            });
        }

    }
}

