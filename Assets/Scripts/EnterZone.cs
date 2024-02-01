using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnterZone : MonoBehaviour
{
    public int n;
    public GameObject loadingImage;
    void OnTriggerEnter(Collider col)  // вход в коллайдер-триггер объекта-двери или телепорта
    {
        if (col.tag.Equals("Player"))        // если это объект с тегом "Player"
        {
            StartCoroutine(LOadingScreenOnFable());// загружаем сцену с заданным индексом
        }
    }
    IEnumerator LOadingScreenOnFable()
    {
        loadingImage.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(n);
        Debug.Log("RUS");
        yield return operation;
    }
}
