using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

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
        other.transform.parent = transform;
        Vector3 newPos = cubes[index].transform.localPosition;
        newPos.z += 0.25f;
        other.transform.localPosition = newPos;
        StartCoroutine(MakeObjectsBigger());
    }

    public IEnumerator MakeObjectsBigger()
    {
        for (int i = cubes.Count; i > 0; i--)
        {
            Vector3 scale = new Vector3(0.25f, 0.25f, 0.25f);
            scale *= 1.5f;

            cubes[i].transform.DOScale(scale, 0.1f).OnComplete(() =>
            cubes[i].transform.DOScale(new Vector3(0.25f, 0.25f, 0.25f), 0.1f));
            yield return new WaitForSeconds(0.05f);
        }

    } 
}
