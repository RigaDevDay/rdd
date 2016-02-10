using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tweet : MonoBehaviour {

	private RectTransform tweetContainer;
	private Text textBlock, textTitle;
	private Transform tweetDesc;

	void Start() {
//		GameObject panel = GameObject.Instantiate(panelPrefab, Vector3.zero, Quaternion.Euler(0, 0, 0)) as GameObject;
//		GameObject panel = GameObject.Instantiate (panelPrefab, Vector3.zero, Quaternion.Euler(Vector3(0, 0, 0))) as GameObject;
//		panel.transform.parent = transform;
//		panel.transform.localScale = Vector3 (0.8f, 0.8f, 0.8f);
	}

	public void UpdateTweet(Twitter.Record tweet) {
		Transform imageGO = transform.Find ("Panel").FindChild ("TweetDesc").FindChild ("TweetImage");
		imageGO.gameObject.SetActive (false);

		StartCoroutine (LoadProfilePicture(tweet.profilePicture));
		float resizeDueImage = 0;
		for (int i = 0; i < tweet.media.Count; i++) {
			StartCoroutine(LoadPictures(tweet.media[i], tweet.mediaSize[i]));
			resizeDueImage += tweet.mediaSize[i].y * 260 / tweet.mediaSize[i].x;
		}
		textTitle = transform.FindChild ("Panel").FindChild ("TweetDesc").FindChild ("TweetTitle").GetComponent<Text> ();
		textBlock = transform.FindChild ("Panel").FindChild ("TweetDesc").FindChild ("TweetText").GetComponent<Text> ();
		tweetDesc = transform.FindChild ("Panel").FindChild ("TweetDesc");
		tweetContainer = transform.GetComponent<RectTransform> ();
		textTitle.text = tweet.user + " @" + tweet.username;
		textBlock.text = tweet.text;
		Debug.Log ("PH: " + textBlock.preferredHeight);
		tweetContainer.sizeDelta = new Vector2 (369, textBlock.preferredHeight + textTitle.preferredHeight + resizeDueImage + 50);
		tweetDesc.GetComponent<RectTransform>().sizeDelta = new Vector2(260, textBlock.preferredHeight + textTitle.preferredHeight + resizeDueImage);
	}

	IEnumerator LoadPictures (string url, Vector2 size)
	{
		WWW www = new WWW(url.Replace("\\", ""));
		yield return www;
		Transform imageGO = transform.FindChild ("Panel").FindChild ("TweetDesc").FindChild ("TweetImage");
		Image image = imageGO.gameObject.GetComponent<Image>();
		image.sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), new Vector2(0.5f, 0.5f));
		image.sprite.rect.Set (0, 0, 260, size.y * 260 / size.x);
		imageGO.GetComponent<LayoutElement> ().preferredHeight = size.y * 260 / size.x;
		imageGO.gameObject.SetActive (true);
	}

	IEnumerator LoadProfilePicture(string url) {
		WWW www = new WWW(url.Replace("\\", ""));
		yield return www;
		Transform imageGO = transform.FindChild ("Panel").FindChild ("TweetAvatar");
		Image image = imageGO.gameObject.GetComponent<Image>();
		image.sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), new Vector2(0.5f, 0.5f));
	}
}
