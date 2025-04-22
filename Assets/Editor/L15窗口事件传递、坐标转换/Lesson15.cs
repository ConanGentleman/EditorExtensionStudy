using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson15 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 窗口事件传递
        //  Event e = EditorGUIUtility.CommandEvent("事件名");
        //  获取到另一个窗口后，让该窗口调用SendEvent(e) 
        //  在另一个窗口中可以通过
        //  Event.current.type == EventType.ExecuteCommand 判断
        //  Event.current.commandName == "事件名"判断

        //在传递事件时 会自动将接受事件的窗口打开 不管对象是否有监听处理对应的内容
        #endregion

        #region 知识点二 坐标转换
        //  屏幕坐标系：原点为屏幕左上角
        //  GUI坐标系：原点为当前窗口左上角

        //  GUIToScreenPoint:将点从GUI位置转换为屏幕空间
        //  GUIToScreenRect:将rect从GUI位置转换为屏幕空间

        //  ScreenToGUIPoint:将点从屏幕空间转换为GUI位置
        //  ScreenToGUIRect:将rect从屏幕空间转换为GUI位置
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
