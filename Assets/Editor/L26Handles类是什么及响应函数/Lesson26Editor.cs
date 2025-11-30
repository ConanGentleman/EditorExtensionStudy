using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(Lesson26))]
public class Lesson26Editor : Editor
{
    private Lesson26 obj;

    private void OnEnable()
    {
        obj = target as Lesson26;//获取脚本挂载的obj
    }

    private void OnSceneGUI()
    {
        Debug.Log("Scene窗口拓展相关逻辑");

        #region Lesson27 文本、线段、虚线
        //颜色
        Handles.color = new Color(0, 1, 0, 1f);
        //文本
        Handles.Label(obj.transform.position, "测试文本显示");
        //线段
        Handles.DrawLine(obj.transform.position, obj.transform.position + obj.transform.right * 5, 5);
        //虚线
        Handles.color = new Color(0, 0, 1, 1f);
        Handles.DrawDottedLine(obj.transform.position, obj.transform.position + obj.transform.forward * 5, 5);
        #endregion

        #region Lesson28 弧线、圆、立方体，几何体
        //弧线（圆弧）
        Handles.color = Color.white;
        Handles.DrawWireArc(obj.transform.position, Vector3.up, obj.transform.forward, 30, 5);
        Handles.DrawSolidArc(obj.transform.position, obj.transform.up, Quaternion.Euler(0, -15, 0) * obj.transform.forward, 30, 4);
        //圆
        Handles.color = Color.gray;
        Handles.DrawSolidDisc(obj.transform.position, obj.transform.up, 2);
        Handles.DrawWireDisc(obj.transform.position, obj.transform.up, 3);
        //立方体
        Handles.color = Color.red;
        Handles.DrawWireCube(obj.transform.position, Vector3.one);
        //几何体
        //(0,0,0)
        //(1,0,0)
        //(1,0,1)
        //(0,0,z)
        Handles.DrawAAConvexPolygon(Vector3.zero, Vector3.right, Vector3.right + Vector3.forward, Vector3.forward);
        #endregion

        #region Lesson29 移动、旋转、缩放
        //移动
        obj.transform.position = Handles.DoPositionHandle(obj.transform.position, obj.transform.rotation);
        //obj.transform.position = Handles.PositionHandle(obj.transform.position, obj.transform.rotation);
        //旋转
        //obj.transform.rotation = Handles.DoRotationHandle(obj.transform.rotation, obj.transform.position) ;
        obj.transform.rotation = Handles.RotationHandle(obj.transform.rotation, obj.transform.position);
        //缩放
        obj.transform.localScale = Handles.DoScaleHandle(obj.transform.localScale, obj.transform.position, obj.transform.rotation,
                                                         HandleUtility.GetHandleSize(obj.transform.position));

        //obj.transform.localScale = Handles.ScaleHandle(obj.transform.localScale, obj.transform.position, obj.transform.rotation,
        //                                                 HandleUtility.GetHandleSize(Vector3.zero));
        #endregion

        #region Lesson30 自由移动，自由旋转
        //自由移动
        obj.transform.position = Handles.FreeMoveHandle(obj.transform.position, HandleUtility.GetHandleSize(obj.transform.position),
                                                        Vector3.one * 5, Handles.RectangleHandleCap);

        //自由旋转
        obj.transform.rotation = Handles.FreeRotateHandle(obj.transform.rotation, Vector3.zero, HandleUtility.GetHandleSize(Vector3.zero));
        #endregion

        #region Lesson31 显示GUI
        Handles.BeginGUI();
        if (GUILayout.Button("测试按钮"))
        {
            Debug.Log("Scene中的按钮响应");
        }

        float w = SceneView.currentDrawingSceneView.position.width;
        float h = SceneView.currentDrawingSceneView.position.height;

        GUILayout.BeginArea(new Rect(w - 100, h - 100, 100, 100));
        GUILayout.Label("测试文本控件显示");
        if (GUILayout.Button("测试按钮"))
        {
            Debug.Log("Scene中的按钮响应");
        }
        GUILayout.EndArea();

        Handles.EndGUI();
        #endregion
    }
}
