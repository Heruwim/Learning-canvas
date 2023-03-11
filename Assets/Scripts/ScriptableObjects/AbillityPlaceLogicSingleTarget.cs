using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Abillities/Place Logic/Single Target")]

public class AbillityPlaceLogicSingleTarget : AbillityPlaceLogic
{
    public override List<Unit> TryGetTargets(Vector2 screenPoint)
    {
        var ray = Camera.main.ScreenPointToRay(new Vector3(screenPoint.x, screenPoint.y, 1));

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 15))
        {
            return new List<Unit>() {hit.transform.GetComponent<Unit>()};
        }
        return null;
    }
}
