using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public Camera hiddenCamera;
    public Camera activeCamera;

    private void Awake()
    {
        var rt = new RenderTexture(Screen.width, Screen.height, 24);
        Shader.SetGlobalTexture("_TimeCrackTexture", rt);
        hiddenCamera.targetTexture = rt;
    }

    public void SwapCameras()
    {

            Debug.Log("LLLL");
            activeCamera.targetTexture = hiddenCamera.targetTexture;
            hiddenCamera.targetTexture = null;

            var swapCams = activeCamera;
            activeCamera = hiddenCamera;
            hiddenCamera = swapCams;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            SwapCameras();
        }
    }
}
