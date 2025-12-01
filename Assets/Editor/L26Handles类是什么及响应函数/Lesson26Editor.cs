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
        obj = target as Lesson26;
    }

    private void OnSceneGUI()
    {
        //Debug.Log("Scene窗口拓展相关逻辑");

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
        obj.transform.rotation = Handles.DoRotationHandle(obj.transform.rotation, obj.transform.position);
        //obj.transform.rotation = Handles.RotationHandle(obj.transform.rotation, obj.transform.position);
        //缩放
        obj.transform.localScale = Handles.DoScaleHandle(obj.transform.localScale, obj.transform.position, obj.transform.rotation,
                                                         HandleUtility.GetHandleSize(obj.transform.position));

        //obj.transform.localScale = Handles.ScaleHandle(obj.transform.localScale, obj.transform.position, obj.transform.rotation,
        //                                                 HandleUtility.GetHandleSize(Vector3.zero));
        #endregion

        #region Lesson30 自由移动，自由旋转
        //自由移动
        obj.transform.position = Handles.FreeMoveHandle(obj.transform.position, HandleUtility.GetHandleSize(obj.transform.position),
                                                        Vector3.one * 5, Handles.CircleHandleCap);

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

        #region Lesson32 HandleUtility常用API
        //1.GetHandleSize(Vector3 position)
        //  之前学习过 所以不需要举例
        //2.WorldToGUIPoint(Vector3 worldPosition)
        Vector2 pos = HandleUtility.WorldToGUIPoint(obj.transform.position);
        Handles.BeginGUI();
        GUI.Button(new Rect(pos.x, pos.y, 50, 20), "测试按钮");
        Handles.EndGUI();

        //3.GUIPointToWorldRay(Vector2 position)
        Ray r = HandleUtility.GUIPointToWorldRay(Event.current.mousePosition);
        RaycastHit info;
        if (Physics.Raycast(r, out info))
            Debug.Log(info.collider.name);

        //4.DistanceToLine(Vector3 lineStart, Vector3 lineEnd)
        float dis = HandleUtility.DistanceToLine(Vector3.zero, Vector3.right); //离Vector3.zero, Vector3.right线段距离
        //Debug.Log(dis);

        //5.PickGameObject(Vector2 position, bool isSelecting)
        GameObject testObj = HandleUtility.PickGameObject(Event.current.mousePosition, true); //代码可能跟之前的某些代码有冲突，会报错
        if (testObj != null)
            Debug.Log("选择对象的名字：" + testObj.name);
        #endregion
    }
}
