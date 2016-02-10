using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {

	public static Spawner spawner;

	private static int maxhp = 100;
	private static int hp = maxhp;
	private static GameObject playerCanvas;
	private static Text hpText;

	void Awake() {
		hpText = GameObject.Find("PlayerCanvas").transform.Find("Hp").GetComponent<Text>();
	}

	// Use this for initialization
	void Start () {
		spawner = GameObject.Find ("Spawner").GetComponent<Spawner> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private static void UpdateHP() {
		hpText.text = "" + hp;
	}

	public static void TakeDamage(int damage) {
		hp -= damage;
		if (isDeath ()) {
			spawner.StopGame();
			hp = maxhp;
		}
		UpdateHP ();
	}

	private static bool isDeath() {
		if (hp <= 0)
			return true;
		return false;
	}

	public static void Reset() {
		hp = maxhp;
		UpdateHP (); 
	}

}
