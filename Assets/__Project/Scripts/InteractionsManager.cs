using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(HorizontalLayoutGroup))]
public class InteractionsManager : MonoBehaviour
{
    public GameObject actionButtonPrefab;
    public InteractionsScriptableObject interactionsData;

    private void Awake()
    {
        gameObject.NullCheck(actionButtonPrefab, "actionButtonPrefab");
        gameObject.NullCheck(interactionsData, "interactionsData");

        foreach (var interactionData in interactionsData.interactions)
        {
            var button = Instantiate(actionButtonPrefab, transform).GetComponent<InteractionButton>();
            button.InteractionData = interactionData;
        }
    }
}
