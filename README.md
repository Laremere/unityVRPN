unityVRPN
=========

Simple VRPN wrapper for unity

You can build the dll from scratch or use the download in the releases. Or you can also just import the UnityVRPN Unity Package, or create your own from the UnityVRPN project.
The dll must be placed in the Assets/Plugins folder to use.  Place VRPN.cs (found in the scriptForUnity folder in the source) in whatever assets folder you wish.  This will allow you to use the static VRPN class.

-> public static double vrpnAnalog(string address, int channel)
This gets an analog value from the vrpn address and the channel.  When first called with a new address, the vrpn connection will be created.  An address's values will be updated at most once per frame.

-> public static bool vrpnButton(string address, int channel)
This gets a boolean value from the vrpn address and the channel.  When first called with a new address, the vrpn connection will be created.  An address's values will be updated at most once per frame.

-> public static Vector3 vrpnTrackerPos(string address, int channel)
This gets position component of a tracker at the vrpn address and the channel.  When first called with a new address, the vrpn connection will be created.  An address's values will be updated at most once per frame.

-> public static Quaternion vrpnTrackerQuat(string address, int channel)
This gets rotation component of a tracker at the vrpn address and the channel.  When first called with a new address, the vrpn connection will be created.  An address's values will be updated at most once per frame.

Compiling
---------
```
mkdir build
cd build
ccmake ../
make
```
