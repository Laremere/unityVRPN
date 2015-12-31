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

    // Update is called once per frame
    void Update()
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