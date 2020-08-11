using UnityEngine;
using UnityEngine.UI;
using static InteractionsScriptableObject;

public class ActionButton : MonoBehaviour
{
    private Text _text;

    private InteractionData _interactionData;

    public InteractionData InteractionData
    {
        get => _interactionData;
        set
        {
            _interactionData = value;
            _text.text = _interactionData.label;
        }
    }

    private void Awake()
    {
        _text = GetComponentInChildren<Text>();
    }

    public void OnActionButtonClick()
    {
        Cat.Instance.Interact(InteractionData.type);
    }
}
