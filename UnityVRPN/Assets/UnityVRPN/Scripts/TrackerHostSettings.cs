using UnityEngine;

public class TrackerHostSettings : MonoBehaviour
{
    [SerializeField]
    private string hostname = "localhost";
    [SerializeField]
    private TrackerPreset preset = TrackerPreset.Standard;

    private delegate Vector3 Position(string tracker, int channel);
    private delegate Quaternion Rotation(string tracker, int channel);

    private Position position;
    private Rotation rotation;

    public string Hostname
    {
        get { return hostname; }
        set { hostname = value; }
    }

    public TrackerPreset Preset
    {
        get { return preset; }
        set
        {
            preset = value;

            switch (preset)
            {
                case TrackerPreset.Standard:
                    position = VRPN.vrpnTrackerPos;
                    rotation = VRPN.vrpnTrackerQuat;
                    break;
                case TrackerPreset.Vicon:
                    position = ViconVRPN.vrpnTrackerPos;
                    rotation = ViconVRPN.vrpnTrackerQuat;
                    break;
            }
        }
    }

    public Vector3 GetPosition(string tracker, int channel)
    {
        return position(tracker + "@" + hostname, channel);
    }

    public Quaternion GetRotation(string tracker, int channel)
    {
        return rotation(tracker + "@" + hostname, channel);
    }

    private void Awake()
    {
        Preset = preset;
    }
}
