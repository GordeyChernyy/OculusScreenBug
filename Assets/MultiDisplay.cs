using UnityEngine;
using System.Collections;

public class MultiDisplay : MonoBehaviour
{
    // Use this for initialization

    
    IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();
        print("hide");
        UnityEngine.XR.XRSettings.showDeviceView = false;
    }


}