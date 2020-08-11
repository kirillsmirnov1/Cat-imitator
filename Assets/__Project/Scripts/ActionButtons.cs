using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(HorizontalLayoutGroup))]
public class ActionButtons : MonoBehaviour
{
    public GameObject actionButtonPrefab;

    private void Awake()
    {
        foreach (var interactionType in EnumUtils.GetValues<InteractionType>())
        {
            var button = Instantiate(actionButtonPrefab, transform).GetComponent<ActionButton>();
            button.Type = interactionType;
        }
    }
}
