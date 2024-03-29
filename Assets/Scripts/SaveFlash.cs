using UnityEngine.SceneManagement;
using UnityEngine;

public class SaveFlash : MonoBehaviour
{
    [SerializeField] private GameObject flashActivator;
    [SerializeField] private GameObject flash;
    [SerializeField] private GameObject buttons;
    private int isActive = 0;

    private void Start()
    {
        isActive = PlayerPrefs.GetInt(SceneManager.GetActiveScene().buildIndex + "flash");
        if (isActive == 1)
        {
            flashActivator.SetActive(false);
            flash.SetActive(true);
            buttons.SetActive(true);
        }
    }

    private void Update()
    {
        if (flash.activeSelf)
        {
            isActive = 1;
            PlayerPrefs.SetInt(SceneManager.GetActiveScene().buildIndex + "flash", isActive);
        }
    }
}
