// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/ReferenceFrameName.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__REFERENCE_FRAME_NAME__STRUCT_H_
#define HALODI_MSGS__MSG__REFERENCE_FRAME_NAME__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

/// Constant 'WORLD'.
enum
{
  halodi_msgs__msg__ReferenceFrameName__WORLD = 0l
};

/// Constant 'PELVIS'.
enum
{
  halodi_msgs__msg__ReferenceFrameName__PELVIS = 1l
};

/// Constant 'BASE'.
enum
{
  halodi_msgs__msg__ReferenceFrameName__BASE = 2l
};

/// Constant 'LEFT_HAND'.
enum
{
  halodi_msgs__msg__ReferenceFrameName__LEFT_HAND = 3l
};

/// Constant 'RIGHT_HAND'.
enum
{
  halodi_msgs__msg__ReferenceFrameName__RIGHT_HAND = 4l
};

/// Constant 'HEAD'.
enum
{
  halodi_msgs__msg__ReferenceFrameName__HEAD = 5l
};

// Struct defined in msg/ReferenceFrameName in the package halodi_msgs.
typedef struct halodi_msgs__msg__ReferenceFrameName
{
  int32_t frame_id;
} halodi_msgs__msg__ReferenceFrameName;

// Struct for a sequence of halodi_msgs__msg__ReferenceFrameName.
typedef struct halodi_msgs__msg__ReferenceFrameName__Sequence
{
  halodi_msgs__msg__ReferenceFrameName * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__ReferenceFrameName__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__REFERENCE_FRAME_NAME__STRUCT_H_
