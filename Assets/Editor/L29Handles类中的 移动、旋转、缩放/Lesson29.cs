using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson29 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 Handles中的移动轴
        //Vector3 Handles.DoPositionHandle(位置, 角度);
        //Vector3 Handles.PositionHandle(位置, 角度);
        #endregion

        #region 知识点二 Handles中的旋转轴
        //Quaternion Handles.DoRotationHandle(角度, 位置);
        //Quaternion Handles.RotationHandle(角度, 位置);
        #endregion

        #region 知识点三 Handles中的缩放轴
        //Vector3 Handles.DoScaleHandle(缩放, 位置, 角度, HandleUtility.GetHandleSize(位置));
        //Vector3 Handles.ScaleHandle(缩放, 位置, 角度, HandleUtility.GetHandleSize(位置));

        //HandleUtility.GetHandleSize方法的作用是
        //获取给定位置的操纵器控制柄的世界空间大小
        //使用当前相机计算合适的大小
        //它决定了控制柄的缩放大小
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
