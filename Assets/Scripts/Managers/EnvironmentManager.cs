using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentManager : MonoBehaviour
{
    //public Material dayMat;
    //public Material nightMat;
    //public GameObject dayLight;
    //public GameObject nightLight;

    //public Color datFog;
    //public Color nightFog;

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 0.5f);
    }
    //private void OnGUI()
    //{
    //    if(GUI.Button(new Rect(5,5,80,20), "Day"))
    //    {
    //        RenderSettings.skybox = dayMat;
    //        RenderSettings.fogColor = datFog;
    //        dayLight.SetActive(true);
    //        nightLight.SetActive(false);
    //    }
    //    if (GUI.Button(new Rect(5, 35, 80, 20), "Day"))
    //    {
    //        RenderSettings.skybox = nightMat;
    //        RenderSettings.fogColor = nightFog;
    //        dayLight.SetActive(false);
    //        nightLight.SetActive(true);
    //    }
    //}
}
