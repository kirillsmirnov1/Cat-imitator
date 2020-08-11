using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Cat : MonoBehaviour
{
    public static Cat Instance;

    private Animator _animator;
    
    private void Awake()
    {
        Instance = this;
        _animator = GetComponent<Animator>();
    }

    /// <summary>
    /// Apply interaction to Cat
    /// </summary>
    public void Interact(InteractionType interaction)
    {
        Debug.Log($"Interaction: {interaction}");
        _animator.SetTrigger(interaction.ToString());
    }
}
