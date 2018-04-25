﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireBehavior : MonoBehaviour {

	[SerializeField]Color defaultColor; 
	[SerializeField]Color highlightColor; 
	[SerializeField]float resetDelay = 0.2f;
	AudioSource sound;

	string attempt = "";

	string key1 = "18"; 
	string key2 = "20"; 
	string key3 = "36";  
	string key4 = "47";  
	string key5 = "59"; 
	string key6 = "81"; 
	string key7 = "02"; 
	string key8 = "63";  
	string key9 = "74";  
	string key0 = "95"; 

	void Start () {
		GameObject w1 = GameObject.Find ("Wire1");
		GameObject w2 = GameObject.Find ("Wire2");
		GameObject w3 = GameObject.Find ("Wire3");
		GameObject w4 = GameObject.Find ("Wire4");
		GameObject w5 = GameObject.Find ("Wire5");
		w1.GetComponent<Renderer> ().enabled = false; 
		w2.GetComponent<Renderer> ().enabled = false; 
		w3.GetComponent<Renderer> ().enabled = false; 
		w4.GetComponent<Renderer> ().enabled = false; 
		w5.GetComponent<Renderer> ().enabled = false; 

	}

	void findWires() {
		GameObject w1 = GameObject.Find ("Wire1");
		GameObject w2 = GameObject.Find ("Wire2");
		GameObject w3 = GameObject.Find ("Wire3");
		GameObject w4 = GameObject.Find ("Wire4");
		GameObject w5 = GameObject.Find ("Wire5");
	}
	
	// Update is called once per frame
	void Update () {
		GameObject w1 = GameObject.Find ("Wire1");
		GameObject w2 = GameObject.Find ("Wire2");
		GameObject w3 = GameObject.Find ("Wire3");
		GameObject w4 = GameObject.Find ("Wire4");
		GameObject w5 = GameObject.Find ("Wire5");

		w1.GetComponent<MeshRenderer> ().material.color = Color.red;
		w2.GetComponent<MeshRenderer> ().material.color = Color.green;
		w3.GetComponent<MeshRenderer> ().material.color = Color.blue;
		w4.GetComponent<MeshRenderer> ().material.color = Color.white;
		w5.GetComponent<MeshRenderer> ().material.color = Color.yellow;


		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition); 
			RaycastHit hit; 

			if (Physics.Raycast (ray, out hit, 100)) {
				Debug.Log (hit.transform.gameObject.name); 
			}


			// LEFT WIRE BASE 

			if (hit.transform.gameObject.name == "LeftWireBase1") {
				attempt = attempt + "1";
				Debug.Log (attempt); 
			}

			if (hit.transform.gameObject.name == "LeftWireBase2") {
				attempt = attempt + "2";
				Debug.Log (attempt); 
			}

			if (hit.transform.gameObject.name == "LeftWireBase3") {
				attempt = attempt + "3";
				Debug.Log (attempt); 
			}

			if (hit.transform.gameObject.name == "LeftWireBase4") {
				attempt = attempt + "4";
				Debug.Log (attempt); 
			}

			if (hit.transform.gameObject.name == "LeftWireBase5") {
				attempt = attempt + "5";
				Debug.Log (attempt); 
			}

			// RIGHT WIRE BASE

			if (hit.transform.gameObject.name == "RightWireBase1") {
				attempt = attempt + "6";
				Debug.Log (attempt); 
			}

			if (hit.transform.gameObject.name == "RightWireBase2") {
				attempt = attempt + "7";
				Debug.Log (attempt); 
			}

			if (hit.transform.gameObject.name == "RightWireBase3") {
				attempt = attempt + "8";
				Debug.Log (attempt); 
			}

			if (hit.transform.gameObject.name == "RightWireBase4") {
				attempt = attempt + "9";
				Debug.Log (attempt); 
			}

			if (hit.transform.gameObject.name == "RightWireBase5") {
				attempt = attempt + "0";
				Debug.Log (attempt); 
			}
		}
		if (attempt.Length == 2) {
			if ((attempt == key1) || (attempt == key6)) {
				w1.GetComponent<Renderer> ().enabled = true;
				attempt = "";
			}
			if ((attempt == key2) || (attempt == key7)) {
				w2.GetComponent<Renderer> ().enabled = true;
				attempt = "";
			}
			if ((attempt == key3) || (attempt == key8)) {
				w3.GetComponent<Renderer> ().enabled = true;
				attempt = "";
			}
			if ((attempt == key4) || (attempt == key9)) {
				w4.GetComponent<Renderer> ().enabled = true;
				attempt = "";
			}
			if ((attempt == key5) || (attempt == key0)) {
				w5.GetComponent<Renderer> ().enabled = true;
				attempt = "";
			}
			else {
				attempt = ""; // else reset attempt string
			}
		}
	}
}