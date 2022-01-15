using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AnimalEscape.Movement
{
    public class NodeMovement : MonoBehaviour
    {
        public Transform ConnectNode;
        void Update()
        {
            transform.position = new Vector3(Mathf.Lerp(transform.position.x, ConnectNode.position.x,Time.deltaTime * 10), 
                transform.position.y,
                ConnectNode.position.z + 1 );
        }
    }
}

