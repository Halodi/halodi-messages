// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/DrivingTrajectory.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__DRIVING_TRAJECTORY__STRUCT_H_
#define HALODI_MSGS__MSG__DRIVING_TRAJECTORY__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

// Include directives for member types
// Member 'trajectory_points'
#include "halodi_msgs/msg/driving_trajectory_point__struct.h"

// Struct defined in msg/DrivingTrajectory in the package halodi_msgs.
typedef struct halodi_msgs__msg__DrivingTrajectory
{
  double look_ahead_distance;
  double K;
  halodi_msgs__msg__DrivingTrajectoryPoint__Sequence trajectory_points;
} halodi_msgs__msg__DrivingTrajectory;

// Struct for a sequence of halodi_msgs__msg__DrivingTrajectory.
typedef struct halodi_msgs__msg__DrivingTrajectory__Sequence
{
  halodi_msgs__msg__DrivingTrajectory * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__DrivingTrajectory__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__DRIVING_TRAJECTORY__STRUCT_H_
