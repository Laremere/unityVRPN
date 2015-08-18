cmake_minimum_required(VERSION 2.8)
project(unityVRPN)

set(VRPN_BUILD_CLIENT_LIBRARY TRUE CACHE INTERNAL "" FORCE)
# add vrpn
add_subdirectory(vrpn)

include_directories(vrpn)

# add our library
add_subdirectory(unityVrpn)
