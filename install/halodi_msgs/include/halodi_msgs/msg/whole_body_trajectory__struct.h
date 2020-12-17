// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/WholeBodyTrajectory.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__WHOLE_BODY_TRAJECTORY__STRUCT_H_
#define HALODI_MSGS__MSG__WHOLE_BODY_TRAJECTORY__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

// Include directives for member types
// Member 'trajectory_id'
#include "unique_identifier_msgs/msg/uuid__struct.h"
// Member 'start_time'
#include "builtin_interfaces/msg/time__struct.h"
// Member 'balance_mode'
#include "halodi_msgs/msg/balance_mode__struct.h"
// Member 'interpolation_mode'
#include "halodi_msgs/msg/trajectory_interpolation__struct.h"
// Member 'trajectory_points'
#include "halodi_msgs/msg/whole_body_trajectory_point__struct.h"

// constants for array fields with an upper bound
// start_time
enum
{
  halodi_msgs__msg__WholeBodyTrajectory__start_time__MAX_SIZE = 1
};
// balance_mode
enum
{
  halodi_msgs__msg__WholeBodyTrajectory__balance_mode__MAX_SIZE = 1
};
// trajectory_points
enum
{
  halodi_msgs__msg__WholeBodyTrajectory__trajectory_points__MAX_SIZE = 255
};

// Struct defined in msg/WholeBodyTrajectory in the package halodi_msgs.
typedef struct halodi_msgs__msg__WholeBodyTrajectory
{
  unique_identifier_msgs__msg__UUID trajectory_id;
  builtin_interfaces__msg__Time__Sequence start_time;
  halodi_msgs__msg__BalanceMode__Sequence balance_mode;
  bool append_trajectory;
  halodi_msgs__msg__TrajectoryInterpolation interpolation_mode;
  halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence trajectory_points;
} halodi_msgs__msg__WholeBodyTrajectory;

// Struct for a sequence of halodi_msgs__msg__WholeBodyTrajectory.
typedef struct halodi_msgs__msg__WholeBodyTrajectory__Sequence
{
  halodi_msgs__msg__WholeBodyTrajectory * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__WholeBodyTrajectory__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__WHOLE_BODY_TRAJECTORY__STRUCT_H_
