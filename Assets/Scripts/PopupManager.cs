using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class PopupManager : MonoBehaviour
{

	public static bool isPopupShown = false;
	public static GameObject popup;
	public static GameObject popupCanvas;
	public static Speakers speakers = new Speakers ();
	public static int currentDay = 0;
	public static string[] days = new string[2] { "Day1", "Day2" };
	public static GameObject[] daysGO = new GameObject[2];

	void Start ()
	{
		popup = GameObject.Find ("Popup");
		popupCanvas = GameObject.Find ("PopupCanvas");
		StartCoroutine (Disable ());

		CheckButtonAvailability ();
		for (int i = 0; i < days.Length; i++) {
			daysGO[i] = GameObject.Find(days[i]);
		}
	}

	IEnumerator Disable() {
		yield return new WaitForSeconds (0.05f);
		popup.SetActive (false);
	}

	public void ClosePopup() {
		popup.SetActive (false);
		isPopupShown = false;
	}

	public void Before() {
		if (currentDay > 0) {
			currentDay = 0;
			ShowCurrentDay();
		}
	}

	public void After() {
		if (currentDay < days.Length - 1) {
			currentDay = 1;
			ShowCurrentDay();
		}
	}

	private void CheckButtonAvailability() {
		if (currentDay > 0) {
			GameObject.Find("SchedulerBoardCanvas").transform.Find("Before").gameObject.SetActive(true);
		} else {
			GameObject.Find("SchedulerBoardCanvas").transform.Find("Before").gameObject.SetActive(false);
		}
		if (currentDay < days.Length - 1) {
			GameObject.Find("SchedulerBoardCanvas").transform.Find("After").gameObject.SetActive(true);
		} else {
			GameObject.Find("SchedulerBoardCanvas").transform.Find("After").gameObject.SetActive(false);
		}
	}

	private void ShowCurrentDay() {
		HideAllDays ();
		daysGO [currentDay].SetActive (true);
		CheckButtonAvailability ();
	}

	private void HideAllDays() {
		foreach (GameObject day in daysGO) {
			day.SetActive(false);
		}
	}

	public void LoadPopup (string speakerName)
	{
		Dictionary<string, string> speaker = new Dictionary<string, string> ();
		if (speakers.TryGetValue (speakerName, out speaker)) {
			Transform speakerInfo = popup.transform.FindChild("SpeakerInfo");
//			speakerInfo.FindChild ("SpeakerName").GetComponent<Text> ().text = speakerName;
			string data = "";
			float height = 0;
			float heightAdditional = 30;
			Text nameText = speakerInfo.FindChild ("SpeakerName").GetComponent<Text> ();
			if (speaker.TryGetValue ("name", out data)) {
				nameText.text = data;
			} else {
				nameText.text = "There is no topic title found";
			}

			height += nameText.preferredHeight + heightAdditional;
			string name = data;
			Text topicText = speakerInfo.FindChild ("SpeakerTopic").GetComponent<Text> ();
			if (speaker.TryGetValue ("topic", out data)) {
				topicText.text = data;
			} else {
				topicText.text = "There is no topic title found";
			}
			height += topicText.preferredHeight + heightAdditional;
			Text positionText = speakerInfo.FindChild ("SpeakerPosition").GetComponent<Text> ();
			if (speaker.TryGetValue ("position", out data)) {
				positionText.text = data;
			} else {
				positionText.text = "There is no speaker position found";
			}
			height += positionText.preferredHeight + heightAdditional;
			Text descriptionText = speakerInfo.FindChild ("SpeakerDescription").GetComponent<Text> ();
			if (speaker.TryGetValue ("description", out data)) {
				descriptionText.text = data;
			} else {
				descriptionText.text = "There is no speaker description found";
			}
			height += descriptionText.preferredHeight + heightAdditional;
//			speakerName = name.Replace("ä", "a");
//			speakerName = name.Replace("á", "a");
//			speakerName = name.Replace("ó", "o");
			speakerName = Regex.Replace(name, @"[^\u0000-\u007F]", string.Empty);
			popupCanvas.transform.FindChild("Popup").FindChild ("SpeakerAvatar").GetComponent<Image> ().sprite = Resources.Load (speakerName, typeof(Sprite)) as Sprite;
			RectTransform rectTransform = popupCanvas.GetComponent<RectTransform>();
			popup.SetActive (true);
			if (height > 1000) {
				height = height * 0.042f;
			}
			rectTransform.sizeDelta = new Vector2 (575f, height);
			isPopupShown = true;
			Debug.Log ("LoadPopup " + speakerName);
		}
	}
}
