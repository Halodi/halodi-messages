// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/WholeBodyTrajectoryPoint.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__WHOLE_BODY_TRAJECTORY_POINT__STRUCT_H_
#define HALODI_MSGS__MSG__WHOLE_BODY_TRAJECTORY_POINT__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

// Include directives for member types
// Member 'time_from_start'
#include "builtin_interfaces/msg/duration__struct.h"
// Member 'task_space_commands'
#include "halodi_msgs/msg/task_space_command__struct.h"
// Member 'joint_space_commands'
#include "halodi_msgs/msg/joint_space_command__struct.h"
// Member 'contact_point_commands'
#include "halodi_msgs/msg/contact_point_command__struct.h"
// Member 'icp_offset_command'
#include "geometry_msgs/msg/vector3__struct.h"

// constants for array fields with an upper bound
// task_space_commands
enum
{
  halodi_msgs__msg__WholeBodyTrajectoryPoint__task_space_commands__MAX_SIZE = 5
};
// joint_space_commands
enum
{
  halodi_msgs__msg__WholeBodyTrajectoryPoint__joint_space_commands__MAX_SIZE = 25
};
// contact_point_commands
enum
{
  halodi_msgs__msg__WholeBodyTrajectoryPoint__contact_point_commands__MAX_SIZE = 5
};
// icp_offset_command
enum
{
  halodi_msgs__msg__WholeBodyTrajectoryPoint__icp_offset_command__MAX_SIZE = 1
};

// Struct defined in msg/WholeBodyTrajectoryPoint in the package halodi_msgs.
typedef struct halodi_msgs__msg__WholeBodyTrajectoryPoint
{
  builtin_interfaces__msg__Duration time_from_start;
  halodi_msgs__msg__TaskSpaceCommand__Sequence task_space_commands;
  halodi_msgs__msg__JointSpaceCommand__Sequence joint_space_commands;
  halodi_msgs__msg__ContactPointCommand__Sequence contact_point_commands;
  geometry_msgs__msg__Vector3__Sequence icp_offset_command;
} halodi_msgs__msg__WholeBodyTrajectoryPoint;

// Struct for a sequence of halodi_msgs__msg__WholeBodyTrajectoryPoint.
typedef struct halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence
{
  halodi_msgs__msg__WholeBodyTrajectoryPoint * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__WHOLE_BODY_TRAJECTORY_POINT__STRUCT_H_
