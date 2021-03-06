﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerButton : MonoBehaviour
{
	public bool hasNewInput = false;
	public string inputButton;

    float timer = 1;
    bool hasPressed = false;
    bool gameSolved = false;
    bool onePressed = false;
    bool twoPressed = false;
    float start_time = 0;
    public TimerLockLEDManager ledManager; 
    public TimerLockLEDManager ledManager2; 
	public bool timerGameSolvedButNetworkBug = false;


    // Use this for initialization
    void Start()
    {
   		
      
    }

    // Update is called once per frame
    void Update()
    {
		if (hasNewInput) {
			Debug.Log ("there is a new input");
			hasNewInput = false;
            
			if (inputButton == "TimerButton2" && onePressed == true) {
				hasPressed = true;
				//twoPressed = true;
			}

			if (inputButton == "TimerButton1") {
				
				onePressed = true;

				StartCoroutine (CountdownTo ((1)));
				//send out a signal to the other button that this has been signaled.


			}
            
		} else if (timerGameSolvedButNetworkBug && gameSolved == false) {
		
			gameSolved = true;
			Debug.Log("Puzzle Solved!!!!!");
			GetComponent<TimerLockLEDManager> ().changeColor = true;
			GameObject[] arr = GameObject.FindGameObjectsWithTag("box2");

			for(int i=0;i<2;i++){
				arr[i].GetComponent<cardboardswitch1>().solved = true;
			}

		}
    }

        IEnumerator CountdownTo(float sec)
        {
            Debug.Log("countdown started for " + sec + "seconds");
            yield return new WaitForSeconds(sec);

        if (hasPressed && gameSolved == false)
            {
                gameSolved = true;
                Debug.Log("Puzzle Solved!!!!!");
				GetComponent<TimerLockLEDManager> ().changeColor = true;
				GameObject[] arr = GameObject.FindGameObjectsWithTag("box2");
				GetComponent<TransformManager> ().hackyFix_TimerLockSolve = true;
				for(int i=0;i<2;i++){
					arr[i].GetComponent<cardboardswitch1>().solved = true;
				}
            }
            else
            {
                Debug.Log("Not on time! Try again! Or you already solved");
                hasPressed = false;
                onePressed = false;
                twoPressed = false;
            }
        }

 
    }
