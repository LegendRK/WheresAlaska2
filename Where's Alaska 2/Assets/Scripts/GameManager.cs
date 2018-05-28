using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /* variables */

    // references
    public GameObject timerReference;

    // variables
    public GameObject timer;
    public float width;
    public float originalScale;

    [SerializeField]
    private float time, rateOfDepletion;

	// Use this for initialization
	void Start ()
    {
        // create the timer and position it
        timer = (GameObject) Instantiate(timerReference, Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 10)), Quaternion.identity);
        width = timer.GetComponent<SpriteRenderer>().bounds.size.x;
        originalScale = timer.transform.localScale.x;
        rateOfDepletion = Time.deltaTime * (originalScale / time);
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        timer.transform.localScale = new Vector3(timer.transform.localScale.x - rateOfDepletion, transform.localScale.y / 2, transform.localScale.z);
	}
}
