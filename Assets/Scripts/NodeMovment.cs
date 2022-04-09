using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovment : MonoBehaviour
{
    public Transform ConnectedNode;

    void Update()
    {
        transform.position = new Vector3(
            Mathf.Lerp(transform.position.x,ConnectedNode.position.x,Time.deltaTime * 20),
            ConnectedNode.position.y,
            ConnectedNode.position.z + -0.35f
            );
    }
}
