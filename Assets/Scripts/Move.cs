using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float SwipeSpeed;
    public float MoveSpeed;

    private Camera cam;
   
    void Start()
    {
        cam = Camera.main;
    }


    void Update()
    {
        transform.position += Vector3.forward * MoveSpeed * Time.deltaTime;

      
    }

    private void MoveC()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = cam.transform.localPosition.z;

        Ray ray = cam.ScreenPointToRay(mousePos);

        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            GameObject firstCube = ATMrush.instance.cubes[0];
            Vector3 hitVec = hit.point;
            hitVec.y = firstCube.transform.localPosition.y;
            hitVec.z = firstCube.transform.localPosition.z;

            firstCube.transform.localPosition = Vector3.MoveTowards(firstCube.transform.localPosition, hitVec, Time.deltaTime * SwipeSpeed);

        }
    }
}
