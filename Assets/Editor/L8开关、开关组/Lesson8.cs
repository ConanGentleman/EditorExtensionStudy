using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 开关控件
        //bool变量 = EditorGUILayout.Toggle("普通开关", bool变量);

        //bool变量 = EditorGUILayout.ToggleLeft("开关在左侧", bool变量);
        #endregion

        #region 知识点二 开关组控件
        //bool变量 = EditorGUILayout.BeginToggleGroup("开关组", bool变量);
        //其他控件绘制
        //EditorGUILayout.EndToggleGroup();
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
