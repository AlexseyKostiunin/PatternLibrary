using PatternStrategy.Speak;
using PatternStrategy.Trade;
using Sirenix.OdinInspector;

namespace PatternStrategy.Creature
{
    public class ImperialGuard : Creature
    {
        private void Awake()
        {
            _speakable = new SimpleDialogue();
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