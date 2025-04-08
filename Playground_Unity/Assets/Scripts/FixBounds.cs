using UnityEngine;

public class FixBounds : MonoBehaviour
{
    void Start()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer != null)
        {
            Bounds bounds = meshRenderer.bounds;

            // Nếu bounds nhỏ bất thường, mở rộng thủ công
            if (bounds.size.magnitude < 0.1f) // Kiểm tra kích thước nhỏ
            {
                bounds.Expand(100f); // Mở rộng kích thước bounding box
                Debug.Log("Bounds expanded: " + bounds.size);
            }
        }
        else
        {
            Debug.LogWarning("No MeshRenderer found on " + gameObject.name);
        }
    }
}
