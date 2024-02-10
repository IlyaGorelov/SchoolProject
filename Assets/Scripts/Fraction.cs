using TMPro;
using UnityEngine;

public class Fraction : MonoBehaviour
{
    public GameObject HorizontalLine;
    public GameObject FractionObject;
    public float a;
    [SerializeField] TMP_InputField denomerator;

    [SerializeField] TMP_InputField numerator;
    public int isActive = 0;
    public TMP_InputField cellBody;
    float length1;
    float length2;
    float length1real;
    float length2real;
    float lengthImage1;

    private void Start()
    {
        length1 = denomerator.text.Length;
        length2 = numerator.text.Length;
        lengthImage1 = HorizontalLine.transform.localScale.x;
    }
    private void Update()
    {
        if (!FractionObject.activeSelf && cellBody.text == "/")
        {
            cellBody.text = "";
            cellBody.DeactivateInputField(true);
            FractionObject.SetActive(true);
        }
        if (FractionObject.activeSelf)
        {
            if (denomerator.text == "" && numerator.text == "")
            {
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    FractionObject.SetActive(false);
                }
            }
        }
        if (denomerator.text.Length > length1)
        {
            HorizontalLine.transform.localScale = new Vector3(HorizontalLine.transform.localScale.x + a, HorizontalLine.transform.localScale.y, HorizontalLine.transform.localScale.z);
            length1 = denomerator.text.Length;
            length2 = denomerator.text.Length;
            length1real = denomerator.text.Length;
            length2real = numerator.text.Length;
        }
        else if (numerator.text.Length > length2)
        {
            HorizontalLine.transform.localScale = new Vector3(HorizontalLine.transform.localScale.x + a, HorizontalLine.transform.localScale.y, HorizontalLine.transform.localScale.z);
            length1 = numerator.text.Length;
            length2 = numerator.text.Length;
            length1real = denomerator.text.Length;
            length2real = numerator.text.Length;
        }
        else if (denomerator.text.Length < length1real)
        {
            HorizontalLine.transform.localScale = new Vector3(HorizontalLine.transform.localScale.x - a, HorizontalLine.transform.localScale.y, HorizontalLine.transform.localScale.z);
            length1real = denomerator.text.Length;
            length2real = numerator.text.Length;
            length1 = denomerator.text.Length;
            length2 = denomerator.text.Length;
        }
        else if (numerator.text.Length < length2real)
        {
            HorizontalLine.transform.localScale = new Vector3(HorizontalLine.transform.localScale.x - a, HorizontalLine.transform.localScale.y, HorizontalLine.transform.localScale.z);
            length1real = denomerator.text.Length;
            length2real = numerator.text.Length;
            length1 = numerator.text.Length;
            length2 = numerator.text.Length;
        }

        if (denomerator.text == null || numerator.text == null)
        {
            HorizontalLine.transform.localScale = new Vector3(lengthImage1, HorizontalLine.transform.localScale.y);
        }
        if (FractionObject.activeSelf)
        {
            isActive = 1;
        }
        else
        {
            isActive = 0;
        }
    }
}
