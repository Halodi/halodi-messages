// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/JointSpaceCommand.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__JOINT_SPACE_COMMAND__STRUCT_H_
#define HALODI_MSGS__MSG__JOINT_SPACE_COMMAND__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

// Include directives for member types
// Member 'joint'
#include "halodi_msgs/msg/joint_name__struct.h"
// Member 'q_desired_filter_break_frequency'
#include "rosidl_generator_c/primitives_sequence.h"

// constants for array fields with an upper bound
// q_desired_filter_break_frequency
enum
{
  halodi_msgs__msg__JointSpaceCommand__q_desired_filter_break_frequency__MAX_SIZE = 1
};

// Struct defined in msg/JointSpaceCommand in the package halodi_msgs.
typedef struct halodi_msgs__msg__JointSpaceCommand
{
  halodi_msgs__msg__JointName joint;
  double q_desired;
  double qd_desired;
  double qdd_desired;
  rosidl_generator_c__double__Sequence q_desired_filter_break_frequency;
  bool derive_qd_desired;
  bool use_default_gains;
  double stiffness;
  double damping;
  double motorDampingScale;
  double max_feedback;
} halodi_msgs__msg__JointSpaceCommand;

// Struct for a sequence of halodi_msgs__msg__JointSpaceCommand.
typedef struct halodi_msgs__msg__JointSpaceCommand__Sequence
{
  halodi_msgs__msg__JointSpaceCommand * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__JointSpaceCommand__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__JOINT_SPACE_COMMAND__STRUCT_H_
