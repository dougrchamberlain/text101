using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour
{

	private bool keyUp;
	private bool keyDown;
	private bool keyReturn;
	public int max;
	public int min;
	public int guess;

	// Use this for initialization
	void Start ()
	{
		StartGame ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		keyUp = Input.GetKeyDown (KeyCode.UpArrow);
		keyDown = Input.GetKeyDown (KeyCode.DownArrow);
		keyReturn = Input.GetKeyDown (KeyCode.Return);
		CheckKeys ();
	}

	void CheckKeys ()
	{
		if (keyUp) {
			min = guess;
			NextGuess();
		} else if (keyDown) {
			max = guess;
			NextGuess();
		} else if (keyReturn) {
			print ("I won!");
			StartGame ();
		}

	}

	void NextGuess ()
	{
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess);
		print ("higher = up arrow, lower = down arrow, correct = enter");
	}

	void StartGame ()
	{
		
		print ("=================================");
		print ("Pick a number in your head, but don't tell me.");
		print ("The highest number you can choose is " + max);
		print ("The lowest number you can choose is " + min);
		print ("Is the number higher or lower than " + guess + "?");
		print ("higher = up arrow, lower = down arrow, correct = enter");

		guess = Random.Range (min, max);
	}
}
