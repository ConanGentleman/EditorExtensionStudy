using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lesson12 : EditorWindow
{
    [MenuItem("Unity�༭����չ/Lesson12/EditorGUIUtilityѧϰ���")]
    private static void OpenLesson12()
    {
        Lesson12 win = EditorWindow.GetWindow<Lesson12>("EditorGUIUtilityѧϰ���");
        win.Show();
    }

    private Texture img;
    private Texture img2;

    private void OnGUI()
    {
        #region Lesson13 ��Դ����
        //������Դ�������Դ�����ڷ���null)
        if (GUILayout.Button("���ر༭��ͼƬ��Դ"))
            img = EditorGUIUtility.Load("EditorTeach.png") as Texture;
        if (img != null)
            GUI.DrawTexture(new Rect(0, 50, 160, 90), img); //��ʾͼƬ

        //������Դ�������Դ�����ڻ�ֱ�ӱ���
        if (GUILayout.Button("���ر༭��ͼƬ��Դ"))
            img2 = EditorGUIUtility.LoadRequired("EditorTeach.png") as Texture;
        if (img2 != null)
            GUI.DrawTexture(new Rect(0, 150, 160, 90), img2);//��ʾͼƬ
        #endregion
    }

    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ EditorGUIUtility��������������ʲô�ģ�
        // Utility��ʵ�õ���˼��EditorGUIUtility �� EditorGUI �е�һ��ʵ�ù�����
        // �ṩ��һЩ EditorGUI ��ص���������API
        // ����ֻ��Ҫѧϰ���е���Գ��õ�����

        // �ٷ��ĵ���https://docs.unity3d.com/ScriptReference/EditorGUIUtility.html
        #endregion

        #region ֪ʶ��� ׼������
        //����һ���Զ���༭������ ����֮��ѧϰEditorGUIUtility��ص�֪ʶ
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }
}
