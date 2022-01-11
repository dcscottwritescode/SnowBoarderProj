using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    [SerializeField] float sceneDelayFinish = 2f;
    [SerializeField] ParticleSystem finishEffect;
    

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadSceneFinish", sceneDelayFinish);
            Debug.Log("You have beat the level!");
        }
    }

    void ReloadSceneFinish()
    {
        SceneManager.LoadScene(0);
    }
}
