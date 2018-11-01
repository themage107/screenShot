using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenShot : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("screenShotCapture");
    }
	
    IEnumerator screenShotCapture()
    {
        while (true)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Application.CaptureScreenshot(@"C:\Users\COMPUTER NAME HERE\Desktop\o.png", 4);
            }

            yield return new WaitForSecondsRealtime(0.016f);
        }
    }
	
}
