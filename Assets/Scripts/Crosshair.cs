using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour
{
		
	public Menu menu;
	private bool zoom = false;
	private bool animate = false;
	private GoTweenConfig config;

	void Start ()
	{
	
	}
	
	void Update ()
	{
		bool isClickable = false;
		RaycastHit[] hits = Physics.RaycastAll (Cardboard.Controller.Head.Gaze, Mathf.Infinity);
		if (hits.Length > 0) {
			foreach (RaycastHit hit in hits) {
				if (hit.collider.tag == "Clickable") {
					isClickable = true;
				}
			}
		}

		if (isClickable) {
			if (!zoom && !animate) { 
				resetConfig (0.35f);
				Go.to (transform, 0.2f, config);
				animate = true;
				zoom = true;
//				GetComponent<SpriteRenderer>().color = Color.green;
			}
		} else {
			if (zoom && !animate) {
				resetConfig (0.16f);
				Go.to (transform, 0.2f, config);
				animate = true;
				zoom = false;
//				GetComponent<SpriteRenderer>().color = Color.black;
			}
		}
		if (transform.eulerAngles.x > 45f && transform.eulerAngles.x < 90f) {
			if (!menu.isShown) {
				if (menu.isAnimating) {
					menu.transform.LookAt (GameObject.Find ("CardboardMain").transform);
					menu.transform.position = this.transform.position;
				} else {
					menu.FadeIn ();
				}
			}
		} else {
			if (menu.isShown) {
				if (!menu.isAnimating) {
					menu.FadeOut ();
				}
			}
		}
			           			          
	}

	private void resetConfig (float scale)
	{
		config = new GoTweenConfig ();
		config.onComplete (originalTween => animate = false);
		config.scale (scale);
	}
}
