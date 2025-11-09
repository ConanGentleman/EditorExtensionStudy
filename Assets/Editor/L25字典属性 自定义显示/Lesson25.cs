using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson25 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识回顾 SerizlizeField特性
        //让私有字段可以被序列化（能够在Unity的Inspector窗口被看到）
        #endregion

        #region 知识点一 如何在Inspector窗口编辑字典成员
        //Unity默认是不支持Dictionary在Inspector窗口被显示的
        //我们只有利用两个List（或数组）成员来间接设置Dictionary
        #endregion

        #region 知识点二 ISerializationCallbackReceiver接口
        //该接口是Unity提供的用于序列化和反序列化时执行自定义逻辑的接口
        //实现该接口的类能够在对象被序列化到磁盘或从磁盘反序列化时执行一些额外代码
        //接口中函数：
        //OnBeforeSerialize: 在对象被序列化之前调用
        //OnAfterDeserialize: 在对象从磁盘反序列化后调用

        //由于我们需要用两个List存储Dictionary的具体值
        //相当于字典中的真正内容是存储在两个List中的
        //所以我们需要在
        //OnBeforeSerialize序列化之前：将Dictionary里的数据存入List中进行序列化
        //OnAfterDeserialize反序列化之后：将List中反序列化出来的数据存储到Dictionary中
        #endregion

        #region 知识点三 利用两个List在Inspector窗口中自定义Dictionary显示
        //由于我们在Inspector窗口中显示的信息的数据来源是List
        //因此我们只需要利用List在Inspector窗口中自定义显示即可
        #endregion

        #region 总结
        //由于Unity中不支持在Inspector窗口直接使用Dictionary
        //因此我们可以利用两个List（或数组）来间接的表达Dictionary成员
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
