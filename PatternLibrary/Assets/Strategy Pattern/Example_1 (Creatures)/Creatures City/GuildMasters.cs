using PatternStrategy.Speak;
using PatternStrategy.Trade;
using Sirenix.OdinInspector;

namespace PatternStrategy.Creature
{
    public class GuildMasters : Creature
    {
        private void Awake()
        {
            _speakable = new QuestDialogue();
            _tradable = new SupplyTrading();
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