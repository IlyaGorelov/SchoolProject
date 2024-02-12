using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterZoneScript : MonoBehaviour
{
    [SerializeField] int n;
    public GameObject loadingImage;

    IEnumerator LOadingScreenOnFable()
    {
        loadingImage.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(n);
        Debug.Log("RUS");
        yield return operation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player") 
        {
            StartCoroutine(LOadingScreenOnFable());
        }
    }
}
