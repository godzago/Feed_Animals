using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float MovemntSpeed;
    [SerializeField] float HorSpeed;
    float hor;

    void Start()

    {
        
    }

    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(hor * HorSpeed * Time.deltaTime, 0, MovemntSpeed * Time.deltaTime));
    }
}
