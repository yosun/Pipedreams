using UnityEngine;
using System.Collections;

public class HandTimer : MonoBehaviour {
	
	// TO-DO - add visuals timer
	
	/* 
	 * How to Call...
	 * 
	 * *ExternalScript* detects if hand positive detected then initiate *DetectHand(true)
	 * else *ExternalScript* detects hand neg then *DetectHand(false) 
	 * 
	 * Once *ExternalScript* detects hand: 
	 * check *GetConfirmedStatus() (till timer returns true)
	 * 		if true then *ExternalScript* calls *ResetConfirmedStatus()
	 */
	
	float minTimeConfirm = 5f; bool confirmed=false;
	
	float timeHandDetected=0f;
	bool handDetected=false;
	
	public bool GetConfirmedStatus(){
		return confirmed;
	}
	
	public void ResetConfirmedStatus(){
		confirmed=false;	
	}
	
	public void DetectHand(bool flip){
		if(flip){
			if(handDetected)return;
			else{ 
				confirmed=false;
				handDetected=true;
				timeHandDetected=0f;
			}
		}else{
			handDetected=false;
		}
	}
	
	private void CheckTimer(){
		if(timeHandDetected>minTimeConfirm){
			confirmed=true;
		}
	}

	void Update (){
		if(handDetected){
			timeHandDetected+=Time.deltaTime;
			CheckTimer ();
		}
	}
}
