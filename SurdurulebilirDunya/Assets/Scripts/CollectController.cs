using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AnimalEscape.Movement;

namespace AnimalEscape.Controller
{
    public class CollectController : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Collect")
            {

                other.gameObject.AddComponent<NodeMovement>();
                other.gameObject.AddComponent<CollectController>();
                other.gameObject.GetComponent<BoxCollider>().isTrigger = false;
                other.GetComponent<NodeMovement>().ConnectNode = transform;
                other.gameObject.tag = "Collected";

                Destroy(transform.GetComponent<CollectController>());
            }
        }
    }

}
