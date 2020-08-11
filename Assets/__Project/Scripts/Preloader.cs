using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Preloader : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(LoadMainScene());
        }
    }

    private IEnumerator LoadMainScene()
    {
        yield return SceneManager.LoadSceneAsync("MainScene");
    }
}
