using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{

	private CanvasGroup renderer;
	private float duration = 0.334f;

	public bool isAnimating { get; set; }
	public bool isShown { get; set; } 
	
	void Start ()
	{
		renderer = GetComponent<CanvasGroup> ();
		renderer.alpha = 0;
		isShown = false;
		isAnimating = false;
	}

	void Update ()
	{
	}

	public void ToggleVR ()
	{
		Debug.Log (Cardboard.SDK.VRModeEnabled);
		Cardboard.SDK.VRModeEnabled = !Cardboard.SDK.VRModeEnabled;
		Debug.Log (Cardboard.SDK.VRModeEnabled);
	}

	public void Exit ()
	{
		Application.Quit ();
	}

	public void FadeIn ()
	{
		StopCoroutine ("FadeTo");
		StartCoroutine (FadeTo (1, duration));
	}

	public void FadeOut ()
	{
		StopCoroutine ("FadeTo");
		StartCoroutine (FadeTo (0, duration));
	}

	private IEnumerator FadeTo (float alpha, float time)
	{
		isAnimating = true;
		float elapsedTime = 0;
		
		while (elapsedTime < time) {
			renderer.alpha = Mathf.Lerp (renderer.alpha, alpha, (elapsedTime / time));
			elapsedTime += Time.deltaTime;
			yield return null;
		}
		isAnimating = false;
		if (alpha == 1) {
			isShown = true;
		} else {
			isShown = false;
		}

	}
}
