using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class lesson1
{
    /// <summary>
    /// �ڲ˵���������Զ���ҳǩ
    /// </summary>
    [MenuItem("Unity�༭����չ/Lesson1/TestFun %#&A")]
    private static void TestFun()
    {
        Debug.Log("TestFun");
    }
    /// <summary>
    /// ��Hierarchy����������Զ���ҳǩ
    /// </summary>
    [MenuItem("GameObject/Lesson1/TestFun2")]
    private static void TestFun2()
    {
        Debug.Log("TestFun2");
    }
    /// <summary>
    /// ��Project����������Զ���ҳǩ
    /// </summary>
    [MenuItem("Assets/Lesson1/TestFun3")]
    private static void TestFun3()
    {
        Debug.Log("TestFun3");
    }
    /// <summary>
    /// ��InspectorΪLesson1_Test�ű��Ҽ���Ӳ˵�
    /// </summary>
    [MenuItem("CONTEXT/Lesson1_Test/Lesson1/�Զ��幦��")]
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
