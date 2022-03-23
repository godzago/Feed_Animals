using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATMrush : MonoBehaviour
{
    public static ATMrush instance;

    public List<GameObject> cubes = new List<GameObject>();


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;    
        }
    }
    void Start()
    {    
    }
    
    public void StackCube(GameObject other , int index)
    {

    }
}
