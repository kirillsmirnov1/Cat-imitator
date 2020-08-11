using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/InteractionsSO")]
public class InteractionsScriptableObject : ScriptableObject
{
    public InteractionData[] interactions;
    
    [Serializable]
    public struct InteractionData
    {
        public InteractionType type;
        public string label;
        public GameObject particleSystemPrefab;
    }
}
