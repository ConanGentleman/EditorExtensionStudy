using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson24 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 自定义属性 在Inspector窗口显示 基础方式
        //主要知识点：
        //EditorGUILayout.PropertyField(SerializedProperty对象, 标题);
        //该API会按照属性类型自己去处理控件绘制的逻辑
        #endregion

        #region 知识点二 自定义属性 在Inspector窗口显示 自定义方式
        //如果我们不想要Unity默认的绘制方式去显示 自定义数据结构类 相关内容
        //我们也可以完全自定义布局方式
        //主要知识点：
        //1.SerializedProperty.FindPropertyRelative(属性)
        //2.serializedObject.FindProperty(属性.子属性)
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
