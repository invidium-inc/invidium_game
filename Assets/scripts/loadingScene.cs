using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class loadingScene : MonoBehaviour
{
    public GameObject progressScreen;
    public Slider progressBar;
    public Text progressText;

    public void Play(int sceneIndex)
    {
        progressScreen.SetActive(true);
        StartCoroutine(LoadAsync(sceneIndex));
    }

    IEnumerator LoadAsync(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            progressBar.value = progress;
            progressText.text = progress * 100 + "%";
            yield return null;
        }
    }
}
