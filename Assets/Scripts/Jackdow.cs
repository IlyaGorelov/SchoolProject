using UnityEngine;
using UnityEngine.SceneManagement;

public class Jackdow : MonoBehaviour
{
    public GameObject _galka;
    public CheckingCode code;
    public int isGalka;
    private void Awake()
    {
        isGalka = PlayerPrefs.GetInt(gameObject.name + SceneManager.GetActiveScene().buildIndex + _galka.name + "galka");
        if (isGalka == 1)
        {
            _galka.SetActive(true);
        }
        else
        {
            _galka.SetActive(false);
        }
    }

    void Update()
    {
        if (code.result.text == "Ответ правильный")
        {
            _galka.SetActive(true);
            isGalka = 1;
            PlayerPrefs.SetInt(gameObject.name + SceneManager.GetActiveScene().buildIndex + _galka.name + "galka", isGalka);
        }
    }
}
