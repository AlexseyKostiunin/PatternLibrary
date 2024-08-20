using Sirenix.OdinInspector;
using UnityEngine;

public class Context : MonoBehaviour
{
    public IStrategy ContextStrategy { get; private set; }




    private void Awake()
    {
        ContextStrategy = new Strategy2();
    }

    [Button, DisableInEditorMode]
    public void ExecuteStrategy()
    {
        ContextStrategy.Execute();
    }
}
