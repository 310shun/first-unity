using UnityEngine;
using System.Collections;

public class Controll_Script : MonoBehaviour {

	public GameObject  erin;

	bool  boTouch = false;
	Vector2 tPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			this.boTouch = true;
		}else if(Input .GetMouseButtonUp(0)) {
			this.boTouch = false;
		} 

		if(boTouch){
			this.tPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
	}

	void FixedUpdate(){
		if (this.boTouch) {
			if(erin.transform.position.x < this.tPos.x){
				erin.rigidbody2D.AddForce(Vector2.right * 30);
			}else if(erin.transform.position.x > this.tPos.x){
				erin.rigidbody2D.AddForce(Vector2.right * - 30);
			}
		}
	}
}
