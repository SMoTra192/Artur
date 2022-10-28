using UnityEngine;
#nullable enable

public class CanvasRotation : MonoBehaviour
{
    private UnityEngine.Camera _cam = null!;

    private void Awake()
    {
        _cam = UnityEngine.Camera.main;
    }

    void Update()
    {
        transform.LookAt(new Vector3(transform.position.x,_cam.transform.position.y,_cam.transform.position.z));
    }
}
