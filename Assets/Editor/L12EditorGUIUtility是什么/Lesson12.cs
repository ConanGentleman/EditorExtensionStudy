using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lesson12 : EditorWindow
{
    [MenuItem("Unity编辑器拓展/Lesson12/EditorGUIUtility学习面板")]
    private static void OpenLesson12()
    {
        Lesson12 win = EditorWindow.GetWindow<Lesson12>("EditorGUIUtility学习面板");
        win.Show();
    }

    private Texture img;
    private Texture img2;

    private Texture img3;

    private void OnGUI()
    {
        #region Lesson13 资源加载
        //加载资源（如果资源不存在返回null)
        if (GUILayout.Button("加载编辑器图片资源"))
            img = EditorGUIUtility.Load("EditorTeach.png") as Texture;
        if (img != null)
            GUI.DrawTexture(new Rect(0, 50, 160, 90), img); //显示图片

        //加载资源（如果资源不存在会直接报错）
        if (GUILayout.Button("加载编辑器图片资源"))
            img2 = EditorGUIUtility.LoadRequired("EditorTeach.png") as Texture;
        if (img2 != null)
            GUI.DrawTexture(new Rect(0, 150, 160, 90), img2);//显示图片
        #endregion

        #region Lesson14 搜索框查询、对象选中提示提示
        //搜索框查询
        if (GUILayout.Button("打开搜索框查询窗口"))
        {
            EditorGUIUtility.ShowObjectPicker<Texture>(null, false, "Editor", 0);
        }

        if (Event.current.commandName == "ObjectSelectorUpdated")
        {
            img3 = EditorGUIUtility.GetObjectPickerObject() as Texture;
            if (img3 != null)
                Debug.Log(img3.name);
        }
        else if (Event.current.commandName == "ObjectSelectorClosed")
        {
            img3 = EditorGUIUtility.GetObjectPickerObject() as Texture;
            if (img3 != null)
                Debug.Log("窗口关闭 - " + img3.name);
        }

        //对象选中提示提示
        if (GUILayout.Button("高亮选中对象"))
        {
            if (img3 != null)
                EditorGUIUtility.PingObject(img3);
        }
        #endregion
    }

    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 EditorGUIUtility公共类是用来做什么的？
        // Utility是实用的意思，EditorGUIUtility 是 EditorGUI 中的一个实用工具类
        // 提供了一些 EditorGUI 相关的其他辅助API
        // 我们只需要学习其中的相对常用的内容

        // 官方文档：https://docs.unity3d.com/ScriptReference/EditorGUIUtility.html
        #endregion

        #region 知识点二 准备工作
        //创建一个自定义编辑器窗口 用于之后学习EditorGUIUtility相关的知识
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }
}
