using UnityEngine;

namespace PatternStrategy.Trade
{
    public class ArmoryTrading : ITradable
    {
        public void Trade()
        {
            Debug.Log("Weapons and armor for every taste and color. Choose, and quickly.");
        }
    }
}