// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/TrajectoryInterpolation.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__TRAJECTORY_INTERPOLATION__STRUCT_H_
#define HALODI_MSGS__MSG__TRAJECTORY_INTERPOLATION__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

/// Constant 'LINEAR'.
enum
{
  halodi_msgs__msg__TrajectoryInterpolation__LINEAR = 0
};

/// Constant 'MINIMUM_JERK_CONSTRAINED'.
enum
{
  halodi_msgs__msg__TrajectoryInterpolation__MINIMUM_JERK_CONSTRAINED = 1
};

/// Constant 'MULTIPLE_WAYPOINT_SPLINE'.
enum
{
  halodi_msgs__msg__TrajectoryInterpolation__MULTIPLE_WAYPOINT_SPLINE = 2
};

// Struct defined in msg/TrajectoryInterpolation in the package halodi_msgs.
typedef struct halodi_msgs__msg__TrajectoryInterpolation
{
  uint8_t value;
} halodi_msgs__msg__TrajectoryInterpolation;

// Struct for a sequence of halodi_msgs__msg__TrajectoryInterpolation.
typedef struct halodi_msgs__msg__TrajectoryInterpolation__Sequence
{
  halodi_msgs__msg__TrajectoryInterpolation * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__TrajectoryInterpolation__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__TRAJECTORY_INTERPOLATION__STRUCT_H_
