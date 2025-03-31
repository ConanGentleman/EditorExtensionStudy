using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lesson3 : EditorWindow
{
    [MenuItem("Unity编辑器拓展/Lesson3/EditorGUI知识讲解窗口")]
    private static void OpenLesson3()
    {
        Lesson3 win = EditorWindow.GetWindow<Lesson3>("EditorGUI知识讲解窗口");
        //win.titleContent = new GUIContent("EditorGUI知识讲解窗口");
        win.Show();
    }

    int layer;
    string tag;
    Color color;
    private void OnGUI()
    {
        //窗口中的控件相关绘制 逻辑处理相关的内容
        //EditorGUI相关的控件 同样还是需要在OnGUI当中进行实现 才能被显示出来
        #region Lesson4 文本控件、层级标签控件、颜色获取控件
        //文本控件
        EditorGUILayout.LabelField("文本标题", "测试内容");
        EditorGUILayout.LabelField("文本内容");
        //层级标签控件
        //layer = EditorGUILayout.LayerField(layer); //这样写就只会有个下拉框,没有说明文本
        layer = EditorGUILayout.LayerField("层级选择", layer);
        //tag = EditorGUILayout.TagField(tag); //这样写就只会有个下拉框,没有说明文本
        tag = EditorGUILayout.TagField("标签选择", tag);
        //颜色获取控件
        color = EditorGUILayout.ColorField(new GUIContent("自定义颜色获取"),
                                            color, true, false, false);
        #endregion
    }

    // Start is called before the first frame update
    void Start()
    {
        #region 知识回顾 以及 准备工作
        //1.知识回顾
        //guilayout 是一个gui自动布局的公共类
        //它其中的方法和gui基本一模一样，都是用来绘制、响应各种ui控件的
        //只不过它在gui的基础上加入了自动布局功能
        //我们无需过多的去关心ui控件的位置和大小

        //guilayoutoption 布局选项
        //控件的固定宽高
        //guilayout.width(300);
        //guilayout.height(200);
        //允许控件的最小宽高
        //guilayout.minwidth(50);
        //guilayout.minheight(50);
        //允许控件的最大宽高
        //guilayout.maxwidth(100);
        //guilayout.maxheight(100);
        //允许或禁止水平拓展
        //guilayout.expandwidth(true);//允许
        //guilayout.expandheight(false);//禁止
        //guilayout.expandheight(true);//允许
        //guilayout.expandheight(false);//禁止

        //2.准备工作
        //创建一个编辑器窗口 
        #endregion

        #region 知识点 EditorGUI是什么？
        //EditorGUI 类似 GUI
        //是一个主要用于绘制编辑器拓展 UI 的工具类
        //它提供了一些 GUI 中没有的API
        //主要是 编辑器功能中会用到的一些 特殊控件

        //而EditorGUILayout 类似于 GUILayout
        //是一个带有自动布局功能的 EditorGUI 绘制工具类

        //我们经常会将 EditorGUI 和 GUI 混合使用 来制作一些编辑器拓展功能
        //但是由于更多时候我们会用到自动布局功能
        //因此我们接下来着重讲解 EditorGUILayout 中的功能
        //EditorGUI和它的区别仅仅是需要自己设置位置而已

        //详细内容：https://docs.unity.cn/cn/2022.3/ScriptReference/EditorGUILayout.html
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
