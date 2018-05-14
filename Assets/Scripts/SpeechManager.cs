using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class SpeechManager : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer = null;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    // Use this for initialization
    void Start()
    {
        keywords.Add("View Vitals", () =>
        {
            // Call the Menu method on every descendant object.
            this.BroadcastMessage("Menu");
        });

        keywords.Add("Hide Vitals", () =>
        {
            // Call the Menu method on every descendant object.
            this.BroadcastMessage("CloseVitals");
        });

        keywords.Add("Start Procedure", () =>
        {
            // Call the Menu method on every descendant object.
            this.BroadcastMessage("startProcedure");
        });

        keywords.Add("Continue", () =>
        {
            // Call the Menu method on every descendant object.
            this.BroadcastMessage("Continue");
        });

        keywords.Add("Begin", () =>
        {
            // Call the Menu method on every descendant object.
            this.BroadcastMessage("begin");
        });

        keywords.Add("Stop Procedure", () =>
        {
            // Call the Menu method on every descendant object.
            this.BroadcastMessage("stopProcedure");
        });

        keywords.Add("Next Step", () =>
        {
            // Call the Menu method on every descendant object.
            this.BroadcastMessage("next");
        });

        keywords.Add("Previous Step", () =>
        {
            // Call the Menu method on every descendant object.
            this.BroadcastMessage("prev");
        });

        // Tell the KeywordRecognizer about our keywords.
        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());

        // Register a callback for the KeywordRecognizer and start recognizing!
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();
    }

    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;
        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }
}