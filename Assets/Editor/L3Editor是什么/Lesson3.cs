using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lesson3 : EditorWindow
{
    [MenuItem("Unity�༭����չ/Lesson3/EditorGUI֪ʶ���ⴰ��")]
    private static void OpenLesson3()
    {
        Lesson3 win = EditorWindow.GetWindow<Lesson3>("EditorGUI֪ʶ���ⴰ��");
        //win.titleContent = new GUIContent("EditorGUI֪ʶ���ⴰ��");
        win.Show();
    }

    private void OnGUI()
    {
        //�����еĿؼ���ػ��� �߼�������ص�����
    }

    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ�ع� �Լ� ׼������
        //1.֪ʶ�ع�
        //guilayout ��һ��gui�Զ����ֵĹ�����
        //�����еķ�����gui����һģһ���������������ơ���Ӧ����ui�ؼ���
        //ֻ��������gui�Ļ����ϼ������Զ����ֹ���
        //������������ȥ����ui�ؼ���λ�úʹ�С

        //guilayoutoption ����ѡ��
        //�ؼ��Ĺ̶����
        //guilayout.width(300);
        //guilayout.height(200);
        //����ؼ�����С���
        //guilayout.minwidth(50);
        //guilayout.minheight(50);
        //����ؼ��������
        //guilayout.maxwidth(100);
        //guilayout.maxheight(100);
        //������ֹˮƽ��չ
        //guilayout.expandwidth(true);//����
        //guilayout.expandheight(false);//��ֹ
        //guilayout.expandheight(true);//����
        //guilayout.expandheight(false);//��ֹ

        //2.׼������
        //����һ���༭������ 
        #endregion

        #region ֪ʶ�� EditorGUI��ʲô��
        //EditorGUI ���� GUI
        //��һ����Ҫ���ڻ��Ʊ༭����չ UI �Ĺ�����
        //���ṩ��һЩ GUI ��û�е�API
        //��Ҫ�� �༭�������л��õ���һЩ ����ؼ�

        //��EditorGUILayout ������ GUILayout
        //��һ�������Զ����ֹ��ܵ� EditorGUI ���ƹ�����

        //���Ǿ����Ὣ EditorGUI �� GUI ���ʹ�� ������һЩ�༭����չ����
        //�������ڸ���ʱ�����ǻ��õ��Զ����ֹ���
        //������ǽ��������ؽ��� EditorGUILayout �еĹ���
        //EditorGUI�����������������Ҫ�Լ�����λ�ö���

        //��ϸ���ݣ�https://docs.unity.cn/cn/2022.3/ScriptReference/EditorGUILayout.html
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
