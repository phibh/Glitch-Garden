using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField]float timeToWait = 4f;
    int currentSecenIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentSecenIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSecenIndex == 0)
        {
            StartCoroutine(LoadStartScreen());
        }
    }

    IEnumerator LoadStartScreen()
    {
        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene(1);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSecenIndex+1);
    }
}
