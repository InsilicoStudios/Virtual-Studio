
#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;




public class SaveMeshInEditor : MonoBehaviour
{
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
        var mf = this.transform.GetChild(0).GetComponent<MeshFilter>();
        if (mf)
        {
            var savePath = "Assets/AAVR_PaintTools/Advanced Paint/RuntimeGeneratedMeshes/" + this.transform.name + meshCount + ".asset" ;
            Debug.Log("Saved Mesh to:" + savePath);
            AssetDatabase.CreateAsset(mf.mesh, savePath);
            meshCount++;

            GameObject prefab = PrefabUtility.CreatePrefab("Assets/AAVR_PaintTools/Advanced Paint/RuntimeGeneratedMeshes/" + this.gameObject.name + meshCount + ".prefab", (GameObject)this.gameObject, ReplacePrefabOptions.ReplaceNameBased);
            //AssetDatabase.AddObjectToAsset(mf.mesh, "Assets/AAVR_PaintTools/Advanced Paint/RuntimeGeneratedMeshes/" + this.gameObject.name + ".prefab");

            Destroy(this.transform.GetComponent<SaveMeshInEditor>());
        }
    }
}

#endif