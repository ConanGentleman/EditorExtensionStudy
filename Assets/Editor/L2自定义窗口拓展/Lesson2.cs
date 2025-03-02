using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lesson2 : EditorWindow
{
    [MenuItem("Unity�༭����չ/Lesson2/��ʾ�Զ������")]
    private static void ShowWindow()
    {EditorWindow.GetWindow<Lesson2>();
        Lesson2 win = EditorWindow.GetWindow<Lesson2>(); //��ȡ���ڣ�Ψһ�������ϣ���ж�����ڵĻ�ʹ��EditorWindow.CreateWindow<Lesson2>();
        win.titleContent = new GUIContent("�ҵĴ���"); //��������
        win.Show(); //��ʾ����
    }

    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ ����������
        //�����ռ䣺UnityEditor
        //������EditorWindow

        //��������ҪΪUnity��չһ���Զ��崰��ʱ
        //����ֻ��Ҫʵ��һ���̳���EditorWindow���༴��
        //�����ڸ����OnGUI�����б�д���ؼ���ص��߼�
        #endregion

        #region ֪ʶ��� ��ʾ����
        //���Ͻڿ�ѧϰ������Զ���ҳǩ��֪ʶ
        //���һ���Զ���ҳǩ���ڿ�������
        //����
        //EditorWindow.GetWindow

        //�÷����кܶ�������
        //���е���Ҫ����һ����
        //Type��T�������������
        //utility��Ϊ true �ɴ�������ʵ�ó��򴰿ڣ�����Ϊ false �ɴ����������ڡ���ν�������ھ��ǿ��������϶����ɸı��С
        //title�����ڱ���
        //focus���Ƿ�Ϊ�����ṩ���㣨����Ѵ��ڣ�������� GetWindow �����´��ڣ���ʼ�ջ�ý��㣩
        //desiredDockNextTo:������ͼͣ�������ϵ� EditorWindow ���͵�����

        //�������ڶ���
        //֮����ö����Show����������ʾ����
        #endregion

        #region ֪ʶ���� �����¼��ص�����
        //�̳�EditorWindow�Ĵ����� �Դ�һЩ�¼��ص�����
        //��������Ӧ�¼�ʱ���Զ�����
        //OnHierarchyChange():�������еĲ�νṹ��Hierarchy�������仯ʱ���á�
        //                    ���磬����Ϸ���󱻴�����ɾ����������ʱ������
        //OnFocus():�����ڻ�ý���ʱ���á�
        //          ����������У������ִ��һЩ�ڴ��ڻ�ý���ʱ��Ҫ���еĲ�����
        //OnLostFocus():������ʧȥ����ʱ���á�
        //              ͨ�������������ִ��һЩ�ڴ���ʧȥ����ʱ��Ҫ���е���������
        //OnProjectChange():����Ŀ��Դ�����仯ʱ���á�
        //                  ���磬����ӡ�ɾ�����޸���Ŀ�е��ļ�ʱ������
        //OnInspectorUpdate():�ڼ�������Inspector��������ʱ���á�
        //                    ���������������ִ����Ҫ�ڼ��������ˢ��ʱ���е��߼������������ʾ����Ϣ
        //OnSelectionChange():��ѡ��Ķ������仯ʱ���á�
        //                    ����������У������ִ������ѡ������صĲ�������ȷ���༭�����ڵ������뵱ǰѡ�񱣳�ͬ����
        #endregion

        #region ֪ʶ���� �����г��õ��������ں���
        //OnEnable():
        //�����ڱ�����ʱ���ã�ͨ���ڴ��ڴ���ʱ�����һ�Ρ�
        //����������У�����Խ���һЩ��ʼ������������ע���¼������������ó�ʼ������
        //OnGUI():
        //ÿ֡������ô˷��������ڻ��Ʊ༭�����ڵ� GUI��
        //����������У������ʹ�� GUILayout �� EditorGUILayout ���ഴ������Ԫ�أ��Ա��û��봰�ڽ��н�����
        //OnDestroy():
        //�����ڱ�����ʱ���ã�ͨ���ڹرձ༭�����л�����ʱ������������������յ���������ȷ��û��δ�ͷŵ���Դ��
        //Update():
        //�ڱ༭������ÿ֡����ʱ���á�ͨ��������ִ��һЩ��Ҫ��ÿ֡���е��߼�
        #endregion

        #region ֪ʶ���� �༭���������еĳ��ó�Ա
        //Unity�ٷ��ĵ��й��ڱ༭���������API˵��
        //https://docs.unity.cn/cn/2022.3/ScriptReference/EditorWindow.html

        //��̬����
        //1.focusedWindow����ǰ�ѻ�ü��̽���� EditorWindow����ֻ����
        //2.mouseOverWindow����ǰ��������µ� EditorWindow����ֻ����

        //��̬����
        //CreateWindow: �������ڣ��������һ�������ж�������ø�API��������
        //GetWindow: ͨ�������ǿ��Դ���һ�����ڶ���
        //GetWindowWithRect������һ��ָ��λ�á���С�Ĵ���
        //HasOpenInstances�����༭�������Ƿ��

        //��Ա����
        //titleContent�����ڱ�����
        //positon������λ�ô�С��Ϣ
        //wantsMouseEnterLeaveWindow:�������Ϊ true����ÿ����������뿪����ʱ���ô��ڶ����յ�һ�� OnGUI ����

        //��Ա����
        //Show: ��ʾ���
        //Repaint���ػ洰��
        //Close: �رմ���
        #endregion

        #region �ܽ�
        //�༭����չ����Ҫʵ���Զ��崰��
        //ֻ��Ҫ�̳�EditorWindow��
        //��Ҫ��OnGUI������GUI���API���ƿؼ��������߼�
        //��Ӧ���¼��ص����������԰������Ǽ�����һЩ����������ڴ����Ӧ�߼�
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnHierarchyChange()
    {
        Debug.Log("��Hierarchy�������ݷ����仯ʱ");
    }

    private void OnFocus()
    {
        Debug.Log("��ȡ����");
    }

    private void OnLostFocus()
    {
        Debug.Log("ʧȥ����");
    }

    private void OnProjectChange()
    {
        Debug.Log("��Project�������ݷ����仯ʱ");
    }

    private void OnInspectorUpdate()
    {
        Debug.Log("��Inspector�������ݷ����仯ʱ");
    }

    private void OnSelectionChange()
    {
        Debug.Log("��ѡ�ж������仯ʱ");
    }

    private void OnGUI()
    {
        GUILayout.Label("�����ı�");
        if(GUILayout.Button("���԰�ť"))
        {
            Debug.Log("Test");
        }
    }
}
