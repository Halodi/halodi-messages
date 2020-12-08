// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/HandCommand.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__HAND_COMMAND__STRUCT_H_
#define HALODI_MSGS__MSG__HAND_COMMAND__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

// Struct defined in msg/HandCommand in the package halodi_msgs.
typedef struct halodi_msgs__msg__HandCommand
{
  double closure;
  double speed;
  double force;
} halodi_msgs__msg__HandCommand;

// Struct for a sequence of halodi_msgs__msg__HandCommand.
typedef struct halodi_msgs__msg__HandCommand__Sequence
{
  halodi_msgs__msg__HandCommand * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__HandCommand__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__HAND_COMMAND__STRUCT_H_
