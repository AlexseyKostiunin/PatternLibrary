using PatternStrategy.Speak;
using PatternStrategy.Trade;
using Sirenix.OdinInspector;

namespace PatternStrategy.Creature
{
    public class ArmsMerchant : Creature
    {
        private void Awake()
        {
            _speakable = new SimpleDialogue();
            _tradable = new ArmoryTrading();
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