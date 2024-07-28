using UnityEngine;

namespace PatternStrategy.Speak
{
    public class QuestDialogue : ISpeakable
    {
        public void Speak()
        {
            Debug.Log("I'm ready to give you a task.");
        }
    }
}