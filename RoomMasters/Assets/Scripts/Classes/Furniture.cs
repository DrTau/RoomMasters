using UnityEngine;

public class Furniture : MonoBehaviour
{
    [SerializeField] public Vector2 Size = Vector2Int.one;
    [SerializeField] private bool IsSelected = true;
    [SerializeField] Renderer MainRender;

    private void OnDrawGizmos()
    {
        for (int x = 0; x < Size.x; x++)
        {
            for (int y = 0; y < Size.y; y++)
            {
                if ((x + y) % 2 == 0) Gizmos.color = new Color(0.9f, 0f, 1f, 0.3f);
                else Gizmos.color = new Color(1f, 0.7f, 0f, 0.3f);

                Gizmos.DrawCube(transform.position + new Vector3(x, 0, y), new Vector3(1, 1f, 1));
            }
        }
    }

    public void Rotate() => (Size.x, Size.y) = (Size.y, Size.x);
}