using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{

	public GameObject[] skeletonPrefabs;
	public GameObject projectile;
	public Transform projectileStartPoint;

	public GameObject playerCanvas { get; set; }

	private List<GameObject> skeletons = new List<GameObject> ();
	private bool isRunning = false;
	private static float spawnTime = 3;
	private static int spawnCount = 1;
	private static int counter = 5;
	private GameObject startGameButton;
	private RuntimePlatform platform;

	private int lastShot = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

	public static void DecreaseCounter ()
	{
		counter--;
		if (counter <= 0) {
			spawnTime -= 0.2f;
			if (spawnTime <= 0.8f) {
				spawnTime = 3;
				spawnCount++;
			}
			counter = 5;
		}
	}

	void Start ()
	{
		startGameButton = GameObject.Find ("Start game");
		playerCanvas = GameObject.Find ("PlayerCanvas");
		playerCanvas.SetActive (false);
		platform = Application.platform;
	}

	void Update ()
	{
		if (platform == RuntimePlatform.Android || platform == RuntimePlatform.IPhonePlayer) {
			if (Input.touchCount > 0) {
				if (Input.GetTouch (0).phase == TouchPhase.Began) {

				}
				if (Input.GetTouch (0).phase == TouchPhase.Moved) {

				}
				if (Input.GetTouch (0).phase == TouchPhase.Ended) {
					if (isRunning) {
						Shot();
					}
				}
			}
		} else if (platform == RuntimePlatform.OSXEditor) {
			if (Input.GetMouseButtonDown (0)) {
				if (isRunning) {
					Shot ();
				}
			}
			if (Input.GetMouseButton (0)) {

			}
			if (Input.GetMouseButtonUp (0)) {

			}
		}
	}

	private void Shot() {
//		int temp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
//		if (temp - lastShot > 250) {
			Instantiate (projectile, projectileStartPoint.position, UnityEngine.Random.rotation);
//			lastShot = temp;
//		}
	}

	public void StopGame ()
	{
		isRunning = false;
		StartCoroutine (RemoveSkeletons ());
		playerCanvas.SetActive (false);
		spawnTime = 3;
		counter = 5;
		spawnCount = 1;
	}

	IEnumerator RemoveSkeletons ()
	{
		if (spawnTime < 2) {
			spawnTime = 2;
		}
		yield return new WaitForSeconds (spawnTime);
		foreach (GameObject skeleton in skeletons) {
			GameObject.Destroy (skeleton);
		}
		startGameButton.SetActive (true);
	}

	public void StartGame ()
	{
		isRunning = true;
		startGameButton.SetActive (false);
		StartCoroutine (Spawn ());
		playerCanvas.SetActive (true);
		Player.Reset ();
	}
	
	IEnumerator Spawn ()
	{
		while (isRunning) {
			for (int i = 0; i < spawnCount; i++) {
				GameObject skeletonGO = Instantiate (skeletonPrefabs[UnityEngine.Random.Range(0, skeletonPrefabs.Length)], new Vector3 (UnityEngine.Random.Range (36f, 78), 0, UnityEngine.Random.Range (-64, -117f)), Quaternion.Euler(0, -32f, 0)) as GameObject;
				skeletons.Add (skeletonGO);
			}
			yield return new WaitForSeconds (spawnTime);
		}
	}

}
