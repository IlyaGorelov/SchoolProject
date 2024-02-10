using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveAndLoadCell : MonoBehaviour
{
    public static string ParentName;
    [SerializeField] TMP_InputField cellBody;
    [SerializeField] TMP_InputField numerator;
    [SerializeField] TMP_InputField denominator;
    [SerializeField] Fraction fraction;
    string ID;
    bool canDO = true;
    private void OnDisable()
    {
        cellBody.text = "";
        denominator.text = "";
        numerator.text = "";
        canDO = true;
    }
    void Update()
    {
        ID = SceneManager.GetActiveScene().buildIndex + ParentName + gameObject.name;
        if(canDO && ID != null)
        {
            Debug.Log("enabled");
            fraction.isActive = PlayerPrefs.GetInt(ID + "FractionActive");
            numerator.text = PlayerPrefs.GetString(ID + "numerator");
            denominator.text = PlayerPrefs.GetString(ID + "denominator");
            Debug.Log("ID is" + ID);
            fraction.isActive = PlayerPrefs.GetInt(ID + "FractionActive");
            if (fraction.isActive == 1)
            {
                fraction.FractionObject.SetActive(true);
            }
            cellBody.text = PlayerPrefs.GetString(ID + "cellBody");
            canDO = false;
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            PlayerPrefs.DeleteAll();
        }
    }

    // Update is called once per frame
    public void OnChange()
    {
        PlayerPrefs.SetString(ID + "cellBody", cellBody.text);
        PlayerPrefs.SetString(ID + "numerator", numerator.text);
        PlayerPrefs.SetString(ID + "denominator", denominator.text);
        PlayerPrefs.SetInt(ID + "FractionActive", fraction.isActive);
    }
}
