using UnityEngine;

public static class GameObjectExtensions
{
    public static bool NullCheck(this GameObject gameObject, Object component, string componentName)
    {
        if (component != null) return true;

        Debug.LogWarning($"{gameObject.name}: missing {componentName}");
        return false;
    }
}