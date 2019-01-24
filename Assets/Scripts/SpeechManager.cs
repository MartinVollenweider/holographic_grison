using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class SpeechManager : MonoBehaviour
{

	public GameObject labelContainer;
	public GameObject trailContainer;
	public GameObject weatherContainer;
	KeywordRecognizer keywordRecognizer = null;
	Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action> ();

	// Use this for initialization
	void Start ()
	{


		keywords.Add ("Labels on", () => {
			labelContainer.SetActive (true);
		});

		keywords.Add ("Labels off", () => {
			labelContainer.SetActive (false);
		});


		keywords.Add ("Trails on", () => {
	
			trailContainer.SetActive (true);
		});


		keywords.Add ("Trails off", () => {

			trailContainer.SetActive (false);
		});

		keywords.Add ("Weather on", () => {

			weatherContainer.SetActive (true);
		});

		keywords.Add ("Weather off", () => {

			weatherContainer.SetActive (false);
		});
		


		// Tell the KeywordRecognizer about our keywords.
		keywordRecognizer = new KeywordRecognizer (keywords.Keys.ToArray ());

		// Register a callback for the KeywordRecognizer and start recognizing!
		keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
		keywordRecognizer.Start ();
	}

	private void KeywordRecognizer_OnPhraseRecognized (PhraseRecognizedEventArgs args)
	{
		System.Action keywordAction;
		if (keywords.TryGetValue (args.text, out keywordAction)) {
			keywordAction.Invoke ();
		}
	}
}