using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AnimalEscape.Controller;

namespace AnimalEscape.Movement
{
    public class ColliderAnimalDetected : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Veteriner")
            {
                transform.GetChild(0).GetComponent<Animator>().SetBool("Walk", true);
            }
            else if (other.tag == "Dead")
            {
                GetComponent<NodeMovement>().ConnectNode.gameObject.AddComponent<CollectController>();
                Destroy(this.gameObject);
            }
        }
    }
}

