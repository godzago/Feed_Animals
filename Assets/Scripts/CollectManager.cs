using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollectManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {      
        if (other.gameObject.CompareTag("Collect"))
        {
            other.gameObject.AddComponent<Puan>();
            other.gameObject.transform.position = transform.position + Vector3.forward;
            Destroy(gameObject.GetComponent<CollectManager>());
            other.gameObject.AddComponent<CollectManager>();     
            other.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            other.gameObject.AddComponent<NodeMovment>();
            other.gameObject.GetComponent<NodeMovment>().ConnectedNode = transform;

            other.gameObject.tag = "Collected";
        }
    }
}

  
