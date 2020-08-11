using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(HorizontalLayoutGroup))]
public class InteractionsManager : MonoBehaviour
{
    public GameObject actionButtonPrefab;
    public InteractionsScriptableObject interactionsData;

    private void Awake()
    {
        if(actionButtonPrefab == null) Debug.LogWarning($"{gameObject.name}: missing actionButtonPrefab");
        if(interactionsData == null) Debug.LogWarning($"{gameObject.name}: missing interactionsData");
        
        foreach (var interactionData in interactionsData.interactions)
        {
            var button = Instantiate(actionButtonPrefab, transform).GetComponent<InteractionButton>();
            button.InteractionData = interactionData;
        }
    }
}
