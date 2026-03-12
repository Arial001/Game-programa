using UnityEngine;

[CreateAssetMenu(fileName = "TransformData", menuName = "TransformData")]
public class TransformData : ScriptableObject
{
    public Vector2 position;

        public void ResetData()
    {
        position = Vector2.zero;
    }
}
