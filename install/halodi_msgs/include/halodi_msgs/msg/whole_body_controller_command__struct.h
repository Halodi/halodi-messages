// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/WholeBodyControllerCommand.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__WHOLE_BODY_CONTROLLER_COMMAND__STRUCT_H_
#define HALODI_MSGS__MSG__WHOLE_BODY_CONTROLLER_COMMAND__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

// Include directives for member types
// Member 'balance_mode'
#include "halodi_msgs/msg/balance_mode__struct.h"
// Member 'task_space_commands'
#include "halodi_msgs/msg/task_space_command__struct.h"
// Member 'joint_space_commands'
#include "halodi_msgs/msg/joint_space_command__struct.h"
// Member 'contact_point_commands'
#include "halodi_msgs/msg/contact_point_command__struct.h"
// Member 'driving_command'
#include "halodi_msgs/msg/driving_command__struct.h"
// Member 'icp_command'
#include "geometry_msgs/msg/vector3__struct.h"

// constants for array fields with an upper bound
// task_space_commands
enum
{
  halodi_msgs__msg__WholeBodyControllerCommand__task_space_commands__MAX_SIZE = 5
};
// joint_space_commands
enum
{
  halodi_msgs__msg__WholeBodyControllerCommand__joint_space_commands__MAX_SIZE = 25
};
// contact_point_commands
enum
{
  halodi_msgs__msg__WholeBodyControllerCommand__contact_point_commands__MAX_SIZE = 5
};
// driving_command
enum
{
  halodi_msgs__msg__WholeBodyControllerCommand__driving_command__MAX_SIZE = 20
};
// icp_command
enum
{
  halodi_msgs__msg__WholeBodyControllerCommand__icp_command__MAX_SIZE = 20
};

// Struct defined in msg/WholeBodyControllerCommand in the package halodi_msgs.
typedef struct halodi_msgs__msg__WholeBodyControllerCommand
{
  int32_t sequence_id;
  halodi_msgs__msg__BalanceMode balance_mode;
  halodi_msgs__msg__TaskSpaceCommand__Sequence task_space_commands;
  halodi_msgs__msg__JointSpaceCommand__Sequence joint_space_commands;
  halodi_msgs__msg__ContactPointCommand__Sequence contact_point_commands;
  halodi_msgs__msg__DrivingCommand__Sequence driving_command;
  geometry_msgs__msg__Vector3__Sequence icp_command;
} halodi_msgs__msg__WholeBodyControllerCommand;

// Struct for a sequence of halodi_msgs__msg__WholeBodyControllerCommand.
typedef struct halodi_msgs__msg__WholeBodyControllerCommand__Sequence
{
  halodi_msgs__msg__WholeBodyControllerCommand * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__WholeBodyControllerCommand__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__WHOLE_BODY_CONTROLLER_COMMAND__STRUCT_H_
