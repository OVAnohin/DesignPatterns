using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/New Ability")]
public class Ability : ScriptableObject
{
    [SerializeField] private AbilityPlaceLogic _placeLogic;
    [SerializeField] private List<AbilityAction> _abilityActions;

    public void ApplyAction(List<Unit> targets)
    {
        foreach (var action in _abilityActions)
        {
            foreach (var target in targets)
            {
                action.Action(target);
            }
        }
    }

    public List<Unit> SelectTargets(Vector2 screenPoint)
    {
        return _placeLogic.TryGetTargets(screenPoint);
    }
}
