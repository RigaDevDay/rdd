using UnityEngine;
using System.Collections;

public class Skeleton : MonoBehaviour {

	private Transform camera;
	private float speed = 15;	
	private Animator animator;
	private bool isAttacking = false;
	private int hp = 3;
	private bool isDeath = false;
	private bool isStill = false;
	
	void Start () {
		camera = GameObject.Find ("Capsule").transform;
		animator = transform.GetComponent<Animator>();
		isStill = true;
		animator.Play("Spawn");
		StartCoroutine (Fly ());
	}

	IEnumerator Fly() {
		yield return new WaitForSeconds (0.833f);
		animator.Play("FlyForward");
		isStill = false;
	}

	void Update () {
		if (!isAttacking && !isDeath && !isStill) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, camera.position, step);
			transform.LookAt (camera);
		}
	}

	void OnTriggerEnter(Collider collider) {
		Debug.Log (collider.gameObject.name);
		if (collider.gameObject.name == "Capsule") {
			animator.Play("BiteAttack");
			isAttacking = true;
			StartCoroutine(StartDealDamage());
		}
		if (!isDeath && collider.gameObject.name == "Projectile(Clone)") {
			StartCoroutine(DecreaseHP());
			GameObject.Destroy(collider.gameObject);
		}
	}

	private IEnumerator StartDealDamage() {
		while (true) {
			yield return new WaitForSeconds(0.667f);
			if (gameObject != null && !isDeath) {
				Player.TakeDamage(Random.Range(8, 18));
			}
			yield return new WaitForSeconds(0.5f);
		}
	}

	private IEnumerator DecreaseHP() {
		hp--;
		if (hp <= 0) {
			isDeath = true;
			animator.Play ("Die");
			GameObject.Destroy (gameObject, 1.333f);
			Spawner.DecreaseCounter ();
		} else {
			isStill = true;
			animator.Play ("TakeDamage");
			yield return new WaitForSeconds(0.8f);
			isStill = false;
		}
	}



}
