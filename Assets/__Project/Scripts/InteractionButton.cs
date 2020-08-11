using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static InteractionsScriptableObject;

public class InteractionButton : MonoBehaviour
{
    private TextMeshProUGUI _text;
    private ParticleSystem _particleSystem;

    private InteractionData _interactionData;

    public InteractionData InteractionData
    {
        get => _interactionData;
        set
        {
            _interactionData = value;
            _text.text = _interactionData.label;

            if (_interactionData.particleSystemPrefab != null)
            {
                _particleSystem = Instantiate(_interactionData.particleSystemPrefab,
                        ParticleSystemAnchor.Instance.transform)
                    .GetComponent<ParticleSystem>();
            }
        }
    }

    private void Awake()
    {
        _text = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void OnActionButtonClick()
    {
        if(_particleSystem != null) _particleSystem.Play();
        Cat.Instance.Interact(InteractionData.type);
    }
}
