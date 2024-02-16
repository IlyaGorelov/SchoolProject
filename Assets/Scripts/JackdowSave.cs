using UnityEngine;
using UnityEngine.SceneManagement;

public class JackdowSave : MonoBehaviour
{
    [SerializeField] private GameObject jackdow;
    private string ID;
    private int isActive = 0;

    private void Start()
    {
        ID = SceneManager.GetActiveScene().buildIndex + gameObject.name;
        isActive = PlayerPrefs.GetInt(ID + "jackdow");
        if (isActive == 1)
        {
            jackdow.SetActive(true);
        }
    }

    private void Update()
    {
        if (jackdow.activeSelf)
        {
            isActive = 1;
            PlayerPrefs.SetInt(ID + "jackdow", isActive);
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            isActive = 0;
            PlayerPrefs.DeleteAll();
            jackdow.SetActive(false);
        }
    }
}
