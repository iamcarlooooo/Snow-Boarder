using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadSceneDelay = 1.0f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;

    bool Dead = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground" && Dead == false)
        {
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", loadSceneDelay);
            Dead = true;
        }

        
    }
    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
