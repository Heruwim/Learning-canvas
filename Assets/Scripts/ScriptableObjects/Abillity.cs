using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Abillities/New Abillity")]
public class Abillity : ScriptableObject
{
    [SerializeField] private AbillityPlaceLogic _placeLogic;
    [SerializeField] private List<AbillityAction> _abillityActions;

    public void ApplyAction(List<Unit> targets)
    {
        foreach (var action in _abillityActions)
        {
            foreach(var target in targets)
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
