// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/ImuMeasurement.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__IMU_MEASUREMENT__STRUCT_H_
#define HALODI_MSGS__MSG__IMU_MEASUREMENT__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

// Include directives for member types
// Member 'imu'
#include "halodi_msgs/msg/imu_name__struct.h"
// Member 'orientation'
#include "geometry_msgs/msg/quaternion__struct.h"
// Member 'angular_velocity'
// Member 'linear_acceleration'
#include "geometry_msgs/msg/vector3__struct.h"

// Struct defined in msg/ImuMeasurement in the package halodi_msgs.
typedef struct halodi_msgs__msg__ImuMeasurement
{
  halodi_msgs__msg__ImuName imu;
  geometry_msgs__msg__Quaternion orientation;
  geometry_msgs__msg__Vector3 angular_velocity;
  geometry_msgs__msg__Vector3 linear_acceleration;
} halodi_msgs__msg__ImuMeasurement;

// Struct for a sequence of halodi_msgs__msg__ImuMeasurement.
typedef struct halodi_msgs__msg__ImuMeasurement__Sequence
{
  halodi_msgs__msg__ImuMeasurement * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__ImuMeasurement__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__IMU_MEASUREMENT__STRUCT_H_
