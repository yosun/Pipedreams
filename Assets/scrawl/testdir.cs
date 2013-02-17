using UnityEngine;
using System.Collections;

public class testdir : MonoBehaviour {

	public Material matUp;
	public Material matForward;
	public Material matRight;
	
	public GameObject goDup;
	
	// Use this for initialization
	void Start () {
		GameObject g = Instantiate(goDup,Vector3.zero + goDup.transform.up,Quaternion.identity) as GameObject;
		g.renderer.material = matUp;
		g.name = matUp.name;
		
		g = Instantiate(goDup,Vector3.zero + goDup.transform.forward,Quaternion.identity) as GameObject;
		g.renderer.material = matForward;
		g.name = matForward.name;
		
		g = Instantiate(goDup,Vector3.zero + goDup.transform.right,Quaternion.identity) as GameObject;
		g.renderer.material = matRight;
		g.name = matRight.name;
	}
	
}
