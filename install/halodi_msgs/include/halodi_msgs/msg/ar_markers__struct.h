// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/ARMarkers.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__AR_MARKERS__STRUCT_H_
#define HALODI_MSGS__MSG__AR_MARKERS__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

// Include directives for member types
// Member 'header'
#include "std_msgs/msg/header__struct.h"
// Member 'markers'
#include "halodi_msgs/msg/ar_marker__struct.h"

// constants for array fields with an upper bound
// markers
enum
{
  halodi_msgs__msg__ARMarkers__markers__MAX_SIZE = 255
};

// Struct defined in msg/ARMarkers in the package halodi_msgs.
typedef struct halodi_msgs__msg__ARMarkers
{
  std_msgs__msg__Header header;
  halodi_msgs__msg__ARMarker__Sequence markers;
} halodi_msgs__msg__ARMarkers;

// Struct for a sequence of halodi_msgs__msg__ARMarkers.
typedef struct halodi_msgs__msg__ARMarkers__Sequence
{
  halodi_msgs__msg__ARMarkers * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__ARMarkers__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__AR_MARKERS__STRUCT_H_
