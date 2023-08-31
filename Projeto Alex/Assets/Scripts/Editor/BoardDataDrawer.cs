using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;


[CustomEditor(typeof(BoardData), editorForChildClasses: false)]
[CanEditMultipleObjects]
[System.Serializable]

public class BoardDataDrawer : Editor {
    private BoardData GameDataInstace => target as BoardData;

    private ReorderableList _dateList;

    private void OnEnable() {

        InitializeReordableList(ref _dateList, "SearchWords", "Searching Words");
    }

    public override void OnInspectorGUI() {

        serializedObject.Update();

        DrawColumnsRowsInputFields();
        EditorGUILayout.Space();
        ConvertToUpperButton();

        if (GameDataInstace.Board != null && GameDataInstace.Columns > 0 && GameDataInstace.Rows > 0) {
            DrawnBoardTable();

        }

        GUILayout.BeginHorizontal();

        ClearBoardButton();

        FillUpWithRandomLettersButton();

        GUILayout.EndHorizontal();

        EditorGUILayout.Space();

        _dateList.DoLayoutList();


        serializedObject.ApplyModifiedProperties();
        if (GUI.changed) {
            EditorUtility.SetDirty(GameDataInstace);
        }
    }

    private void DrawColumnsRowsInputFields() {

        var columnsTemp = GameDataInstace.Columns;
        var rowsTempo = GameDataInstace.Rows;

        GameDataInstace.Columns = EditorGUILayout.IntField("Columns", GameDataInstace.Columns);

        GameDataInstace.Rows = EditorGUILayout.IntField("Rows", GameDataInstace.Rows);

        if ((GameDataInstace.Columns != columnsTemp || GameDataInstace.Rows != rowsTempo) && GameDataInstace.Columns > 0 && GameDataInstace.Rows > 0) {
            GameDataInstace.CreateNewBoard();
        }
    }

    private void DrawnBoardTable() {

        var tableStyle = new GUIStyle("box");

        tableStyle.padding = new RectOffset(10, 10, 10, 10);

        tableStyle.margin.left = 32;

        var headerColumnsStyle = new GUIStyle();
        headerColumnsStyle.fixedWidth = 35;

        var columnsStyle = new GUIStyle();

        columnsStyle.fixedWidth = 50;

        var rowStyle = new GUIStyle();
        rowStyle.fixedWidth = 40;
        rowStyle.fixedHeight = 25;
        rowStyle.alignment = TextAnchor.MiddleCenter;


        var texFieldSytle = new GUIStyle();

        texFieldSytle.normal.background = Texture2D.grayTexture;
        texFieldSytle.normal.textColor = Color.white;
        texFieldSytle.fontStyle = FontStyle.Bold;
        texFieldSytle.alignment = TextAnchor.MiddleCenter;


        EditorGUILayout.BeginHorizontal(tableStyle);

        for (var x = 0; x < GameDataInstace.Columns; x++) {
            EditorGUILayout.BeginVertical(x == -1 ? headerColumnsStyle : columnsStyle);
            for (var y = 0; y < GameDataInstace.Rows; y++) {
                if (x >= 0 && y >= 0) {
                    EditorGUILayout.BeginHorizontal(rowStyle);

                    var chacacter = (string)EditorGUILayout.TextArea(GameDataInstace.Board[x].Row[y], texFieldSytle);

                    if (GameDataInstace.Board[x].Row[y].Length > 1) {
                        chacacter = GameDataInstace.Board[x].Row[y].Substring(0, 1);

                    }
                    GameDataInstace.Board[x].Row[y] = chacacter;

                    EditorGUILayout.EndHorizontal();

                }
            }

            EditorGUILayout.EndVertical();
        }
        EditorGUILayout.EndHorizontal();


    }

    private void InitializeReordableList(ref ReorderableList list, string propertyName, string listLabel) 
   {

        list = new ReorderableList(serializedObject, serializedObject.FindProperty(propertyName),
            true, true, true, true);

        list.drawHeaderCallback = (Rect rect) => {

            EditorGUI.LabelField(rect, listLabel);
        };

        var l = list;

        list.drawElementCallback = (Rect rect, int index, bool isActive, bool isFocused) => {

            var element = l.serializedProperty.GetArrayElementAtIndex(index);

            rect.y += 2;

            EditorGUI.PropertyField
            (
                new Rect(rect.x, rect.y, EditorGUIUtility.labelWidth, EditorGUIUtility.singleLineHeight),
                element.FindPropertyRelative("Word"), GUIContent.none
            );

        };
    



     }

    private void ConvertToUpperButton() {

    
        if(GUILayout.Button("To Upper")) {

            for(var i=0; i < GameDataInstace.Columns; i++) {


                for(var j = 0; j<GameDataInstace.Rows; j++) {

                    var erroCounter = Regex.Matches(GameDataInstace.Board[i].Row[j], @"[a-z]").Count;

                    if(erroCounter > 0) {
                        GameDataInstace.Board[i].Row[j] = GameDataInstace.Board[i].Row[j].ToUpper();
                    }
                }
            }

            foreach(var searchWord in GameDataInstace.SearchWords) {
                var erroCounter = Regex.Matches(searchWord.Word  , @"[a-z]").Count;

                if(erroCounter > 0) {
                    searchWord.Word = searchWord.Word.ToUpper();
                }

            }

        }

    }

    private void ClearBoardButton() {

        if (GUILayout.Button("Clean Board")) {

            for (int i = 0; i < GameDataInstace.Columns; i++) {


                for (int j = 0; j < GameDataInstace.Rows; j++) {

                    GameDataInstace.Board[i].Row[j] = " "; 
                }
            }
        }

    }


    private void FillUpWithRandomLettersButton() {

        if (GUILayout.Button("Fill Up With Random"))
            {
            for (int i = 0; i < GameDataInstace.Columns; i++) {


                for (int j = 0; j < GameDataInstace.Rows; j++) {

                    int erroCounter = Regex.Matches(GameDataInstace.Board[i].Row[j], @"[a-zA-Z]").Count;
                    string letters = "ABCDEFGHIJKLMNOPQRSTUWXYZ";
                    int index = UnityEngine.Random.Range(0, letters.Length);

                    if(erroCounter == 0) {
                        GameDataInstace.Board[i].Row[j] = letters[index].ToString();
                    }
                }
            }
        }
    }
}




