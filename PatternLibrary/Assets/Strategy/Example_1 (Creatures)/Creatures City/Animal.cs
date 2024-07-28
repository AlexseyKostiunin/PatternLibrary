using PatternStrategy.Speak;
using PatternStrategy.Trade;
using Sirenix.OdinInspector;

namespace PatternStrategy.Creature
{
    public class Animal : Creature
    {
        private void Awake()
        {
            _speakable = new NoSpeak();
            _tradable = new NoTrading();
        }

        [Button, DisableInEditorMode]
        public void Speak()
        {
            _speakable.Speak();
        }

        [Button, DisableInEditorMode]
        public void Trade()
        {
            _tradable.Trade();
        }
    }
}