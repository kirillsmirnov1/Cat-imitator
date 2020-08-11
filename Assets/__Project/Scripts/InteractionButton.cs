using UnityEngine;
using UnityEngine.UI;
using static InteractionsScriptableObject;

public class InteractionButton : MonoBehaviour
{
    private Text _text;
    private ParticleSystem _particleSystem;

    private InteractionData _interactionData;

    public InteractionData InteractionData
    {
        get => _interactionData;
        set
        {
            _interactionData = value;
            _text.text = _interactionData.label;
            _particleSystem = Instantiate(_interactionData.particleSystemPrefab).GetComponent<ParticleSystem>();
        }
    }

    private void Awake()
    {
        _text = GetComponentInChildren<Text>();
        _particleSystem = GetComponent<ParticleSystem>();
    }

    public void OnActionButtonClick()
    {
        _particleSystem.Play();
        Cat.Instance.Interact(InteractionData.type);
    }
}
