using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonsOnStartScene : MonoBehaviour
{
    public int n;
    public GameObject loadingImage;
    [SerializeField] private bool isBadQuality;
    public void StartGame()
    {
        if(isBadQuality)
        {
            PlayerPrefs.SetInt("Quality", 0);
        }
        else
        {
            PlayerPrefs.SetInt("Quality", 1);
        }
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
