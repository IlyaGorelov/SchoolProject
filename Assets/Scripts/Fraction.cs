using TMPro;
using UnityEngine;

public class Fraction : MonoBehaviour
{
    public GameObject HorizontalLine;
    public GameObject FractionObject;
    public float a;
    [SerializeField] TMP_InputField cellBody;

    [SerializeField] TMP_InputField numerator;
    public int isActive = 0;
    public TMP_InputField denomerator;
    float length1;
    float length2;
    float length1real;
    float length2real;
    float lengthImage1;

    private void Start()
    {
        length1 = cellBody.text.Length;
        length2 = numerator.text.Length;
        lengthImage1 = HorizontalLine.transform.localScale.x;
    }
    private void Update()
    {
        if (!FractionObject.activeSelf && denomerator.text == "/")
        {
            denomerator.text = "";
            denomerator.DeactivateInputField(true);
            FractionObject.SetActive(true);
        }
        if (FractionObject.activeSelf)
        {
            if (cellBody.text == "" && numerator.text == "")
            {
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    FractionObject.SetActive(false);
                }
            }
        }
        if (cellBody.text.Length > length1)
        {
            HorizontalLine.transform.localScale = new Vector3(HorizontalLine.transform.localScale.x + a, HorizontalLine.transform.localScale.y, HorizontalLine.transform.localScale.z);
            length1 = cellBody.text.Length;
            length2 = cellBody.text.Length;
            length1real = cellBody.text.Length;
            length2real = numerator.text.Length;
        }
        else if (numerator.text.Length > length2)
        {
            HorizontalLine.transform.localScale = new Vector3(HorizontalLine.transform.localScale.x + a, HorizontalLine.transform.localScale.y, HorizontalLine.transform.localScale.z);
            length1 = numerator.text.Length;
            length2 = numerator.text.Length;
            length1real = cellBody.text.Length;
            length2real = numerator.text.Length;
        }
        else if (cellBody.text.Length < length1real)
        {
            HorizontalLine.transform.localScale = new Vector3(HorizontalLine.transform.localScale.x - a, HorizontalLine.transform.localScale.y, HorizontalLine.transform.localScale.z);
            length1real = cellBody.text.Length;
            length2real = numerator.text.Length;
            length1 = cellBody.text.Length;
            length2 = cellBody.text.Length;
        }
        else if (numerator.text.Length < length2real)
        {
            HorizontalLine.transform.localScale = new Vector3(HorizontalLine.transform.localScale.x - a, HorizontalLine.transform.localScale.y, HorizontalLine.transform.localScale.z);
            length1real = cellBody.text.Length;
            length2real = numerator.text.Length;
            length1 = numerator.text.Length;
            length2 = numerator.text.Length;
        }

        if (cellBody.text == null || numerator.text == null)
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
