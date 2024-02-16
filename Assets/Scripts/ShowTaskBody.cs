using TMPro;
using UnityEngine;

public class ShowTaskBody : MonoBehaviour
{
    [SerializeField] private GameObject TaskBody;
    private TextMeshProUGUI nameOfThisTask;
    private string oldName;
    [SerializeField] private TextMeshProUGUI TaskCondition;
    private bool isShown = false;
    [SerializeField] private string thisTaskCondition;
    [SerializeField] private GameObject parent;
    [SerializeField] private double minNumberAnswer;
    [SerializeField] private double maxNumberAnswer;
    [SerializeField] private string textAnswer;
    [SerializeField] private string textNumerator;
    [SerializeField] private string textDenomerator;

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
            ChekingCode.inputField2 = textNumerator;
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
