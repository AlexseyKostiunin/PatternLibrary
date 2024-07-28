using UnityEngine;

namespace PatternStrategy.Trade
{
    public class SupplyTrading : ITradable
    {
        public void Trade()
        {
            Debug.Log("Do you want to send a caravan?");
        }
    }
}