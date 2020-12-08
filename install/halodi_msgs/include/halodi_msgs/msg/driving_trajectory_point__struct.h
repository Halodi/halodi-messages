// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/DrivingTrajectoryPoint.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__DRIVING_TRAJECTORY_POINT__STRUCT_H_
#define HALODI_MSGS__MSG__DRIVING_TRAJECTORY_POINT__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

// Struct defined in msg/DrivingTrajectoryPoint in the package halodi_msgs.
typedef struct halodi_msgs__msg__DrivingTrajectoryPoint
{
  double x;
  double y;
  double yaw;
  double desired_linear_velocity;
  double desired_angular_velocity;
} halodi_msgs__msg__DrivingTrajectoryPoint;

// Struct for a sequence of halodi_msgs__msg__DrivingTrajectoryPoint.
typedef struct halodi_msgs__msg__DrivingTrajectoryPoint__Sequence
{
  halodi_msgs__msg__DrivingTrajectoryPoint * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__DrivingTrajectoryPoint__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__DRIVING_TRAJECTORY_POINT__STRUCT_H_
