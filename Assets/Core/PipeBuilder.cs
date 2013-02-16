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
			
		}
		if(GUI.Button (new Rect(margin,margin*2+btnSize,btnSize,btnSize),"<"))	{
			
		}
		if(GUI.Button (new Rect(margin*2+btnSize,margin*2+btnSize,btnSize,btnSize),"."))	{
			
		}		
		if(GUI.Button (new Rect(margin*3+btnSize*2,margin*2+btnSize,btnSize,btnSize),">"))	{
			
		}		
		if(GUI.Button (new Rect(margin*2+btnSize,margin*3+btnSize*2,btnSize,btnSize),"v"))	{
			
		}		
	}
	
	public void BuildUp(){BuildLoc (new Vector3(1,0,0),Quaternion.Euler (0,0,0),Quaternion.Euler (0,0,-90));}
	public void BuildLeft(){BuildLoc (new Vector3(0,0,1),Quaternion.Euler (0,90,0),Quaternion.Euler (0,-90,-90));}
	public void BuildInto(){BuildLoc (new Vector3(0,-1,0),Quaternion.Euler ());}
	public void BuildRight(){BuildLoc (new Vector3(0,0,-1),Quaternion.Euler (0,90,0),Quaternion.Euler (0,-270,-90));}
	public void BuildDown(){BuildLoc (new Vector3(-1,0,0),Quaternion.Euler ());}
	
	void BuildLoc(Vector3 v,Quaternion rStraight,Quaternion rBent){
			
	}
	
	
	void Update () {
	
	}
}
