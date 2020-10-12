using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private int currentSceneIndex = 0;
    [SerializeField] private float timeToPause = 1f;

    public void LoadNextScene()
    {
        StartCoroutine(WaitFor());
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    IEnumerator WaitFor()
    {
        yield return new WaitForSeconds(timeToPause);
    }

    public void LoadStartScreen()
    {
        StartCoroutine(WaitFor());
        SceneManager.LoadScene(0);
    }

    public void LoadGameOverScreen()
    {
        // todo 
    }
}
