using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson39 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 显示提示窗口
        //EditorUtility.DisplayDialog("标题", "显示信息", "确定键名");
        //注意：窗口显示会阻塞逻辑
        #endregion

        #region 知识点二 显示三键提示面板
        //  int EditorUtility.DisplayDialogComplex("标题", "显示信息", "按钮1名字", "按钮3名字", "按钮2名字");
        //  返回值 0-按钮1按下 1-按钮3按下 2-按钮2按下
        //注意：窗口显示会阻塞逻辑
        #endregion

        #region 知识点三 进度条相关
        //显示进度条
        //EditorUtility.DisplayProgressBar("进度条", "显示信息", 进制值0~1);
        //关闭进度条
        //EditorUtility.ClearProgressBar();

        //注意：进度条窗口不会卡逻辑，但是需要配合关闭进度条使用
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
