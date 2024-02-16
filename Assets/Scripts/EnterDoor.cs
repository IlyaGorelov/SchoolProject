using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnterDoor : MonoBehaviour
{
    public int n;
    public GameObject loadingImage;
    [SerializeField] private Animator animator;

    public void LoadScene()
    {
        animator.enabled = true;
        StartCoroutine(LOadingScreenOnFable());
    }

    IEnumerator LOadingScreenOnFable()
    {
        yield return new WaitForSeconds(1);
        loadingImage.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(n);
        Debug.Log("RUS");
        yield return operation;
    }
}
