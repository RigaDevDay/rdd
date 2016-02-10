using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float speed = 1f;
	private Vector3 direction;

	void Start () {
		direction = Cardboard.Controller.Head.Gaze.direction * 2;
		GameObject.Destroy (gameObject, 5f);
	}

	void Update () {
		transform.position += direction * Time.deltaTime * speed;
	}

}
