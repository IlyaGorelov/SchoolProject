using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{
    public int n;
    public GameObject loadingImage;
    public void StartGame()
    {
        StartCoroutine(LOadingScreenOnFable());
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    IEnumerator LOadingScreenOnFable()
    {
        loadingImage.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(n);
        Debug.Log("RUS");
        yield return operation;
    }
}
