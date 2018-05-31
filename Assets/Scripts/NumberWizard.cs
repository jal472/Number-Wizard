using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max = 1000;
	int min = 1;
	int guess = 500;

	// Use this for initialization
	void Start () {
		initializeGame();
	}
	
	void initializeGame (){
		print ("=========================");
		print ("Welcome to Number Wizard!");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is: "+max);
		print ("And the lowest number you can pick is: "+min);
		
		print ("Is your number higher, lower, or equal to: " + guess + "?");
		print ("Up Arrow (^) for HIGHER, Down Arrow (v) for LOWER, Return for EQUAL");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			if (guess == 999){
				guess = 1000;
				print ("Is your number higher, lower, or equal to: " + guess + "?");
				print ("Up Arrow (^) for HIGHER, Down Arrow (v) for LOWER, Return for EQUAL");
				return;
			}
			min = guess; 
			guess = (max + min) / 2;
			print ("Is your number higher, lower, or equal to: " + guess + "?");
			print ("Up Arrow (^) for HIGHER, Down Arrow (v) for LOWER, Return for EQUAL");
		}else if (Input.GetKeyDown(KeyCode.DownArrow)){
			max = guess;
			guess = (max + min) / 2;
			print ("Is your number higher, lower, or equal to: " + guess + "?");
			print ("Up Arrow (^) for HIGHER, Down Arrow (v) for LOWER, Return for EQUAL");
		}else if (Input.GetKeyDown(KeyCode.Return)){
			print ("I Found Your Number!");
			min = 1;
			max = 1000;
			guess = 500;
			initializeGame();
		}
		
	
	}
}
