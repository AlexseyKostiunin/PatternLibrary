using UnityEngine;

namespace PatternStrategy.Trade
{
    public class NoTrading : ITradable
    {
        public void Trade()
        {
            Debug.Log("I don't Trade");
        }
    }
}