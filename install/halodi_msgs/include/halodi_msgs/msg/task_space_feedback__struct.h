// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/TaskSpaceFeedback.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__TASK_SPACE_FEEDBACK__STRUCT_H_
#define HALODI_MSGS__MSG__TASK_SPACE_FEEDBACK__STRUCT_H_

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
// Member 'angular_acceleration'
// Member 'linear_acceleration'
#include "geometry_msgs/msg/vector3__struct.h"
// Member 'passivity_output'
#include "halodi_msgs/msg/passivity_data__struct.h"

// constants for array fields with an upper bound
// passivity_output
enum
{
  halodi_msgs__msg__TaskSpaceFeedback__passivity_output__MAX_SIZE = 1
};

// Struct defined in msg/TaskSpaceFeedback in the package halodi_msgs.
typedef struct halodi_msgs__msg__TaskSpaceFeedback
{
  halodi_msgs__msg__ReferenceFrameName body_frame;
  halodi_msgs__msg__ReferenceFrameName expressed_in_frame;
  bool express_in_z_up;
  geometry_msgs__msg__Vector3 angular_acceleration;
  geometry_msgs__msg__Vector3 linear_acceleration;
  halodi_msgs__msg__PassivityData__Sequence passivity_output;
} halodi_msgs__msg__TaskSpaceFeedback;

// Struct for a sequence of halodi_msgs__msg__TaskSpaceFeedback.
typedef struct halodi_msgs__msg__TaskSpaceFeedback__Sequence
{
  halodi_msgs__msg__TaskSpaceFeedback * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__TaskSpaceFeedback__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__TASK_SPACE_FEEDBACK__STRUCT_H_
