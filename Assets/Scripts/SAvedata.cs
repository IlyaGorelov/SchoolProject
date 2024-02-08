using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SAvedata : MonoBehaviour
{
    public TMP_InputField inputField1;
    public TMP_InputField inputField2;
    public TMP_InputField inputField3;
    public GameObject gameObj;
    public Fraction divideCode;
    public Galka galkaCode;
    [SerializeField] GameObject parentObject;

    private void Awake()
    {
        if (PlayerPrefs.GetInt(SceneManager.GetActiveScene().buildIndex + parentObject.name + gameObj.name + "delenie") == 1)
            divideCode.FractionObject.SetActive(true);
        inputField1.text = PlayerPrefs.GetString(SceneManager.GetActiveScene().buildIndex + parentObject.name + gameObj.name + "inputfield1", inputField1.text);
        inputField2.text = PlayerPrefs.GetString(SceneManager.GetActiveScene().buildIndex + parentObject.name + gameObj.name + "inputfield2", inputField2.text);
        inputField3.text = PlayerPrefs.GetString(SceneManager.GetActiveScene().buildIndex + parentObject.name + gameObj.name + "inputfield3", inputField3.text);

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F3))
        {
            PlayerPrefs.DeleteAll();
            inputField1.text = null;
            inputField2.text = null;
            inputField3.text = null;
            divideCode.isActive = 0;
            galkaCode.isGalka = 0;
        }
    }
    public void SaveStrings()
    {
        PlayerPrefs.SetString(SceneManager.GetActiveScene().buildIndex+parentObject.name + gameObj.name + "inputfield1", inputField1.text);
        PlayerPrefs.SetString(SceneManager.GetActiveScene().buildIndex + parentObject.name + gameObj.name + "inputfield2", inputField2.text);
        PlayerPrefs.SetString(SceneManager.GetActiveScene().buildIndex + parentObject.name + gameObj.name + "inputfield3", inputField3.text);
        PlayerPrefs.SetInt(SceneManager.GetActiveScene().buildIndex + parentObject.name + gameObj.name + "delenie", divideCode.isActive);
    }
}
