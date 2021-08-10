using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif // UNITY_EDITOR

public class EditorDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #if UNITY_EDITOR
        EditorUtility.IsDirty(gameObject.GetInstanceID());
        #endif // UNITY_EDITOR
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
