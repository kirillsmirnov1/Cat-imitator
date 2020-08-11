using System.ComponentModel;

/// <summary>
/// Available types of interactions with cat.
/// <para>Names of types must match names of triggers in CatAnimationController</para>
/// </summary>
public enum InteractionType
{
    [Description("Поиграть")]
    Play,
    [Description("Накормить")]
    Feed, 
    [Description("Погладить")]
    Pet,
    [Description("Дать пинка")]
    Attack
}
