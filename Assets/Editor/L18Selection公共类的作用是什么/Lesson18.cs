using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEditor;
using UnityEngine;

public class Lesson18 : EditorWindow
{
    [MenuItem("Unity编辑器拓展/Lesson18/Selection学习相关")]
    private static void OpenLesson18()
    {
        Lesson18 win = EditorWindow.GetWindow<Lesson18>("Selection学习窗口");
        win.Show();
    }

    private StringBuilder str = new StringBuilder("没有选择");
    private StringBuilder str2 = new StringBuilder("没有选择");
    private StringBuilder str3 = new StringBuilder("没有选择");
    private StringBuilder str4 = new StringBuilder("没有选择");

    private Object obj;

    private void OnEnable()
    {
        Selection.selectionChanged += SelectionChanged;
    }

    private void OnDestroy()
    {
        Selection.selectionChanged -= SelectionChanged;
    }

    private void OnGUI()
    {
        #region Lesson19 Selection常用静态成员
        //1.当前选择的Object
        if (GUILayout.Button("获取当前选择的Object的名字"))
        {
            if (Selection.activeObject != null)
            {
                str.Clear();
                str.Append(Selection.activeObject.name);

                if (Selection.activeObject is GameObject)
                    Debug.Log("它是游戏对象");
                else if (Selection.activeObject is Texture)
                    Debug.Log("它是一张纹理");
                else if (Selection.activeObject is TextAsset)
                    Debug.Log("它是一个文本");
                else
                    Debug.Log("它是其他类型的资源");
            }
            else
            {
                str.Clear();
                str.Append("没有选择");
            }
        }
        EditorGUILayout.LabelField("当前选择的对象", str.ToString());
        //2.当前选择的GameObject
        if (GUILayout.Button("获取当前选择的GameObject的名字"))
        {
            if (Selection.activeGameObject != null)
            {
                str2.Clear();
                str2.Append(Selection.activeGameObject.name);
            }
            else
            {
                str2.Clear();
                str2.Append("没有选择");
            }
        }
        EditorGUILayout.LabelField("当前选择GameObject对象", str2.ToString());
        //3.当前选择的Transform
        if (GUILayout.Button("获取当前选择的Transform的名字"))
        {
            if (Selection.activeTransform != null)
            {
                str3.Clear();
                str3.Append(Selection.activeTransform.name);
                Selection.activeTransform.position = new Vector3(10, 10, 10);
            }
            else
            {
                str3.Clear();
                str3.Append("没有选择");
            }
        }
        EditorGUILayout.LabelField("当前选择Transform对象", str3.ToString());
        //4.当前选择的所有Object
        if (GUILayout.Button("获取当前选择的所有Object的名字"))
        {
            if (Selection.count != 0)
            {
                str4.Clear();
                for (int i = 0; i < Selection.objects.Length; i++)
                {
                    str4.Append(Selection.objects[i].name + "||");
                }
            }
            else
            {
                str4.Clear();
                str4.Append("没有选择");
            }
        }
        EditorGUILayout.LabelField("当前选择的所有Object对象", str4.ToString());
        //5.当前选择的所有GameObject
        //Selection.gameObjects
        //6.当前选择的所有Transform
        //Selection.transforms
        #endregion

        #region Lesson20 Selection常用静态方法
        //判断某个对象是否被选中
        obj = EditorGUILayout.ObjectField("用于判断是否被选中的对象", obj, typeof(GameObject), true);

        if (GUILayout.Button("判断对象是否被选中"))
        {
            if (Selection.Contains(obj))
                Debug.Log("对象有被选中");
            else
                Debug.Log("对象没有被选中");
        }

        //筛选对象
        if (GUILayout.Button("筛选所有对象"))
        {
            Object[] objs = Selection.GetFiltered(typeof(Object), SelectionMode.Assets | SelectionMode.DeepAssets);
            for (int i = 0; i < objs.Length; i++)
            {
                Debug.Log(objs[i].name);
            }
        }

        //当选中变化时会调用的委托
        //在SelectionChanged中通过Selection.selectionChanged绑定了SelectionChanged函数，当选择对象变化时，调用SelectionChanged()
        #endregion
    }

    private void SelectionChanged()
    {
        Debug.Log("选择的对象变化了");
    }
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 Selection公共类是用来做什么的？
        //主要用来获取当前在Unity编辑器中选择的对象
        //只能用于编辑器开发中
        #endregion

        #region 知识点二 准备工作
        //创建一个自定义编辑器窗口 用于之后学习Selection相关的知识
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }
}
