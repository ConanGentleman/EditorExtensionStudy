using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class lesson1
{
    /// <summary>
    /// 在菜单栏中添加自定义页签
    /// </summary>
    [MenuItem("Unity编辑器拓展/Lesson1/TestFun %#&A")]
    private static void TestFun()
    {
        Debug.Log("TestFun");
    }
    /// <summary>
    /// 在Hierarchy窗口中添加自定义页签
    /// </summary>
    [MenuItem("GameObject/Lesson1/TestFun2")]
    private static void TestFun2()
    {
        Debug.Log("TestFun2");
    }
    /// <summary>
    /// 在Project窗口中添加自定义页签
    /// </summary>
    [MenuItem("Assets/Lesson1/TestFun3")]
    private static void TestFun3()
    {
        Debug.Log("TestFun3");
    }
    /// <summary>
    /// 在Inspector为Lesson1_Test脚本右键添加菜单
    /// </summary>
    [MenuItem("CONTEXT/Lesson1_Test/Lesson1/自定义功能")]
    private static void TestFun4()
    {
        Debug.Log("TestFun4");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
