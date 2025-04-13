using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/// <summary>
/// 如果是多选枚举，需要给每个不同的枚举要赋值为2的次方
/// </summary>
public enum E_TestType
{
    One = 1,
    Two = 2,
    Three = 4,
    One_and_Two = 1 | 2,
}

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

    E_TestType type;
    E_TestType type2;

    string[] strs = { "选择123", "选择234", "选择345" };
    int[] ints = { 123, 234, 345 };
    int num = 0;

    GameObject obj;

    int i;
    int i2;
    float f;
    double d;
    long l;

    string str;
    Vector2 vec2;
    Vector3 vec3;
    Vector4 vec4;

    Rect rect;
    Bounds bounds;
    BoundsInt boundsInt;

    bool isHide;
    bool isHideGroup;

    bool isTog;
    bool isTogLeft;

    bool isTogGroup;

    float fSlider;
    int iSlider;

    float leftV;
    float rightV;

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

        #region Lesson5 枚举选择、整数选择、按下就触发的按钮

        isHide = EditorGUILayout.Foldout(isHide, "折叠控件", false);

        if (isHide)
        {
            //枚举选择
            type = (E_TestType)EditorGUILayout.EnumPopup("枚举选择", type);

            type2 = (E_TestType)EditorGUILayout.EnumFlagsField("枚举多选", type2);

            //整数选择控件
            // strs是每个值的描述
            // ints是每个描述对应的值
            //返回值num 是整数数组当中的某一个值，而不是索引
            num = EditorGUILayout.IntPopup("整数单选框", num, strs, ints);
            EditorGUILayout.LabelField(num.ToString());

            //按下就响应的按钮
            if (EditorGUILayout.DropdownButton(new GUIContent("按钮上文字"), FocusType.Passive))
                Debug.Log("按下就响应");
        }
        #endregion

        #region Lesson6 对象关联、各类型输入

        isHideGroup = EditorGUILayout.BeginFoldoutHeaderGroup(isHideGroup, "折叠组控件");

        if (isHideGroup)
        {
            //对象关联 ----对象变量 = EditorGUILayout.ObjectField(对象变量, typeof(对象类型), 是否允许关联场景上对象资源) as 对象类型;
            obj = EditorGUILayout.ObjectField("关联资源对象", obj, typeof(GameObject), false) as GameObject;
            //各类型输入
            i = EditorGUILayout.IntField("Int输入框", i);
            EditorGUILayout.LabelField(i.ToString());
            l = EditorGUILayout.LongField("long输入框", l);
            f = EditorGUILayout.FloatField("Float 输入：", f);
            d = EditorGUILayout.DoubleField("double 输入：", d);

            str = EditorGUILayout.TextField("Text输入：", str);
            vec2 = EditorGUILayout.Vector2Field("Vec2输入： ", vec2);
            vec3 = EditorGUILayout.Vector3Field("Vec3输入： ", vec3);
            vec4 = EditorGUILayout.Vector4Field("Vec4输入： ", vec4);

            rect = EditorGUILayout.RectField("rect输入： ", rect);//矩形变量
            bounds = EditorGUILayout.BoundsField("Bounds输入： ", bounds);//范围变量
            boundsInt = EditorGUILayout.BoundsIntField("Bounds输入： ", boundsInt);//范围变量（整型）

            //注意：EditorGUILayout中还有一些Delayed开头的输入控件
            //     他们和普通输入控件最主要的区别是：在用户按 Enter 键或将焦点从字段移开之前，返回值不会更改
            i2 = EditorGUILayout.DelayedIntField("Int输入框", i2);
            EditorGUILayout.LabelField(i2.ToString());
        }

        EditorGUILayout.EndFoldoutHeaderGroup();

        #endregion

        #region Lesson7 折叠、折叠组控件
        //在上方Lesson5和Lesson6中使用
        #endregion

        #region Lesson8 开关、开关组控件
        //开关组控件
        isTogGroup = EditorGUILayout.BeginToggleGroup("开关组控件", isTogGroup);
        //开关控件
        isTog = EditorGUILayout.Toggle("开关控件", isTog);
        isTogLeft = EditorGUILayout.ToggleLeft("左侧开关", isTogLeft);
        EditorGUILayout.EndToggleGroup();
        #endregion

        #region Lesson9 滑动条、双块滑动条控件
        //滑动条
        fSlider = EditorGUILayout.Slider("滑动条", fSlider, 0, 10);
        iSlider = EditorGUILayout.IntSlider("整形滑动条", iSlider, 0, 10);
        //双块滑动条
        EditorGUILayout.MinMaxSlider("双块滑动条", ref leftV, ref rightV, 0, 10);
        EditorGUILayout.LabelField(leftV.ToString());
        EditorGUILayout.LabelField(rightV.ToString());
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
