using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadSceneDelay = 1.0f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            Invoke("ReloadScene", loadSceneDelay);
        }

        
    }
    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
