using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 滑动条控件
        //float变量 = EditorGUILayout.Slider("滑动条", float变量, 最小值, 最大值);
        //int变量 = EditorGUILayout.IntSlider("整数值滑动条", int变量, 最小值, 最大值);
        #endregion

        #region 知识点二 双块滑动条控件
        //EditorGUILayout.MinMaxSlider("双块滑动条", ref 左侧值, ref 右侧值, 最小值, 最大值);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
