using UnityEngine;

public class PlayerFollower2D : MonoBehaviour
{
    public float fSmoothSpeed = 10f;
    [Space]
    public Transform gTarget;
    public Vector3 v3Offset;
    public string TagToSearch = "Player";

    /// <summary>
    /// Find What Will be followed
    /// </summary>
    public void FindTarget()
    {
        gTarget = GameObject.FindGameObjectWithTag(TagToSearch).transform;
        if (gTarget == null)
        {
            Debug.LogError("Target not found");
        }
    }


    private void FixedUpdate()
    {
        if (gTarget != null)
        {
            Vector3 _desiredPostion = gTarget.position + v3Offset;
            Vector3 _smoothPosition = Vector3.Lerp(transform.position, _desiredPostion, fSmoothSpeed * Time.deltaTime);
            transform.position = _smoothPosition;
        }
    }
}
