using UnityEngine;
using UnityEditor;

public class VRBuildSettings {
    [MenuItem("VR Build Settings/Build GearVR")]
    static void BuildGearVRSettings()
    {
        PlayerSettings.virtualRealitySupported = true;
        GvrViewer cardboard = (GvrViewer)GameObject.FindGameObjectWithTag("Player").GetComponent<GvrViewer>();
        GvrHead carboardHead = cardboard.gameObject.transform.GetChild(0).GetComponent<GvrHead>();
        
    }
}
