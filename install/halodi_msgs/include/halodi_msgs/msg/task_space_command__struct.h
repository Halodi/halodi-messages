// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/TaskSpaceCommand.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__TASK_SPACE_COMMAND__STRUCT_H_
#define HALODI_MSGS__MSG__TASK_SPACE_COMMAND__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

// Include directives for member types
// Member 'body_frame'
// Member 'expressed_in_frame'
#include "halodi_msgs/msg/reference_frame_name__struct.h"
// Member 'pose'
#include "geometry_msgs/msg/pose__struct.h"
// Member 'angular_velocity'
// Member 'linear_velocity'
// Member 'angular_acceleration'
// Member 'linear_acceleration'
#include "geometry_msgs/msg/vector3__struct.h"
// Member 'passivity_input'
#include "halodi_msgs/msg/passivity_data__struct.h"
// Member 'orientation_feedback_parameters'
// Member 'position_feedback_parameters'
#include "halodi_msgs/msg/feedback_parameters3_d__struct.h"
// Member 'nullspace_command'
#include "halodi_msgs/msg/joint_null_space_configuration__struct.h"

// constants for array fields with an upper bound
// passivity_input
enum
{
  halodi_msgs__msg__TaskSpaceCommand__passivity_input__MAX_SIZE = 1
};
// orientation_feedback_parameters
enum
{
  halodi_msgs__msg__TaskSpaceCommand__orientation_feedback_parameters__MAX_SIZE = 1
};
// position_feedback_parameters
enum
{
  halodi_msgs__msg__TaskSpaceCommand__position_feedback_parameters__MAX_SIZE = 1
};
// nullspace_command
enum
{
  halodi_msgs__msg__TaskSpaceCommand__nullspace_command__MAX_SIZE = 7
};

// Struct defined in msg/TaskSpaceCommand in the package halodi_msgs.
typedef struct halodi_msgs__msg__TaskSpaceCommand
{
  halodi_msgs__msg__ReferenceFrameName body_frame;
  halodi_msgs__msg__ReferenceFrameName expressed_in_frame;
  bool express_in_z_up;
  geometry_msgs__msg__Pose pose;
  geometry_msgs__msg__Vector3 angular_velocity;
  geometry_msgs__msg__Vector3 linear_velocity;
  geometry_msgs__msg__Vector3 angular_acceleration;
  geometry_msgs__msg__Vector3 linear_acceleration;
  halodi_msgs__msg__PassivityData__Sequence passivity_input;
  halodi_msgs__msg__FeedbackParameters3D__Sequence orientation_feedback_parameters;
  halodi_msgs__msg__FeedbackParameters3D__Sequence position_feedback_parameters;
  halodi_msgs__msg__JointNullSpaceConfiguration__Sequence nullspace_command;
} halodi_msgs__msg__TaskSpaceCommand;

// Struct for a sequence of halodi_msgs__msg__TaskSpaceCommand.
typedef struct halodi_msgs__msg__TaskSpaceCommand__Sequence
{
  halodi_msgs__msg__TaskSpaceCommand * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__TaskSpaceCommand__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__TASK_SPACE_COMMAND__STRUCT_H_
