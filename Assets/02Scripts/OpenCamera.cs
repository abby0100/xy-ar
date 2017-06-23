using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenCamera : MonoBehaviour {

	public RawImage image;
	public WebCamTexture webTex;
	public string deviceName;

	// Use this for initialization
	void Start () {
		Debug.Log ("Start");

		StartCoroutine ("CallCamera");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Update");

		if(webTex != null) {
			image.texture = webTex;
		}
	}

	private IEnumerator CallCamera() {
		Debug.Log ("CallCamera");

		yield return Application.RequestUserAuthorization (UserAuthorization.WebCam);
		if (Application.HasUserAuthorization(UserAuthorization.WebCam)) {
			WebCamDevice[] devices = WebCamTexture.devices;
			deviceName = devices [0].name;
			webTex = new WebCamTexture (deviceName, Screen.width, Screen.height, 20);
			webTex.Play ();
		}
	}
}
