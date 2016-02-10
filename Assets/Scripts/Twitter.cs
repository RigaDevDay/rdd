using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Twitter : MonoBehaviour
{
	public Tweet[] twitterCanvas;
	public static List<Record> tweets = new List<Record> ();
	public static int current = 0;

	private string creds = "H4rqJbwWYMgykvAmc3yq8CPOO:PFBYkJxmA7ST2IpnTukvp0T9AEtEsEVmaNCrFCTfLTrjwXPTsx";
	private string authUrl = "https://api.twitter.com/oauth2/token";
//	private string getTweetsUrl = "https://api.twitter.com/1.1/statuses/user_timeline.json";
	private string getTweetsUrl = "https://api.twitter.com/1.1/statuses/user_timeline.json?count=20&screen_name=RigaDevDay";
	private int lastShownCount = 0;
	private int currentShownCount = 0;
	private int[] shownCounts = new int[20];
	private int page = 0;

	void Start ()
	{
		StartCoroutine (Send ());
	}

	void Update ()
	{
	
	}

	IEnumerator Send ()
	{
		WWWForm form = new WWWForm ();
		form.AddField ("grant_type", "client_credentials");
		Dictionary<string, string> headers = form.headers;
		byte[] rawData = form.data;
//		byte[] rawData = new byte[]{0};
		headers.Add ("Authorization", "Basic " + Base64Encode (creds));
//		headers.Add ("Accept-Encoding", "gzip");
//		headers.Remove ("Content-Type");
//		headers.Add ("Content-Type", "application/x-www-form-urlencoded;charset=UTF-8");

		WWW www = null;
		try {
			www = new WWW (authUrl, rawData, headers);
		} catch(Exception e) {
			Console.WriteLine("ERROR: " + e);
		}
		yield return www;
		Debug.Log (www.ToString ());
		Debug.Log ("Error: " + www.error);
		Debug.Log ("Data: " + www.text);
		Debug.Log ("ResponseHeader: " + www.responseHeaders);

		JSONObject j = new JSONObject (www.text);
		string token = j.GetField ("access_token").Print ().Replace ("\\\"", "").Replace ("\"", "");
		Debug.Log (token);

		form = new WWWForm ();
//		form.AddField ("screen_name", "RigaDevDay");
//		form.AddField ("count", "10");
		rawData = new byte[]{0};
//		rawData = form.data;

		headers = new Dictionary<string, string> ();
		headers = form.headers;

		headers.Add ("Authorization", "Bearer " + token);
//		headers.Add ("Accept-Encoding", "gzip");
//		headers.Remove ("Content-Type");
//		headers.Add ("Content-Type", "application/x-www-form-urlencoded;charset=UTF-8");

		www = new WWW (getTweetsUrl, null, headers);
		yield return www;

		Debug.Log ("Error: " + www.error);
		Debug.Log ("Data: " + www.text);
		Debug.Log ("ResponseHeader: " + www.responseHeaders);
//		.Replace("�", "")
		j = new JSONObject (www.text);
		string str = "";
		if (j.list.Count > 0) {
			foreach (JSONObject tweet in j.list) {
				Record record = new Record ();
				str += tweet.GetField ("created_at") + "\n";
				record.created = tweet.GetField ("created_at").ToString ();
				str += tweet.GetField ("text") + "\n";
				record.text = tweet.GetField ("text").ToString ().Replace ("\\", "");
				if (tweet.GetField ("extended_entities") != null && tweet.GetField ("extended_entities").GetField ("media")) {
					JSONObject media = tweet.GetField ("extended_entities").GetField ("media") [0];
					str += media.GetField ("media_url") + "\n";
					record.media.Add (media.GetField ("media_url").ToString ());
					record.mediaSize.Add (new Vector2 (float.Parse (media.GetField ("sizes").GetField ("small").GetField ("w").ToString ()),
					                                 float.Parse (media.GetField ("sizes").GetField ("small").GetField ("h").ToString ())));
				}
				if (tweet.GetField ("retweeted_status") != null) {
					str += tweet.GetField ("retweeted_status").GetField ("user").GetField ("name") + "\n";
					record.user = tweet.GetField ("retweeted_status").GetField ("user").GetField ("name").ToString ();
					str += tweet.GetField ("retweeted_status").GetField ("user").GetField ("screen_name") + "\n";
					record.username = tweet.GetField ("retweeted_status").GetField ("user").GetField ("screen_name").ToString ();
					str += tweet.GetField ("retweeted_status").GetField ("user").GetField ("profile_image_url_https") + "\n";
					record.profilePicture = tweet.GetField ("retweeted_status").GetField ("user").GetField ("profile_image_url_https").ToString ();
				} else {
					str += tweet.GetField ("user").GetField ("name") + "\n";
					record.user = tweet.GetField ("user").GetField ("name").ToString ();
					str += tweet.GetField ("user").GetField ("screen_name") + "\n";
					record.username = tweet.GetField ("user").GetField ("screen_name").ToString ();
					str += tweet.GetField ("user").GetField ("profile_image_url") + "\n";
					record.profilePicture = tweet.GetField ("user").GetField ("profile_image_url_https").ToString ();
				}
				Debug.Log (str);
				str = "";
				tweets.Add (record);
				CheckButtonAvailability ();
			}
		}

		if (tweets.Count > 0) {
			PostTweets();
		} else {
			for (int i = 0; i < 3; i++) {
				twitterCanvas[i].gameObject.SetActive(false);
			}
		}
	}

	private void PostTweets() {
		if (current > 15) {
			Debug.Log("");
		}
		for (int i = 0; i < 3; i++) {
			twitterCanvas[i].gameObject.SetActive(true);
		}
		int panel = 0;
		int start = current;
		Debug.Log ("Start: " + start);
		bool isPicture = false;
		int currentShownCount = 0;
		int till = (start + 3 > 20) ? 20 : start + 3;
		for (int i = start; i < till; i++) {
			if (tweets[i].media.Count == 0) {
				twitterCanvas[panel].UpdateTweet(tweets[i]);
				panel++;
				current++; 
				currentShownCount++;
			} else if (i == start) {
				twitterCanvas[1].UpdateTweet(tweets[current]);
				current++; 
				twitterCanvas[0].gameObject.SetActive(false);
				twitterCanvas[2].gameObject.SetActive(false);
				currentShownCount++;
				isPicture = true;
				break;
			}
		}
		if (shownCounts[page] == 0) {
			shownCounts[page] = currentShownCount;
		}
		string result = "";
		foreach (int x in shownCounts) {
			result += "" + x;
		}
		Debug.Log (result);
		if (!isPicture) {
			for (int i = 2; i >= currentShownCount; i--) {
				twitterCanvas [i].gameObject.SetActive (false);
			}
		}
	}

	public void OldOne() {
		if (current < tweets.Count) {
			page++;
			PostTweets();
			CheckButtonAvailability();
		}
	}

	public void NewOne() {
		if (current > 0) {
			page--;
			current -= shownCounts[page] + shownCounts[page + 1];
			if (current < 0) {
				current = 0;
			}
			PostTweets();
			CheckButtonAvailability();
		}
	}

	private void CheckButtonAvailability() {
		if (current > 1) {
			GameObject.Find("TwitterCanvas").transform.Find("Left").gameObject.SetActive(true);
		} else {
			GameObject.Find("TwitterCanvas").transform.Find("Left").gameObject.SetActive(false);
		}
		if (current < tweets.Count) {
			GameObject.Find("TwitterCanvas").transform.Find("Right").gameObject.SetActive(true);
		} else {
			GameObject.Find("TwitterCanvas").transform.Find("Right").gameObject.SetActive(false);
		}
	}

	public class Record
	{
		public string user;
		public string username;
		public string created;
		public string text;
		public string profilePicture;
		public List<string> media = new List<string> ();
		public List<Vector2> mediaSize = new List<Vector2> ();
	}

//	RigaDevDay

	private static string Base64Encode (string plainText)
	{
		var plainTextBytes = System.Text.Encoding.UTF8.GetBytes (plainText);
		return System.Convert.ToBase64String (plainTextBytes);
	}
}
