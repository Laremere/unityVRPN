# THIS PROJECT IS NO LONGER MAINTAINED.  Sorry, but I no longer work in this area.  Some forks may be more active.  No pull requests will be accepted.

unityVRPN
=========

Simple VRPN wrapper for unity

You can build the dll from scratch or use the download in the releases.
The dll must be placed in the Assets/Plugins folder to use.  Place VRPN.cs (found in the scriptForUnity folder in the source) in whatever assets folder you wish.  This will allow you to use the static VRPN class.

The version in releases is only for the older 32 bit version of unity.  If you're using the 64 bit version, use this fork which has the 64 bit version of the dll compiled: https://github.com/arviceblot/unityVRPN/releases

-> public static double vrpnAnalog(string address, int channel)
This gets an analog value from the vrpn address and the channel.  When first called with a new address, the vrpn connection will be created.  An address's values will be updated at most once per frame.

-> public static bool vrpnButton(string address, int channel)
This gets a boolean value from the vrpn address and the channel.  When first called with a new address, the vrpn connection will be created.  An address's values will be updated at most once per frame.

-> public static Vector3 vrpnTrackerPos(string address, int channel)
This gets position component of a tracker at the vrpn address and the channel.  When first called with a new address, the vrpn connection will be created.  An address's values will be updated at most once per frame.

-> public static Quaternion vrpnTrackerQuat(string address, int channel)
This gets rotation component of a tracker at the vrpn address and the channel.  When first called with a new address, the vrpn connection will be created.  An address's values will be updated at most once per frame.
