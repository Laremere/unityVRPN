using UnityEngine;

public class Tracker : MonoBehaviour
{
    [SerializeField]
    protected string host = "localhost";
    [SerializeField]
    protected string obj = "";
    [SerializeField]
    protected int channel = 0;

    [SerializeField]
    protected bool trackPosition = true;
    [SerializeField]
    protected bool trackRotation = true;

    private void Update()
    {
        if (trackPosition)
        {
            transform.position = VRPN.vrpnTrackerPos(obj + "@" + host, channel);
        }
        if (trackRotation)
        {
            transform.rotation = VRPN.vrpnTrackerQuat(obj + "@" + host, channel);
        }
    }
}