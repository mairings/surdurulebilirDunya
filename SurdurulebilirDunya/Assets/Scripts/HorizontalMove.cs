using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace PanteonRunnerDemo.Movement
{
    public class HorizontalMove : MonoBehaviour
    {
        [SerializeField] float _moveValue;
        [SerializeField] float _speed;
        void Start()
        {
            HorizontalMoveObstacle();
        }

        void HorizontalMoveObstacle()
        {
            transform.DOLocalMoveX(transform.localPosition.x - _moveValue, _speed).OnComplete(() => {
                transform.DOLocalMoveX(transform.localPosition.x + _moveValue, _speed).OnComplete(() => { HorizontalMoveObstacle(); });
            });
        }


    }
}

