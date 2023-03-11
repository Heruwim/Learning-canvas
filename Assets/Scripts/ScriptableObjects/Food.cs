using UnityEngine;

[CreateAssetMenu(fileName = "New Food", menuName = "Shop/Food", order = 51)]
public class Food : Goods
{
    [SerializeField] private int _calorie;

    public override void ShowInfo()
    {
        Debug.Log($"—ъедобн≥й товар - {Label}, с виду он - {Description}, стоит - {Prise}, и сытный на - {_calorie}.");
    }
}
