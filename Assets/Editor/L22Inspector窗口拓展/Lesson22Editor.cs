using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
//通过这个特性，我们就可以为Lesson22脚本自定义Inspector窗口中的显示了
[CustomEditor(typeof(Lesson22))]
public class Lesson22Editor : Editor
{
    private SerializedProperty atk;
    private SerializedProperty def;
    private SerializedProperty obj;

    private bool foldOut;

    private void OnEnable()
    {
        atk = serializedObject.FindProperty("atk"); //关联Lesson22中的对应变量，serializedObject代表的就是Lesson22.cs
        def = serializedObject.FindProperty("def");
        obj = serializedObject.FindProperty("obj");
    }

    //  该函数控制了Inspector窗口中显示的内容
    //  只需要在其中重写内容便可以自定义窗口
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        serializedObject.Update(); //需要用Update()和ApplyModifiedProperties()进行包裹
        //自定义Inspector窗口的内容
        foldOut = EditorGUILayout.BeginFoldoutHeaderGroup(foldOut, "基础属性"); //折叠控件（头）
        if(foldOut)
        {
            if(GUILayout.Button("测试自定义Inspector窗口"))
            {
                Debug.Log(target.name);
            }
            EditorGUILayout.IntSlider(atk, 0, 100, "攻击力");
            def.floatValue = EditorGUILayout.FloatField("防御力", def.floatValue);
            EditorGUILayout.ObjectField(obj, new GUIContent("敌对对象"));
        }
        EditorGUILayout.EndFoldoutHeaderGroup(); //折叠控件（尾）
        serializedObject.ApplyModifiedProperties();
    }
}
