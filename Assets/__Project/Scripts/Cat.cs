using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
public class Cat : MonoBehaviour
{
    public static Cat Instance;

    private Animator _animator;
    private Text _text;
    
    private void Awake()
    {
        Instance = this;
        _animator = GetComponent<Animator>();
        _text = GetComponentInChildren<Text>();
        
        if(_text == null) Debug.LogWarning("No text object in Cat's children");
    }

    /// <summary>
    /// Apply interaction to Cat
    /// </summary>
    public void Interact(InteractionType interaction)
    {
        Debug.Log($"Interaction: {interaction}");
        _animator.SetTrigger(interaction.ToString());
    }
    
    public void SetStatusText(string text)
    {
        if (_text != null) _text.text = text;
    }
}
