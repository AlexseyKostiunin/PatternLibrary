using UnityEngine;

namespace PatternStrategy.Speak
{
    public class NoSpeak : ISpeakable
    {
        public void Speak()
        {
            Debug.Log("I don't speak");
        }
    }
}