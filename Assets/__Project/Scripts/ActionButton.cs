using UnityEngine;
using UnityEngine.UI;

public class ActionButton : MonoBehaviour
{
    private Text _text;
    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            _text.text = _name;
        }
    }

    private void Awake()
    {
        _text = GetComponentInChildren<Text>();
    }

    public void OnActionButtonClick()
    {
        Cat.Instance.Interact(Name);
    }
}
