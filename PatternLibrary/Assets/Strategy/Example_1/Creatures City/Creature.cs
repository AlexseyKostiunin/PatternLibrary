using UnityEngine;

namespace PatternStrategy.Creature
{
    public abstract class Creature : MonoBehaviour
    {
        protected ISpeakable _speakable;
        protected ITradable _tradable;
    }
}