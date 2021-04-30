using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ListTester))]
public class ShowEditor : Editor {
	public override void OnInspectorGUI () {
		serializedObject.Update();
		EditorList.Show(serializedObject.FindProperty("integers"));
		EditorList.Show(serializedObject.FindProperty("vectors"));
		EditorList.Show(serializedObject.FindProperty("objects"));
		serializedObject.ApplyModifiedProperties();
	}

	public static void Show (SerializedProperty list) {
		EditorGUILayout.PropertyField(list);
		EditorGUI.indentLevel += 1;
		if (list.isExpanded) {
			for (int i = 0; i < list.arraySize; i++) {
				EditorGUILayout.PropertyField(list.GetArrayElementAtIndex(i));
			}
		}
		EditorGUI.indentLevel -= 1;
	}

	public static void Show (SerializedProperty list, bool showListSize = true) {
		EditorGUILayout.PropertyField(list);
		EditorGUI.indentLevel += 1;
		if (list.isExpanded) {
			if (showListSize) {
				EditorGUILayout.PropertyField(list.FindPropertyRelative("Array.size"));
			}
			for (int i = 0; i < list.arraySize; i++) {
				EditorGUILayout.PropertyField(list.GetArrayElementAtIndex(i));
			}
		}
		EditorGUI.indentLevel -= 1;
	}
}


