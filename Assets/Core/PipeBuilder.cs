using UnityEngine;
using System.Collections;

public class PipeBuilder : MonoBehaviour {
	
	public GameObject goPipeStraight;
	public GameObject goPipeAngled;
	
	float discreteUnit=1f;
	
	Vector3 currentCursor=Vector3.zero;
	GameObject currentPipe; 
	Vector3 currentDir=Vector3.zero;
	
	void Start(){
		InitPipe (goPipeStraight);	
	}
	
	public void InitPipe(GameObject g){
		currentPipe = g;
	}
	
	//tester
	void OnGUI(){
		float btnSize=80,margin=15;
		if(GUI.Button (new Rect(margin*2+btnSize,margin,btnSize,btnSize),"^"))	{
			BuildLoc (new Vector3(0,0,1));
		}
		if(GUI.Button (new Rect(margin,margin*2+btnSize,btnSize,btnSize),"<"))	{
			BuildLoc (new Vector3(-1,0,0));
		}
		if(GUI.Button (new Rect(margin*2+btnSize,margin*2+btnSize,btnSize,btnSize),"."))	{
			BuildLoc (new Vector3(0,-1,0));
		}		
		if(GUI.Button (new Rect(margin*3+btnSize*2,margin*2+btnSize,btnSize,btnSize),">"))	{
			BuildLoc (new Vector3(1,0,0));
		}		
		if(GUI.Button (new Rect(margin*2+btnSize,margin*3+btnSize*2,btnSize,btnSize),"v"))	{
			BuildLoc (new Vector3(0,0,-1));
		}		
	}

	void BuildLoc(Vector3 dir){
		GameObject next = goPipeStraight;
		Quaternion rot = currentPipe.transform.rotation;
		if(currentPipe==goPipeAngled){
			
		}else {
			if(rot == Quaternion.identity){
					
			}
		}
		currentPipe = next;
	}
	
	
	void Update () {
	
	}
}
