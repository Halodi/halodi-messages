// generated from rosidl_generator_c/resource/idl__functions.c.em
// with input from halodi_msgs:msg/JointSpaceCommand.idl
// generated code does not contain a copyright notice
#include "halodi_msgs/msg/joint_space_command__functions.h"

#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>


// Include directives for member types
// Member `joint`
#include "halodi_msgs/msg/joint_name__functions.h"
// Member `q_desired_filter_break_frequency`
#include "rosidl_generator_c/primitives_sequence_functions.h"

bool
halodi_msgs__msg__JointSpaceCommand__init(halodi_msgs__msg__JointSpaceCommand * msg)
{
  if (!msg) {
    return false;
  }
  // joint
  if (!halodi_msgs__msg__JointName__init(&msg->joint)) {
    halodi_msgs__msg__JointSpaceCommand__fini(msg);
    return false;
  }
  // q_desired
  // qd_desired
  // qdd_desired
  // q_desired_filter_break_frequency
  if (!rosidl_generator_c__double__Sequence__init(&msg->q_desired_filter_break_frequency, 0)) {
    halodi_msgs__msg__JointSpaceCommand__fini(msg);
    return false;
  }
  // derive_qd_desired
  // use_default_gains
  // stiffness
  // damping
  // motorDampingScale
  // max_feedback
  return true;
}

void
halodi_msgs__msg__JointSpaceCommand__fini(halodi_msgs__msg__JointSpaceCommand * msg)
{
  if (!msg) {
    return;
  }
  // joint
  halodi_msgs__msg__JointName__fini(&msg->joint);
  // q_desired
  // qd_desired
  // qdd_desired
  // q_desired_filter_break_frequency
  rosidl_generator_c__double__Sequence__fini(&msg->q_desired_filter_break_frequency);
  // derive_qd_desired
  // use_default_gains
  // stiffness
  // damping
  // motorDampingScale
  // max_feedback
}

halodi_msgs__msg__JointSpaceCommand *
halodi_msgs__msg__JointSpaceCommand__create()
{
  halodi_msgs__msg__JointSpaceCommand * msg = (halodi_msgs__msg__JointSpaceCommand *)malloc(sizeof(halodi_msgs__msg__JointSpaceCommand));
  if (!msg) {
    return NULL;
  }
  memset(msg, 0, sizeof(halodi_msgs__msg__JointSpaceCommand));
  bool success = halodi_msgs__msg__JointSpaceCommand__init(msg);
  if (!success) {
    free(msg);
    return NULL;
  }
  return msg;
}

void
halodi_msgs__msg__JointSpaceCommand__destroy(halodi_msgs__msg__JointSpaceCommand * msg)
{
  if (msg) {
    halodi_msgs__msg__JointSpaceCommand__fini(msg);
  }
  free(msg);
}


bool
halodi_msgs__msg__JointSpaceCommand__Sequence__init(halodi_msgs__msg__JointSpaceCommand__Sequence * array, size_t size)
{
  if (!array) {
    return false;
  }
  halodi_msgs__msg__JointSpaceCommand * data = NULL;
  if (size) {
    data = (halodi_msgs__msg__JointSpaceCommand *)calloc(size, sizeof(halodi_msgs__msg__JointSpaceCommand));
    if (!data) {
      return false;
    }
    // initialize all array elements
    size_t i;
    for (i = 0; i < size; ++i) {
      bool success = halodi_msgs__msg__JointSpaceCommand__init(&data[i]);
      if (!success) {
        break;
      }
    }
    if (i < size) {
      // if initialization failed finalize the already initialized array elements
      for (; i > 0; --i) {
        halodi_msgs__msg__JointSpaceCommand__fini(&data[i - 1]);
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
halodi_msgs__msg__JointSpaceCommand__Sequence__fini(halodi_msgs__msg__JointSpaceCommand__Sequence * array)
{
  if (!array) {
    return;
  }
  if (array->data) {
    // ensure that data and capacity values are consistent
    assert(array->capacity > 0);
    // finalize all array elements
    for (size_t i = 0; i < array->capacity; ++i) {
      halodi_msgs__msg__JointSpaceCommand__fini(&array->data[i]);
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

halodi_msgs__msg__JointSpaceCommand__Sequence *
halodi_msgs__msg__JointSpaceCommand__Sequence__create(size_t size)
{
  halodi_msgs__msg__JointSpaceCommand__Sequence * array = (halodi_msgs__msg__JointSpaceCommand__Sequence *)malloc(sizeof(halodi_msgs__msg__JointSpaceCommand__Sequence));
  if (!array) {
    return NULL;
  }
  bool success = halodi_msgs__msg__JointSpaceCommand__Sequence__init(array, size);
  if (!success) {
    free(array);
    return NULL;
  }
  return array;
}

void
halodi_msgs__msg__JointSpaceCommand__Sequence__destroy(halodi_msgs__msg__JointSpaceCommand__Sequence * array)
{
  if (array) {
    halodi_msgs__msg__JointSpaceCommand__Sequence__fini(array);
  }
  free(array);
}
