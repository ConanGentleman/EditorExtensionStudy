using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson41 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 压缩纹理
        //void EditorUtility.CompressTexture(Texture2D texture, TextureFormat format, TextureCompressionQuality quality);
        //可以将纹理显式压缩为指定的格式

        //该知识点会配合之后的资源导入相关知识点使用
        #endregion

        #region 知识点二 查找对象依赖项
        //object[] EditorUtility.CollectDependencies(Object[] roots);
        //返回对象所依赖的所有资源列表
        #endregion

        #region 知识点三 更多内容
        //https://docs.unity3d.com/ScriptReference/EditorUtility.html
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
