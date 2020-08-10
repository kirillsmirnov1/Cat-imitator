using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(HorizontalLayoutGroup))]
public class ActionButtons : MonoBehaviour
{
    public string[] buttonNames;
    public GameObject actionButtonPrefab;

    private void Awake()
    {
        foreach (var buttonName in buttonNames)
        {
            var button = Instantiate(actionButtonPrefab, transform).GetComponent<ActionButton>();
            button.Name = buttonName;
        }
    }
}
