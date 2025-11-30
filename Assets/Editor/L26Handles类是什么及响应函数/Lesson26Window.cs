using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lesson26Window : EditorWindow
{
    [MenuItem("Unity编辑器拓展/Lesson26/打开Scene拓展窗口")]
    private static void OpenLesson26()
    {
        Lesson26Window win = EditorWindow.GetWindow<Lesson26Window>();
        win.Show();
    }

    private void OnEnable()
    {
        SceneView.duringSceneGui += SceneUpdate; //Scene视图每次调用 OnGUI 方法时会触发一次duringSceneGui
    }

    private void OnDestroy()
    {
        SceneView.duringSceneGui -= SceneUpdate;
    }

    private void SceneUpdate(SceneView view)
    {
        Debug.Log("自定义窗口拓展Scene相关内容");
    }
}
