using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ATMrush : MonoBehaviour
{
    public static ATMrush instance;
    public float MovmentDelay = 0.25f;

    public List<GameObject> cubes = new List<GameObject>();


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;    
        }
    }

    private void Start()
    {
     //   Time.timeScale = 1;
    }
    private void Update()
    {

      if (Time.timeScale == 1)
     {
            MoveListElemenst();
        }
      else
       {
         MoveOrigin();
      }
   
    }

    public void StackCube(GameObject other , int index)
    {
        other.transform.parent = transform;
        Vector3 newPos = cubes[index].transform.localPosition;
        newPos.z += 0.25f; 
        other.transform.localPosition = newPos;
        cubes.Add(other);

        StartCoroutine(MakeObjectsBigger());
    }

    public IEnumerator MakeObjectsBigger()
    {
        for (int i = cubes.Count-1; i > 0; i--)
        {
            Vector3 scale = new Vector3(0.25f, 0.25f, 0.25f);
            scale *= 1.5f;

            cubes[i].transform.DOScale(scale, 0.1f).OnComplete(() =>
            cubes[i].transform.DOScale(new Vector3(0.25f, 0.25f, 0.25f), 0.1f));
            yield return new WaitForSeconds(0.05f);
        }
    }

    private void MoveListElemenst()
    {
        for (int i = 1; i < cubes.Count; i++)
        {
            Vector3 pos = cubes[i].transform.localPosition;
            pos.x = cubes[i - 1].transform.localPosition.x;
            cubes[i].transform.DOLocalMove(pos, MovmentDelay);
        }
    }

    private void MoveOrigin()
    {
        for (int i = 1; i < cubes.Count; i++)
        {
            Vector3 pos = cubes[i].transform.localPosition;
            pos.x = cubes[0].transform.localPosition.x;
            cubes[i].transform.DOLocalMove(pos, 0.70f);
        }

    }

}
