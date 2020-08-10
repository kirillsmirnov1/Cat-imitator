using UnityEngine;

public class Cat : MonoBehaviour
{
    public static Cat Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void Interact(string interaction)
    {
        Debug.Log($"Interaction: {interaction}");
    }
}
