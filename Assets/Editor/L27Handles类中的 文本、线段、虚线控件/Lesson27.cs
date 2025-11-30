using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson27 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点回顾 Editor中的target成员
        //我们可以利用继承Editor基类中的target成员获取到拓展的组件对象
        #endregion

        #region 知识点一 Handles中的颜色控制
        //再调用Handles中的绘制API之前 设置颜色即可
        //Handles.color = new Color(0, 1, 1, 0.3f);
        #endregion

        #region 知识点二 Handles中的文本控件
        //Handles.Label(显示位置, 文本内容);
        #endregion

        #region 知识点三 Handles中的线段控件
        //Handles.DrawLine(起点, 终点, 粗细);
        #endregion

        #region 知识点四 Handles中的虚线控件
        //Handles.DrawDottedLine(起点, 终点, 粗细);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
