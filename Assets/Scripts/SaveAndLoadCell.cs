using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveAndLoadCell : MonoBehaviour
{
    public static string ParentName;
    [SerializeField] private TMP_InputField cellBody;
    [SerializeField] private TMP_InputField numerator;
    [SerializeField] private TMP_InputField denominator;
    [SerializeField] private Fraction fraction;
    public string ID;
    private bool canDO = true;
    private void OnDisable()
    {
        cellBody.text = "";
        denominator.text = "";
        numerator.text = "";
        fraction.FractionObject.SetActive(false);
        canDO = true;
    }

    void Update()
    {
        ID = SceneManager.GetActiveScene().buildIndex + ParentName + gameObject.name;
        if (canDO && ID != null)
        {
            Debug.Log("enabled");
            fraction.isActive = PlayerPrefs.GetInt(ID + "FractionActive");
            numerator.text = PlayerPrefs.GetString(ID + "numerator");
            denominator.text = PlayerPrefs.GetString(ID + "denominator");
            Debug.Log("ID is" + ID);
            if (fraction.isActive == 1)
            {
                fraction.FractionObject.SetActive(true);
            }
            cellBody.text = PlayerPrefs.GetString(ID + "cellBody");
            canDO = false;
        }
    }

    public void OnChange()
    {
        PlayerPrefs.SetString(ID + "cellBody", cellBody.text);
        PlayerPrefs.SetString(ID + "numerator", numerator.text);
        PlayerPrefs.SetString(ID + "denominator", denominator.text);
    }
}
