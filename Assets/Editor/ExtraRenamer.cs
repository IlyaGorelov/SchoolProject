using UnityEditor;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

//		Extra Renamer Tools v1
//		Утилита группового переименования, выделеных в Hierarchy объектов
//********************************************************************************
//***   Добро пожаловать в наше русское сообщество по Unity3d, CG, и GameDev   ***	
//***   https://vk.com/unity3d_gamedev										   ***
//***	И на наш форум: http://flight-dream.com/forum						   ***
//***   Mimi Neko.															   ***
//********************************************************************************

//Использование:
// - Создайте в вашей папке проекта, папку Editor.
// - поместите в папку Editor, этот скрипт.
// - Выделите в окне Hierarchy объекты, которые требуется переименовать,
// - Откройте меню Edit, и выберете в нём: Extra Renamer Tools (примерно в середине меню)
// - В поле "Неизменная часть имени", введите новое, общее для всех имя выбранных объектов.
// - В поле "Начать с числа", введите начальное числовое значение, которое будет дописано в конце имени первого объекта.
// - В поле "Увеличивать на число", введите приращение дописываемого числа, для каждого объекта.
// - Нажмите кнопку "Предпросмотр", и убедитесь в правильности результата.
// - Если результат вас устраивает - нажмите кнопку "Переименовать", и выбраные объекты, будут переименованы.

// Если требуется к именам дописывать не увеличивающиеся а убывающие числа, - установите галочку "Инкремент".
// Если требуется задать выбранным объектам одинаковое имя
// - очистите поля "Начать с числа" и "Увеличивать на число", от любых символов, и оставте их пустыми.


	//http://docs.unity3d.com/Manual/editor-EditorWindows.html
	//https://unity3d.com/ru/learn/tutorials/modules/intermediate/editor/menu-items
	//http://smilejsu.tistory.com/907
	//http://docs.unity3d.com/ScriptReference/Selection.html
	//http://docs.unity3d.com/ScriptReference/EditorWindow.html

public class ExtraRenamer : EditorWindow {

	private static string patternRenaming;
	private string number = "1", startNumber = "0";
	private bool dec;
	private string text = "";
	private Vector2 scroll;
	private static List<GameObject> selectGo;
	
    [MenuItem("Edit/Extra Renamer Tools", false, 0)]
    private static void Init(){

        //Debug.Log("here: "+ Selection.gameObjects.Length);//Получаем массив выбранных в Hierarchy гейм-объектов
		if(Selection.gameObjects.Length < 1){
			Debug.Log("<b>Не выбраны объекты переименования!</b>");
			return;
		}
		ExtraRenamer window = (ExtraRenamer)EditorWindow.GetWindow (typeof(ExtraRenamer));//Создаём окно
		selectGo = new List<GameObject>(Selection.gameObjects);
		selectGo.Sort(delegate(GameObject o1, GameObject o2){return o1.name.CompareTo(o2.name);});//Сортировка гейм объектов, по имени и алфавиту
		patternRenaming = selectGo[0].name;
		Debug.Log("<b>Выбрано объектов:</b> <color=orange>"+ Selection.gameObjects.Length +"</color>");
    }
	

	void OnGUI(){
	
		GUILayout.Label ("Утилита группового переименования, выделеных \nв Hierarchy объектов:", EditorStyles.boldLabel);
		patternRenaming = EditorGUILayout.TextField("Неизменная часть имени:", patternRenaming, GUILayout.Width(260));
		EditorGUILayout.Space();//отступ
		GUILayout.Label ("Регулярно добавляемое к имени число:", EditorStyles.boldLabel);
		startNumber = EditorGUILayout.TextField("Начать с числа:", startNumber, GUILayout.Width(200));
		number = EditorGUILayout.TextField("Увеличивать на число:", number, GUILayout.Width(200));
		dec = EditorGUILayout.Toggle ("Инкремент", dec);
		EditorGUILayout.Space();//отступ
		
		//TextArea для предварительного просмотра
		text = EditorGUILayout.TextArea(text, GUILayout.Height(100), GUILayout.Width(300));
		
		EditorGUILayout.Space();//отступ
		GUILayout.BeginHorizontal();//горизонтальная группа
		
		//Предварительный просмотр:
		if(GUILayout.Button("Предпросмотр", GUILayout.Width(100))){
		
			int l = 5;
			if(selectGo.Count < l) l = selectGo.Count;
			int n=0, sn=0, x=0;
			bool isNumber = true;
			if(string.IsNullOrEmpty(startNumber) || !int.TryParse(startNumber, out sn)) isNumber = false;
			if(string.IsNullOrEmpty(number) || !int.TryParse(number, out n)) isNumber = false;
			if(isNumber) x = sn;
			text="";
			for(int i=0; i<l; i++){
				if(isNumber){
					text += patternRenaming + x +"\n";
					if(!dec) x += n;
					else x -=n;
				}else text += patternRenaming +"\n";
			}
		}
		
		//Переименование выбранных объектов:
		if(GUILayout.Button("Переименовать", GUILayout.Width(100))){
		
			int l = selectGo.Count;
			int n=0, sn=0, x=0;
			bool isNumber = true;
			if(string.IsNullOrEmpty(startNumber) || !int.TryParse(startNumber, out sn)) isNumber = false;
			if(string.IsNullOrEmpty(number) || !int.TryParse(number, out n)) isNumber = false;
			if(isNumber) x = sn;
			foreach(GameObject go in selectGo){
			
				if(isNumber){
					go.name = patternRenaming + x;
					if(!dec) x += n;
					else x -=n;
				}else go.name = patternRenaming;
			}		
		}
		GUILayout.EndHorizontal();
	}
	
	
}
