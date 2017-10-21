#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



public class SavePrefabGameObject : MonoBehaviour {


    public KeyCode saveKey = KeyCode.Period;
    Transform selectedGameObject;

    public static int meshCount;

    void Update()
    {
        if (Input.GetKeyDown(saveKey))
        {
            SaveAsset();
        }
    }

    void SaveAsset()
    {

            GameObject prefab = PrefabUtility.CreatePrefab("Assets/AAVR_PaintTools/Advanced Paint/RuntimeGeneratedMeshes/" + this.gameObject.name + meshCount + ".prefab", (GameObject)this.gameObject, ReplacePrefabOptions.ReplaceNameBased);
            //AssetDatabase.AddObjectToAsset(mf.mesh, "Assets/AAVR_PaintTools/Advanced Paint/RuntimeGeneratedMeshes/" + this.gameObject.name + ".prefab");     
    }
    
}
#endif
