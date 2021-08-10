using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI VersionDisplay;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Application.persistentDataPath);
        Debug.Log(Application.streamingAssetsPath);

        VersionDisplay.text = "v" + Application.version;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
