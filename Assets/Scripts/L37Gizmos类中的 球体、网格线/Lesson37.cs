using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson37 : MonoBehaviour
{
    public Mesh mesh;
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 Gizmos绘制球体
        //Gizmos.DrawSphere(中心点, 半径);
        //Gizmos.DrawWireSphere(中心点, 半径);
        #endregion

        #region 知识点二 Gizmos绘制网格线
        //Gizmos.DrawWireMesh(mesh, 位置, 角度);
        #endregion

        #region 知识点三 更多Gizmos相关
        //https://docs.unity3d.com/ScriptReference/Gizmos.html
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(this.transform.position, 2);
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(this.transform.position, 3);//球体网格

        Gizmos.color = Color.yellow;
        if(mesh != null)
            Gizmos.DrawWireMesh(mesh, this.transform.position, this.transform.rotation);
    }
}
