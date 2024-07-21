using UnityEngine;

namespace PatternStrategy.Speak
{
    public class SimpleDialogue : ISpeakable
    {
        public void Speak()
        {
            Debug.Log("What a wonderful Day.");
        }
    }
}