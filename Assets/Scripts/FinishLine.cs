using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    [SerializeField] float loadSceneDelay = 1.0f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Player")
        {
            Invoke("ReloadScene", loadSceneDelay);
        }
    }
        
    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

