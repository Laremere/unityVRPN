using UnityEngine;

namespace UnityVRPN
{
    public static class ViconVRPN
    {
        public static Vector3 vrpnTrackerPos(string address, int channel)
        {
            var vector = VRPN.vrpnTrackerPos(address, channel);
            return new Vector3(vector.x, vector.z, vector.y);
        }

        public static Quaternion vrpnTrackerQuat(string address, int channel)
        {
            var quaternion = VRPN.vrpnTrackerQuat(address, channel);
            return new Quaternion(quaternion.x, quaternion.z, quaternion.y, -quaternion.w);
        }
    }
}
