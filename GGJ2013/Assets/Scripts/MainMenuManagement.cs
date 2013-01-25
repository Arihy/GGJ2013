using UnityEngine;
using System.Collections;
using System.Threading;

public class MainMenuManagement : MonoBehaviour {
	
	public GUISkin menuSkin;
	public float areaWidth, areaHeight;
	public AudioClip beepSound;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	/*
	void OpenLevel(string level) {
		audio.PlayOneShot(beepSound);
		//yield new WaitForSeconds(0.35);
		Application.LoadLevel(level);
	}
	*/
	
	void OnGUI() {
		GUI.skin = menuSkin;
		float screenX = (float)((Screen.width * 0.5) - (areaWidth * 0.5));
		float screenY = (float)((Screen.height * 0.5) - (areaHeight * 0.5));
		
		GUILayout.BeginArea(new Rect(screenX,screenY+100,areaWidth,areaHeight));
		
		// creation boutons start et quit //
		if(GUILayout.Button("Start game")) {
			Application.LoadLevel("sceneTest");
			//Thread.Sleep(2000);
			//yield new WaitForSeconds(3000);
			//OpenLevel("sceneTest");
		}
		else if(GUILayout.Button("Quit")) {
			Debug.Log("quit");
			Application.Quit();
		}
		
		GUILayout.EndArea();
	}

	//@script RequireComponent(AudioSource);

}
