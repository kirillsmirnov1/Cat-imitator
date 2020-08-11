using UnityEngine;
using UnityEngine.UI;

public class ActionButton : MonoBehaviour
{
    private Text _text;
    private InteractionType _type;
    public InteractionType Type
    {
        get => _type;
        set
        {
            _type = value;
            _text.text = _type.GetDescription();
        }
    }

    private void Awake()
    {
        _text = GetComponentInChildren<Text>();
    }

    public void OnActionButtonClick()
    {
        Cat.Instance.Interact(Type);
    }
}
