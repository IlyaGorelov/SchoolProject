using TMPro;
using UnityEngine;

public class MainMenuTextChange : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
   public void Management()
    {
        text.text = " F1 - зафиксиировать камеру \n F3 - удалить сохранения \n F5 - калькулятор \n F8 - показать условие";
    }
    public void SI()
    {
        text.text = " Пишите все ответы в единицах СИ, если в условии ничего про это не написано: \n Скорость - м/с \n Масса - кг\n Время - с \n Работа - Дж\n Расстояние - м\n Мощность - Вт\n Сила - Н\n";
    }
    public void Decor()
    {
        text.text = " 1. Если ответ предпологает слово - пишите 0 в первой клетке.\n 2. Нажмите в пустой клетке /, чтобы вызвать дробь. \n 3.Пишите в ответе целые или десятичные числа, отделяйте дробную чачсть запятой";
    }
}
