using UnityEngine;

public class WheelModel : MonoBehaviour {
    [SerializeField] private WheelCollider _wheelCollider;
    Vector3 _position;
    Quaternion _rotation;

    private void Update() {
        _wheelCollider.GetWorldPose(out _position, out _rotation);
        transform.position = _position;
        transform.rotation = _rotation;
    }
}
