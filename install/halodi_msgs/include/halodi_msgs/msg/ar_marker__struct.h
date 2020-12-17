// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/ARMarker.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__AR_MARKER__STRUCT_H_
#define HALODI_MSGS__MSG__AR_MARKER__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

// Include directives for member types
// Member 'data'
#include "rosidl_generator_c/string.h"
// Member 'points'
#include "geometry_msgs/msg/point__struct.h"
// Member 'pose'
#include "geometry_msgs/msg/pose_stamped__struct.h"

// constants for array fields with an upper bound
// points
enum
{
  halodi_msgs__msg__ARMarker__points__MAX_SIZE = 4
};

// Struct defined in msg/ARMarker in the package halodi_msgs.
typedef struct halodi_msgs__msg__ARMarker
{
  rosidl_generator_c__String data;
  geometry_msgs__msg__Point__Sequence points;
  geometry_msgs__msg__PoseStamped pose;
} halodi_msgs__msg__ARMarker;

// Struct for a sequence of halodi_msgs__msg__ARMarker.
typedef struct halodi_msgs__msg__ARMarker__Sequence
{
  halodi_msgs__msg__ARMarker * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__ARMarker__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__AR_MARKER__STRUCT_H_
