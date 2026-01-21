using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class Lesson38 : EditorWindow
{
    private GameObject objTest1;
    private float value;
    [MenuItem("Unity编辑器拓展/Lesson38/EditorUtility知识讲解")]
    private static void OpenLesson38Win()
    {
        Lesson38 win = EditorWindow.GetWindow<Lesson38>("EditorUtility知识讲解");
        win.Show();
    }

    private void OnGUI()
    {
        #region Lesson39 编辑器默认窗口相关
        if (GUILayout.Button("显示提示窗口"))
        {
            if (EditorUtility.DisplayDialog("测试窗口", "确定一定要做这件事情吗", "一定要做"))
            {
                Debug.Log("确定要做，在这里去处理逻辑");
            }
            else
            {
                Debug.Log("点击了叉叉，不去做");
            }

            Debug.Log("窗口显示完毕");
        }

        if (GUILayout.Button("显示三键提示窗口"))
        {
            int result = EditorUtility.DisplayDialogComplex("三键提示", "显示信息", "选项1", "关闭", "选项2");
            switch (result)
            {
                case 0:
                    Debug.Log("选项1按下了");
                    break;
                case 1:
                    Debug.Log("关闭键按下了");
                    break;
                case 2:
                    Debug.Log("选项2按下了");
                    break;
                default:
                    break;
            }

            Debug.Log("三键窗口显示完毕");
        }

        if (GUILayout.Button("显示更新进度条"))
        {
            value += 0.1f;
            EditorUtility.DisplayProgressBar("进度条标题", "进度条窗口显示内容", value);
            Debug.Log("进度条窗口显示完毕");
        }

        if (GUILayout.Button("关闭进度条"))
        {
            value = 0;
            EditorUtility.ClearProgressBar();
        }

        #endregion

        #region Lesson40 文件面板相关
        //1.显示文件存储面板
        if (GUILayout.Button("打开文件存储面板"))
        {
            string str = EditorUtility.SaveFilePanel("保存我的文件", Application.dataPath, "Test", "txt");
            Debug.Log(str);
            if (str != "")
                File.WriteAllText(str, "123123123123123");
        }
        //2.显示文件存储面板（默认为工程目录中）
        if (GUILayout.Button("打开文件存储面板（仅限工程文件夹下）"))
        {
            string str2 = EditorUtility.SaveFilePanelInProject("保存项目内的文件", "Test2", "png", "自定义文件");
            Debug.Log(str2);
        }
        //3.显示文件夹存储面板
        if (GUILayout.Button("显示文件夹存储面板"))
        {
            string str3 = EditorUtility.SaveFolderPanel("得到一个存储路径（文件夹）", Application.dataPath, "");
            Debug.Log(str3);
        }

        //4.显示打开文件面板
        if (GUILayout.Button("显示打开文件面板"))
        {
            string str4 = EditorUtility.OpenFilePanel("得到一个文件路径", Application.dataPath, "txt");
            if (str4 != "")
            {
                string txt = File.ReadAllText(str4);
                Debug.Log(txt);
            }
        }

        //5.显示打开文件夹面板
        if (GUILayout.Button("显示打开文件夹面板"))
        {
            string str4 = EditorUtility.OpenFolderPanel("得到一个文件路径", Application.dataPath, "");
            if (str4 != "")
            {
                Debug.Log(str4);
            }
        }

        #endregion

        #region Lesson41 其他内容
        objTest1 = EditorGUILayout.ObjectField("想要查找关联资源的对象", objTest1, typeof(GameObject), true) as GameObject;
        if (GUILayout.Button("检索依赖资源"))
        {
            Object[] objs = EditorUtility.CollectDependencies(new Object[] { objTest1 });
            Selection.objects = objs;
        }
        #endregion
    }

    // Start is called before the first frame update
    void Start()
    {
        #region 知识点回顾
        //我们目前已经学习了
        //1.自定义菜单栏拓展
        //2.自定义窗口拓展
        //3.EditorGUI、EditorGUIUtility相关
        //4.Selection公共类
        //5.Event公共类
        //6.Inspector窗口拓展
        //7.Scene窗口拓展（Handles公共类、HandleUtility公共类、Gizmos公共类）
        #endregion

        #region 知识点一 EditorUtility公共类是用来做什么的？
        //它是 Unity 编辑器中的一个实用工具类
        //提供了一系列用于编辑器脚本和自定义编辑器的实用功能
        #endregion

        #region 知识点二 在哪里使用EditorUtility公共类中的相关内容
        //在编辑器相关处都可以使用EditorUtility公共类中的相关内容
        //它主要提供的是一些辅助功能，可以在编辑器拓展开发的任意地方使用
        //但一定注意，它属于编辑器功能，无法被打包出去，只能在Unity编辑器中使用
        #endregion

        #region 知识点三 准备工作
        //EditorUtility可以在任何编辑器功能开发时使用
        //但是为了之后的知识点讲解更方便
        //我们通过一个自定义窗口来进行知识讲解
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
