using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class RestartGame : MonoBehaviour  
{
    public GameObject RestartScreen;
    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;
        RestartScreen.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
