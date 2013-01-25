using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	private Transform cible;
	private Transform myTransform;
	private float distance;

	// Use this for initialization
	void Start () {
		myTransform = transform;
		cible = GameObject.FindGameObjectWithTag("Joueur").transform;
		distance = 17;
	}
	
	// Update is called once per frame
	void Update () {
		myTransform.LookAt(cible);
		Vector3 position = new Vector3(myTransform.position.x, myTransform.position.y, cible.position.z - distance);
		myTransform.position = position;
	}
}
