using UnityEngine;
using UnityEditor;

public class ObjectSpawner : EditorWindow
{
    private string prefabName;
    private GameObject prefabSpawn;
    private int prefabID = 1;
    private Vector3 spawnLocation;

    [MenuItem("Window/Prefab Spawner")]

    public static void ShowWinow()
    {
        EditorWindow.GetWindow(typeof(ObjectSpawner));
    }

    private void OnGUI()
    {
        GUILayout.Label("Prefab Spawner", EditorStyles.boldLabel);
        GUILayout.Space(10);

        prefabName = EditorGUILayout.TextField("Name", prefabName);
        prefabID = EditorGUILayout.IntField("Prefab ID", prefabID);

        GUILayout.BeginHorizontal();
        spawnLocation = EditorGUILayout.IntField(spawnLocation.x, )

        GUILayout.EndHorizontal();


        prefabSpawn = EditorGUILayout.ObjectField("Spawn a Prefab", prefabSpawn, typeof(GameObject), false) as GameObject;
        
        if (GUILayout.Button("Spawn A Prefab"))
        {
            SpawnPrefab();
            Debug.Log("spawned an prefab");
        }
    }

    private void SpawnPrefab()
    {

    }

    
        
        
}
