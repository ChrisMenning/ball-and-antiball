using UnityEngine;
using System.Collections;

public class antiballmovement : MonoBehaviour {
	// An "anti-ball" 
	
	
	// In the Inspector, drag and drop the ball into ballObject. 
	// It is especially handy to create an empty gameObject in which both your ball and antiball are children.
	public Transform ballObject;
	public float ballXpos;
	public float ballZpos;
	public float ballYpos;
	bool doingThing;

	// Use this for initialization
	void Awake () {
		GetComponent<Renderer> ().enabled = true;
		doingThing = false;
	}

	// Update is called once per frame
	void Update () {
		ballXpos = ballObject.localPosition.x;
		ballZpos = ballObject.localPosition.z;
		ballYpos = ballObject.localPosition.y;

		
		// Setting any of these vectors to -1 causes the anti-ball's movement to mirror that vector of the ballObject's movements.
		// When ballYpos is NOT set to -1, then only the width and depth (but not height) are reversed.
		// Flip BallYpos to -1 to make the Y axis reversed, making up look like down and vice versa.
		transform.localPosition = new Vector3 (ballXpos * -1, ballYpos, ballZpos * -1);
	}
	
	void OnTriggerEnter(Collider other)
	{
		// Do something special in here, like scoring bonus points, or for fun making the ball and anti-ball swap positions.
	}
	void OnTriggerExit (Collider other)
	{
		
	}
}
