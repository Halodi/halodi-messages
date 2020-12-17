// generated from rosidl_generator_c/resource/idl__functions.c.em
// with input from halodi_msgs:msg/FeedbackParameters3D.idl
// generated code does not contain a copyright notice
#include "halodi_msgs/msg/feedback_parameters3_d__functions.h"

#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>


// Include directives for member types
// Member `proportional`
// Member `integral`
// Member `derivative`
#include "geometry_msgs/msg/vector3__functions.h"
// Member `maximum_proportional_error`
// Member `maximum_integral_windup`
// Member `maximum_derivative_error`
// Member `maximum_feedback`
// Member `maximum_feedback_rate`
// Member `integral_leakage`
#include "rosidl_generator_c/primitives_sequence_functions.h"

bool
halodi_msgs__msg__FeedbackParameters3D__init(halodi_msgs__msg__FeedbackParameters3D * msg)
{
  if (!msg) {
    return false;
  }
  // proportional
  if (!geometry_msgs__msg__Vector3__init(&msg->proportional)) {
    halodi_msgs__msg__FeedbackParameters3D__fini(msg);
    return false;
  }
  // integral
  if (!geometry_msgs__msg__Vector3__Sequence__init(&msg->integral, 0)) {
    halodi_msgs__msg__FeedbackParameters3D__fini(msg);
    return false;
  }
  // derivative
  if (!geometry_msgs__msg__Vector3__init(&msg->derivative)) {
    halodi_msgs__msg__FeedbackParameters3D__fini(msg);
    return false;
  }
  // maximum_proportional_error
  if (!rosidl_generator_c__double__Sequence__init(&msg->maximum_proportional_error, 0)) {
    halodi_msgs__msg__FeedbackParameters3D__fini(msg);
    return false;
  }
  // maximum_integral_windup
  if (!rosidl_generator_c__double__Sequence__init(&msg->maximum_integral_windup, 0)) {
    halodi_msgs__msg__FeedbackParameters3D__fini(msg);
    return false;
  }
  // maximum_derivative_error
  if (!rosidl_generator_c__double__Sequence__init(&msg->maximum_derivative_error, 0)) {
    halodi_msgs__msg__FeedbackParameters3D__fini(msg);
    return false;
  }
  // maximum_feedback
  if (!rosidl_generator_c__double__Sequence__init(&msg->maximum_feedback, 0)) {
    halodi_msgs__msg__FeedbackParameters3D__fini(msg);
    return false;
  }
  // maximum_feedback_rate
  if (!rosidl_generator_c__double__Sequence__init(&msg->maximum_feedback_rate, 0)) {
    halodi_msgs__msg__FeedbackParameters3D__fini(msg);
    return false;
  }
  // integral_leakage
  if (!rosidl_generator_c__double__Sequence__init(&msg->integral_leakage, 0)) {
    halodi_msgs__msg__FeedbackParameters3D__fini(msg);
    return false;
  }
  return true;
}

void
halodi_msgs__msg__FeedbackParameters3D__fini(halodi_msgs__msg__FeedbackParameters3D * msg)
{
  if (!msg) {
    return;
  }
  // proportional
  geometry_msgs__msg__Vector3__fini(&msg->proportional);
  // integral
  geometry_msgs__msg__Vector3__Sequence__fini(&msg->integral);
  // derivative
  geometry_msgs__msg__Vector3__fini(&msg->derivative);
  // maximum_proportional_error
  rosidl_generator_c__double__Sequence__fini(&msg->maximum_proportional_error);
  // maximum_integral_windup
  rosidl_generator_c__double__Sequence__fini(&msg->maximum_integral_windup);
  // maximum_derivative_error
  rosidl_generator_c__double__Sequence__fini(&msg->maximum_derivative_error);
  // maximum_feedback
  rosidl_generator_c__double__Sequence__fini(&msg->maximum_feedback);
  // maximum_feedback_rate
  rosidl_generator_c__double__Sequence__fini(&msg->maximum_feedback_rate);
  // integral_leakage
  rosidl_generator_c__double__Sequence__fini(&msg->integral_leakage);
}

halodi_msgs__msg__FeedbackParameters3D *
halodi_msgs__msg__FeedbackParameters3D__create()
{
  halodi_msgs__msg__FeedbackParameters3D * msg = (halodi_msgs__msg__FeedbackParameters3D *)malloc(sizeof(halodi_msgs__msg__FeedbackParameters3D));
  if (!msg) {
    return NULL;
  }
  memset(msg, 0, sizeof(halodi_msgs__msg__FeedbackParameters3D));
  bool success = halodi_msgs__msg__FeedbackParameters3D__init(msg);
  if (!success) {
    free(msg);
    return NULL;
  }
  return msg;
}

void
halodi_msgs__msg__FeedbackParameters3D__destroy(halodi_msgs__msg__FeedbackParameters3D * msg)
{
  if (msg) {
    halodi_msgs__msg__FeedbackParameters3D__fini(msg);
  }
  free(msg);
}


bool
halodi_msgs__msg__FeedbackParameters3D__Sequence__init(halodi_msgs__msg__FeedbackParameters3D__Sequence * array, size_t size)
{
  if (!array) {
    return false;
  }
  halodi_msgs__msg__FeedbackParameters3D * data = NULL;
  if (size) {
    data = (halodi_msgs__msg__FeedbackParameters3D *)calloc(size, sizeof(halodi_msgs__msg__FeedbackParameters3D));
    if (!data) {
      return false;
    }
    // initialize all array elements
    size_t i;
    for (i = 0; i < size; ++i) {
      bool success = halodi_msgs__msg__FeedbackParameters3D__init(&data[i]);
      if (!success) {
        break;
      }
    }
    if (i < size) {
      // if initialization failed finalize the already initialized array elements
      for (; i > 0; --i) {
        halodi_msgs__msg__FeedbackParameters3D__fini(&data[i - 1]);
      }
      free(data);
      return false;
    }
  }
  array->data = data;
  array->size = size;
  array->capacity = size;
  return true;
}

void
halodi_msgs__msg__FeedbackParameters3D__Sequence__fini(halodi_msgs__msg__FeedbackParameters3D__Sequence * array)
{
  if (!array) {
    return;
  }
  if (array->data) {
    // ensure that data and capacity values are consistent
    assert(array->capacity > 0);
    // finalize all array elements
    for (size_t i = 0; i < array->capacity; ++i) {
      halodi_msgs__msg__FeedbackParameters3D__fini(&array->data[i]);
    }
    free(array->data);
    array->data = NULL;
    array->size = 0;
    array->capacity = 0;
  } else {
    // ensure that data, size, and capacity values are consistent
    assert(0 == array->size);
    assert(0 == array->capacity);
  }
}

halodi_msgs__msg__FeedbackParameters3D__Sequence *
halodi_msgs__msg__FeedbackParameters3D__Sequence__create(size_t size)
{
  halodi_msgs__msg__FeedbackParameters3D__Sequence * array = (halodi_msgs__msg__FeedbackParameters3D__Sequence *)malloc(sizeof(halodi_msgs__msg__FeedbackParameters3D__Sequence));
  if (!array) {
    return NULL;
  }
  bool success = halodi_msgs__msg__FeedbackParameters3D__Sequence__init(array, size);
  if (!success) {
    free(array);
    return NULL;
  }
  return array;
}

void
halodi_msgs__msg__FeedbackParameters3D__Sequence__destroy(halodi_msgs__msg__FeedbackParameters3D__Sequence * array)
{
  if (array) {
    halodi_msgs__msg__FeedbackParameters3D__Sequence__fini(array);
  }
  free(array);
}
