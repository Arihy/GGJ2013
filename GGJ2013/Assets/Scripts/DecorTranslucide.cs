using UnityEngine;
using System.Collections;

public class DecorTranslucide : MonoBehaviour {
	private Transform cible;
	private Transform myTransform;

	// Use this for initialization
	void Start () {
		cible = GameObject.FindGameObjectWithTag("Joueur").transform;
		myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(cible.position.z > myTransform.position.z + myTransform.localScale.z)
		{
			renderer.material.shader = Shader.Find("Transparent/Diffuse");
		}
		else
		{
			renderer.material.shader = Shader.Find("Diffuse");
		}
	}
}
