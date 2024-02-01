using TMPro;
using UnityEngine;

public class delenieCode : MonoBehaviour
{
    public GameObject delen;
    public GameObject delenObj;
    public float a;
    [SerializeField] TMP_InputField text1;

    [SerializeField] TMP_InputField text2;
    public int isAcive = 0;
    public TMP_InputField text3;
    float length1;
    float length2;
    float length1real;
    float length2real;
    float lengthImage1;

    private void Start()
    {
        length1 = text1.text.Length;
        length2 = text2.text.Length;
        lengthImage1 = delen.transform.localScale.x;
    }
    private void Update()
    {
        if (!delenObj.activeSelf && text3.text == "/")
        {
            text3.text = "";
            text3.DeactivateInputField(true);
            delenObj.SetActive(true);
        }
        if (delenObj.activeSelf)
        {
            if (text1.text == "" && text2.text == "")
            {
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    delenObj.SetActive(false);
                }
            }
        }
        if (text1.text.Length > length1)
        {
            delen.transform.localScale = new Vector3(delen.transform.localScale.x + a, delen.transform.localScale.y, delen.transform.localScale.z);
            length1 = text1.text.Length;
            length2 = text1.text.Length;
            length1real = text1.text.Length;
            length2real = text2.text.Length;
        }
        else if (text2.text.Length > length2)
        {
            delen.transform.localScale = new Vector3(delen.transform.localScale.x + a, delen.transform.localScale.y, delen.transform.localScale.z);
            length1 = text2.text.Length;
            length2 = text2.text.Length;
            length1real = text1.text.Length;
            length2real = text2.text.Length;
        }
        else if (text1.text.Length < length1real)
        {
            delen.transform.localScale = new Vector3(delen.transform.localScale.x - a, delen.transform.localScale.y, delen.transform.localScale.z);
            length1real = text1.text.Length;
            length2real = text2.text.Length;
            length1 = text1.text.Length;
            length2 = text1.text.Length;
        }
        else if (text2.text.Length < length2real)
        {
            delen.transform.localScale = new Vector3(delen.transform.localScale.x - a, delen.transform.localScale.y, delen.transform.localScale.z);
            length1real = text1.text.Length;
            length2real = text2.text.Length;
            length1 = text2.text.Length;
            length2 = text2.text.Length;
        }

        if (text1.text == null || text2.text == null)
        {
            delen.transform.localScale = new Vector3(lengthImage1, delen.transform.localScale.y);
        }
        if (delenObj.activeSelf)
        {
            isAcive = 1;
        }
        else
        {
            isAcive = 0;
        }
    }
}
