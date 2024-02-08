using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowTaskBody : MonoBehaviour
{
    [SerializeField] GameObject TaskBody;
    TextMeshProUGUI nameOfThisTask;
    string oldName;
    [SerializeField] TextMeshProUGUI TaskCondition;
    bool isShown = false;
    [SerializeField] string thisTaskCondition;
    [SerializeField] GameObject parent;
    [SerializeField] double minNumberAnswer;
    [SerializeField] double maxNumberAnswer;
    [SerializeField] string textAnswer;
    [SerializeField] string textNumerator;
    [SerializeField] string textDenomerator;
    private void Start()
    {
        nameOfThisTask = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void ShowTask()
    {
        
        if (!isShown)
        {
            SaveAndLoadCell.ParentName = parent.name;
            ChekingCode.minA = minNumberAnswer;
            ChekingCode.maxA = maxNumberAnswer;
            ChekingCode.inputField1 = textAnswer;
            ChekingCode.inputField2= textNumerator;
            ChekingCode.inputField3 = textDenomerator;
            oldName = nameOfThisTask.text;
            nameOfThisTask.text += "+";
            TaskBody.SetActive(true);
            TaskCondition.text = thisTaskCondition;
            isShown = true;
        }
        else
        {
            nameOfThisTask.text = oldName;
            TaskBody.SetActive(false);
            isShown = false;
        }
    }
}
