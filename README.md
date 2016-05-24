UnityVRPN
=========

Simple VRPN wrapper for Unity3D.

You can build the plugin from scratch, or use the download in the releases, or use the Unity package in the releases which includes built plugins for Windows and Linux.

Getting Started
---------------
1. Download and import the package.
2. Add a TrackerHostSettings component to any object in the scene.
    * Hostname: The IP address or hostname of the VRPN server.
    * Type: Choose whether to transform the coordinates from the VRPN server for Vicon systems.
3. Add a TrackerSettings component to any object you want to track with VRPN.
    * Host Settings: The GameObject with the TrackerHostSettings component to want to use for this object.
    * Object Name: The name of the tracker on the VRPN server.
    * Channel: Channel on the server.

Compiling
---------
Be sure to initialize/update the vrpn submodule in order to compile the plugin.
```
mkdir build
cd build
ccmake ../
make
```

Reference
---------
-> public static double vrpnAnalog(string address, int channel)
This gets an analog value from the vrpn address and the channel.  When first called with a new address, the vrpn connection will be created.  An address's values will be updated at most once per frame.

-> public static bool vrpnButton(string address, int channel)
This gets a boolean value from the vrpn address and the channel.  When first called with a new address, the vrpn connection will be created.  An address's values will be updated at most once per frame.

-> public static Vector3 vrpnTrackerPos(string address, int channel)
This gets position component of a tracker at the vrpn address and the channel.  When first called with a new address, the vrpn connection will be created.  An address's values will be updated at most once per frame.

-> public static Quaternion vrpnTrackerQuat(string address, int channel)
This gets rotation component of a tracker at the vrpn address and the channel.  When first called with a new address, the vrpn connection will be created.  An address's values will be updated at most once per frame.
