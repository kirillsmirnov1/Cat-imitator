using UnityEngine;

public class ParticleSystemAnchor : MonoBehaviour
{
    public static ParticleSystemAnchor Instance;

    private void Awake() => Instance = this;
}
