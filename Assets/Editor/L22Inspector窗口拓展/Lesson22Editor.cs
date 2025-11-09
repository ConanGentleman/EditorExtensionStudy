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

    private SerializedProperty strs;
    private SerializedProperty ints;
    private SerializedProperty gameObjects;

    private SerializedProperty listObjs;

    private SerializedProperty myCustom;

    private SerializedProperty myCustomI;
    private SerializedProperty myCustomF;

    private SerializedProperty keys;
    private SerializedProperty values;

    private int dicCount;

    private int count;

    private bool foldOut;

    private void OnEnable()
    {
        atk = serializedObject.FindProperty("atk"); //关联Lesson22中的对应变量，serializedObject代表的就是Lesson22.cs
        def = serializedObject.FindProperty("def");
        obj = serializedObject.FindProperty("obj");

        //默认得到的数组和List容量为空
        strs = serializedObject.FindProperty("strs"); 
        ints = serializedObject.FindProperty("ints"); 
        gameObjects = serializedObject.FindProperty("gameObjects"); 
        listObjs = serializedObject.FindProperty("listObjs");

        myCustom = serializedObject.FindProperty("myCustom");
        //myCustomI = myCustom.FindPropertyRelative("i");
        //myCustomF = myCustom.FindPropertyRelative("f");

        myCustomI = serializedObject.FindProperty("myCustom.i");
        myCustomF = serializedObject.FindProperty("myCustom.f");

        keys = serializedObject.FindProperty("keys");
        values = serializedObject.FindProperty("values");

        //初始化当前容量 否则 每次一开始都是0
        count = listObjs.arraySize;

        dicCount = keys.arraySize;
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

            EditorGUILayout.Space(10);

            //容量设置
            count = EditorGUILayout.IntField("List容量", count);

            //是否要缩减 移除尾部的内容
            //从后往前去移除 避免移除不干净
            //当容量变少时 才会走这的逻辑
            for (int i = listObjs.arraySize - 1; i >= count; i--)
                listObjs.DeleteArrayElementAtIndex(i);

            //根据容量绘制需要设置的每一个索引位置的对象
            for (int i = 0; i < count; i++)
            {
                //去判断如果数组或者LIst容量不够 去通过插入的形式去扩容
                if (listObjs.arraySize <= i)
                    listObjs.InsertArrayElementAtIndex(i);

                SerializedProperty indexPro = listObjs.GetArrayElementAtIndex(i);
                EditorGUILayout.ObjectField(indexPro, new GUIContent($"索引{i}"));
            }
            EditorGUILayout.Space(10);
        }

        EditorGUILayout.EndFoldoutHeaderGroup(); //折叠控件（尾）


        EditorGUILayout.PropertyField(strs, new GUIContent("字符串数组")); //不能放到折叠中（因为数组本身自带折叠
        EditorGUILayout.PropertyField(ints, new GUIContent("整形数组")); //不能放到折叠中（因为数组本身自带折叠
        EditorGUILayout.PropertyField(gameObjects, new GUIContent("游戏对象数组")); //不能放到折叠中（因为数组本身自带折叠
        //EditorGUILayout.PropertyField(listObjs, new GUIContent("游戏对象List"));

        EditorGUILayout.PropertyField(myCustom, new GUIContent("我的自定义属性"));

        myCustomI.intValue = EditorGUILayout.IntField("自定义属性中的I", myCustomI.intValue);
        myCustomF.floatValue = EditorGUILayout.FloatField("自定义属性中的F", myCustomF.floatValue);

        dicCount = EditorGUILayout.IntField("字典容量", dicCount);
        //容量变少时 把多的删了
        for (int i = keys.arraySize - 1; i >= dicCount; i--)
        {
            keys.DeleteArrayElementAtIndex(i);
            values.DeleteArrayElementAtIndex(i);
        }

        for (int i = 0; i < dicCount; i++)
        {
            //如果容量不够 扩容
            if (keys.arraySize <= i)
            {
                keys.InsertArrayElementAtIndex(i);
                values.InsertArrayElementAtIndex(i);
            }
            //去真正的自定义键值对的修改
            SerializedProperty indexKey = keys.GetArrayElementAtIndex(i);
            SerializedProperty indexValue = values.GetArrayElementAtIndex(i);
            EditorGUILayout.BeginHorizontal();
            indexKey.intValue = EditorGUILayout.IntField("字典的键", indexKey.intValue);
            indexValue.stringValue = EditorGUILayout.TextField("字典的值", indexValue.stringValue);
            EditorGUILayout.EndHorizontal();
        }

        serializedObject.ApplyModifiedProperties();
    }
}
