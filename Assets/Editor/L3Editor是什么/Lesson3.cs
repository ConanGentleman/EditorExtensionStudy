using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/// <summary>
/// ����Ƕ�ѡö�٣���Ҫ��ÿ����ͬ��ö��Ҫ��ֵΪ2�Ĵη�������������ѡ��
/// </summary>
public enum E_TestType
{
    One = 1,
    Two = 2,
    Three = 4,
    One_and_Two = 1 | 2,
}

public class Lesson3 : EditorWindow
{
    [MenuItem("Unity�༭����չ/Lesson3/EditorGUI֪ʶ���ⴰ��")]
    private static void OpenLesson3()
    {
        Lesson3 win = EditorWindow.GetWindow<Lesson3>("EditorGUI֪ʶ���ⴰ��");
        //win.titleContent = new GUIContent("EditorGUI֪ʶ���ⴰ��");
        win.Show();
    }
    int layer;
    string tag;
    Color color;

    E_TestType type;
    E_TestType type2;

    string[] strs = { "ѡ��123", "ѡ��234", "ѡ��345" };
    int[] ints = { 123, 234, 345 };
    int num = 0;
    private void OnGUI()
    {
        //�����еĿؼ���ػ��� �߼�������ص�����
        //EditorGUI��صĿؼ� ͬ��������Ҫ��OnGUI���н���ʵ�� ���ܱ���ʾ����
        #region Lesson4 �ı��ؼ����㼶��ǩ�ؼ�����ɫ��ȡ�ؼ�
        //�ı��ؼ�
        EditorGUILayout.LabelField("�ı�����", "��������");
        EditorGUILayout.LabelField("�ı�����");
        //�㼶��ǩ�ؼ�
        //layer = EditorGUILayout.LayerField(layer); //����д��ֻ���и�������,û��˵���ı�
        layer = EditorGUILayout.LayerField("�㼶ѡ��", layer);
        //tag = EditorGUILayout.TagField(tag); //����д��ֻ���и�������,û��˵���ı�
        tag = EditorGUILayout.TagField("��ǩѡ��", tag);
        //��ɫ��ȡ�ؼ�
        color = EditorGUILayout.ColorField(new GUIContent("�Զ�����ɫ��ȡ"),
                                            color, true, false, false);
        #endregion

        #region Lesson5 ö��ѡ������ѡ�񡢰��¾ʹ����İ�ť
        //ö��ѡ��
        type = (E_TestType)EditorGUILayout.EnumPopup("ö��ѡ��", type);

        type2 = (E_TestType)EditorGUILayout.EnumFlagsField("ö�ٶ�ѡ", type2);

        //����ѡ��ؼ�
        //����ֵ ��ʵ���������鵱�е�ĳһ��ֵ
        num = EditorGUILayout.IntPopup("������ѡ��", num, strs, ints);
        EditorGUILayout.LabelField(num.ToString());

        //���¾���Ӧ�İ�ť
        if (EditorGUILayout.DropdownButton(new GUIContent("��ť������"), FocusType.Passive))
            Debug.Log("���¾���Ӧ");
        #endregion
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
