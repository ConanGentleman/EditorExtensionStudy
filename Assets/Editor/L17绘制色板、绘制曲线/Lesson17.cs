using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson17 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 绘制色板
        //在指定区域绘制一个色板矩形
        //EditorGUIUtility.DrawColorSwatch(Rect 绘制色板的矩形, Color 颜色);

        //主要配合 EditorGUILayout.ColorField 颜色输入控件使用
        #endregion

        #region 知识点二 绘制曲线
        //在指定区域绘制曲线
        //EditorGUIUtility.DrawCurveSwatch(Rect 绘制曲线的范围,
        //                                   AnimationCurve 曲线,
        //                                   SerializedProperty 要绘制为SerializedProperty的曲线,
        //                                   Color 绘制曲线的颜色,
        //                                   Color 绘制背景的颜色);

        //主要配合 EditorGUILayout.CurveField 曲线输入控件使用
        #endregion

        #region 知识点三 更多API
        // 官方文档：https://docs.unity3d.com/ScriptReference/EditorGUIUtility.html
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
