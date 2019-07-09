using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(LoadSceneAsync(1));
        }
    }

    IEnumerator LoadSceneAsync(int sceneNum)
    {
        AsyncOperation op = SceneManager.LoadSceneAsync(sceneNum);
      
        while (!op.isDone)
        {
            yield return op.isDone;
            print("%: " + op.progress);
        }
        enabled = false;
        enabled = true;
        print("loaded");
    }
}
