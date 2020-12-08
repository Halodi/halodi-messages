// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/FeedbackParameters3D.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__FEEDBACK_PARAMETERS3_D__STRUCT_H_
#define HALODI_MSGS__MSG__FEEDBACK_PARAMETERS3_D__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

// Include directives for member types
// Member 'proportional'
// Member 'integral'
// Member 'derivative'
#include "geometry_msgs/msg/vector3__struct.h"
// Member 'maximum_proportional_error'
// Member 'maximum_integral_windup'
// Member 'maximum_derivative_error'
// Member 'maximum_feedback'
// Member 'maximum_feedback_rate'
// Member 'integral_leakage'
#include "rosidl_generator_c/primitives_sequence.h"

// constants for array fields with an upper bound
// integral
enum
{
  halodi_msgs__msg__FeedbackParameters3D__integral__MAX_SIZE = 1
};
// maximum_proportional_error
enum
{
  halodi_msgs__msg__FeedbackParameters3D__maximum_proportional_error__MAX_SIZE = 1
};
// maximum_integral_windup
enum
{
  halodi_msgs__msg__FeedbackParameters3D__maximum_integral_windup__MAX_SIZE = 1
};
// maximum_derivative_error
enum
{
  halodi_msgs__msg__FeedbackParameters3D__maximum_derivative_error__MAX_SIZE = 1
};
// maximum_feedback
enum
{
  halodi_msgs__msg__FeedbackParameters3D__maximum_feedback__MAX_SIZE = 1
};
// maximum_feedback_rate
enum
{
  halodi_msgs__msg__FeedbackParameters3D__maximum_feedback_rate__MAX_SIZE = 1
};
// integral_leakage
enum
{
  halodi_msgs__msg__FeedbackParameters3D__integral_leakage__MAX_SIZE = 1
};

// Struct defined in msg/FeedbackParameters3D in the package halodi_msgs.
typedef struct halodi_msgs__msg__FeedbackParameters3D
{
  geometry_msgs__msg__Vector3 proportional;
  geometry_msgs__msg__Vector3__Sequence integral;
  geometry_msgs__msg__Vector3 derivative;
  rosidl_generator_c__double__Sequence maximum_proportional_error;
  rosidl_generator_c__double__Sequence maximum_integral_windup;
  rosidl_generator_c__double__Sequence maximum_derivative_error;
  rosidl_generator_c__double__Sequence maximum_feedback;
  rosidl_generator_c__double__Sequence maximum_feedback_rate;
  rosidl_generator_c__double__Sequence integral_leakage;
} halodi_msgs__msg__FeedbackParameters3D;

// Struct for a sequence of halodi_msgs__msg__FeedbackParameters3D.
typedef struct halodi_msgs__msg__FeedbackParameters3D__Sequence
{
  halodi_msgs__msg__FeedbackParameters3D * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__FeedbackParameters3D__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__FEEDBACK_PARAMETERS3_D__STRUCT_H_
