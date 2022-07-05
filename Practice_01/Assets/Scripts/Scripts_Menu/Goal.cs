using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public float TimeToLoadNexTLevel;
    private Collider myCollider;

    private void Start()
    {
        myCollider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth health = other.GetComponent<PlayerHealth>();

        if (health != null)
        {
            Debug.Log("Has llegado a la meta");
            myCollider.enabled = false;
            StartCoroutine(LoadNextSceneCorrutine());
        }
    }

    public IEnumerator LoadNextSceneCorrutine()
    {
        yield return new WaitForSeconds(TimeToLoadNexTLevel);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;

        if (nextScene >= SceneManager.sceneCountInBuildSettings)
        {
            nextScene = 0;
        }

        SceneManager.LoadScene(nextScene);
    }
}