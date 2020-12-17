// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/JointMeasurement.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__JOINT_MEASUREMENT__STRUCT_H_
#define HALODI_MSGS__MSG__JOINT_MEASUREMENT__STRUCT_H_

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

// Struct defined in msg/JointMeasurement in the package halodi_msgs.
typedef struct halodi_msgs__msg__JointMeasurement
{
  halodi_msgs__msg__JointName joint;
  double position;
  double velocity;
  double measuredEffort;
  double desiredEffort;
} halodi_msgs__msg__JointMeasurement;

// Struct for a sequence of halodi_msgs__msg__JointMeasurement.
typedef struct halodi_msgs__msg__JointMeasurement__Sequence
{
  halodi_msgs__msg__JointMeasurement * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__JointMeasurement__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__JOINT_MEASUREMENT__STRUCT_H_
