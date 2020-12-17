// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/JointNullSpaceConfiguration.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__JOINT_NULL_SPACE_CONFIGURATION__STRUCT_H_
#define HALODI_MSGS__MSG__JOINT_NULL_SPACE_CONFIGURATION__STRUCT_H_

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

// Struct defined in msg/JointNullSpaceConfiguration in the package halodi_msgs.
typedef struct halodi_msgs__msg__JointNullSpaceConfiguration
{
  halodi_msgs__msg__JointName joint;
  double q_nullspace;
} halodi_msgs__msg__JointNullSpaceConfiguration;

// Struct for a sequence of halodi_msgs__msg__JointNullSpaceConfiguration.
typedef struct halodi_msgs__msg__JointNullSpaceConfiguration__Sequence
{
  halodi_msgs__msg__JointNullSpaceConfiguration * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__JointNullSpaceConfiguration__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__JOINT_NULL_SPACE_CONFIGURATION__STRUCT_H_
