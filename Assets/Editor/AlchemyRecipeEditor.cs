using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AlchemyRecipe))]
public class AlchemyRecipeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        AlchemyRecipe alchemyRecipe = (AlchemyRecipe)target;

        EditorGUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();

        // Input 1
        EditorGUILayout.BeginVertical();
        GUILayout.Label("Input 1", new GUIStyle(GUI.skin.label) { alignment = TextAnchor.UpperCenter, fontStyle = FontStyle.Bold, fontSize = 20 });
        GUILayout.FlexibleSpace();
        Texture input1Texture = null;
        if (alchemyRecipe.input1 != null)
        {
            input1Texture = alchemyRecipe.input1.sprite.texture;
        }
        GUILayout.Box(input1Texture, GUILayout.Width(100), GUILayout.Height(100));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("input1"), GUIContent.none, true, GUILayout.Width(100));
        EditorGUILayout.EndVertical();
        
        // Plus
        EditorGUILayout.BeginVertical();
        GUILayout.Label("+", new GUIStyle(GUI.skin.label) { alignment = TextAnchor.MiddleCenter, fontStyle = FontStyle.Bold, fontSize = 20 });
        EditorGUILayout.EndVertical();

        // Input 2
        EditorGUILayout.BeginVertical();
        GUILayout.Label("Input 2", new GUIStyle(GUI.skin.label) { alignment = TextAnchor.UpperCenter, fontStyle = FontStyle.Bold, fontSize = 20 });
        GUILayout.FlexibleSpace();
        Texture input2Texture = null;
        if (alchemyRecipe.input2 != null)
        {
            input2Texture = alchemyRecipe.input2.sprite.texture;
        }
        GUILayout.Box(input2Texture, GUILayout.Width(100), GUILayout.Height(100));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("input2"), GUIContent.none, true, GUILayout.Width(100));
        EditorGUILayout.EndVertical();

        // Equals
        EditorGUILayout.BeginVertical();
        GUILayout.Label("=", new GUIStyle(GUI.skin.label) { alignment = TextAnchor.MiddleCenter, fontStyle = FontStyle.Bold, fontSize = 20 });
        EditorGUILayout.EndVertical();

        // Output
        EditorGUILayout.BeginVertical();
        GUILayout.Label("Output", new GUIStyle(GUI.skin.label) { alignment = TextAnchor.UpperCenter, fontStyle = FontStyle.Bold, fontSize = 20 });
        GUILayout.FlexibleSpace();
        Texture outputTexture = null;
        if(alchemyRecipe.output != null)
        {
            outputTexture = alchemyRecipe.output.sprite.texture;
        }
        GUILayout.Box(outputTexture, GUILayout.Width(100), GUILayout.Height(100));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("output"), GUIContent.none, true, GUILayout.Width(100));
        EditorGUILayout.EndVertical();
        
        GUILayout.FlexibleSpace();
        EditorGUILayout.EndHorizontal();

        // Apply
        serializedObject.ApplyModifiedProperties();
    }
}
