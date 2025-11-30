using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson31 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 Scene中显示GUI
        //Handles.BeginGUI();
        //GUI相关代码
        //Handles.EndGUI();
        #endregion

        #region 知识点二 获取Scene窗口大小
        //获取当前Scene窗口信息
        //SceneView.currentDrawingSceneView
        //它继承自EditorWindow，因此通过position就能得到它的大小
        #endregion

        #region 知识点三 Handles更多内容
        //https://docs.unity3d.com/ScriptReference/Handles.html
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
