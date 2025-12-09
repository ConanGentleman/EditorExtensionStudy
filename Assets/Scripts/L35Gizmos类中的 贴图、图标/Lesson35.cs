using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson35 : MonoBehaviour
{
    public Texture pic;
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 Gizmos绘制贴图
        //Gizmos.DrawGUITexture(new Rect(x, y, w, h), 图片信息);
        #endregion

        #region 知识点二 Gizmos绘制图标
        //图标需要放置在固定文件夹中
        //Assets/Gizmos/中

        //Gizmos.DrawIcon(Vector3.up, "图标名");
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        if (pic != null)
            Gizmos.DrawGUITexture(new Rect(this.transform.position.x, this.transform.position.y, 160, 90), pic);

        Gizmos.DrawIcon(this.transform.position, "MyIcon");
    }

}
