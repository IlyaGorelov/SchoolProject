using TMPro;
using UnityEngine;

public class Fraction : MonoBehaviour
{
    public GameObject FractionObject;
    public float a;
    [SerializeField] private TMP_InputField denomerator;

    [SerializeField] private TMP_InputField numerator;
    public int isActive = 0;
    public TMP_InputField cellBody;

    private SaveAndLoadCell cellCode;

    private void Start()
    {
        cellCode = GetComponent<SaveAndLoadCell>();
    }

    private void Update()
    {
        if (!FractionObject.activeSelf && cellBody.text == "/")
        {
            cellBody.text = "";
            cellBody.DeactivateInputField(true);
            cellBody.interactable = false;
            FractionObject.SetActive(true);
            isActive = 1;
            PlayerPrefs.SetInt(cellCode.ID + "FractionActive", isActive);
        }
        if (FractionObject.activeSelf)
        {
            if (denomerator.text == "" && numerator.text == "")
            {
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    FractionObject.SetActive(false);
                    isActive = 0;
                    cellBody.interactable = true;
                    cellBody.ActivateInputField();
                    PlayerPrefs.SetInt(cellCode.ID + "FractionActive", isActive);
                }
            }
        }
    }
}
