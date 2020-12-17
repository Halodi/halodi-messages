// generated from rosidl_generator_c/resource/idl__functions.c.em
// with input from halodi_msgs:msg/TaskSpaceFeedback.idl
// generated code does not contain a copyright notice
#include "halodi_msgs/msg/task_space_feedback__functions.h"

#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>


// Include directives for member types
// Member `body_frame`
// Member `expressed_in_frame`
#include "halodi_msgs/msg/reference_frame_name__functions.h"
// Member `angular_acceleration`
// Member `linear_acceleration`
#include "geometry_msgs/msg/vector3__functions.h"
// Member `passivity_output`
#include "halodi_msgs/msg/passivity_data__functions.h"

bool
halodi_msgs__msg__TaskSpaceFeedback__init(halodi_msgs__msg__TaskSpaceFeedback * msg)
{
  if (!msg) {
    return false;
  }
  // body_frame
  if (!halodi_msgs__msg__ReferenceFrameName__init(&msg->body_frame)) {
    halodi_msgs__msg__TaskSpaceFeedback__fini(msg);
    return false;
  }
  // expressed_in_frame
  if (!halodi_msgs__msg__ReferenceFrameName__init(&msg->expressed_in_frame)) {
    halodi_msgs__msg__TaskSpaceFeedback__fini(msg);
    return false;
  }
  // express_in_z_up
  // angular_acceleration
  if (!geometry_msgs__msg__Vector3__init(&msg->angular_acceleration)) {
    halodi_msgs__msg__TaskSpaceFeedback__fini(msg);
    return false;
  }
  // linear_acceleration
  if (!geometry_msgs__msg__Vector3__init(&msg->linear_acceleration)) {
    halodi_msgs__msg__TaskSpaceFeedback__fini(msg);
    return false;
  }
  // passivity_output
  if (!halodi_msgs__msg__PassivityData__Sequence__init(&msg->passivity_output, 0)) {
    halodi_msgs__msg__TaskSpaceFeedback__fini(msg);
    return false;
  }
  return true;
}

void
halodi_msgs__msg__TaskSpaceFeedback__fini(halodi_msgs__msg__TaskSpaceFeedback * msg)
{
  if (!msg) {
    return;
  }
  // body_frame
  halodi_msgs__msg__ReferenceFrameName__fini(&msg->body_frame);
  // expressed_in_frame
  halodi_msgs__msg__ReferenceFrameName__fini(&msg->expressed_in_frame);
  // express_in_z_up
  // angular_acceleration
  geometry_msgs__msg__Vector3__fini(&msg->angular_acceleration);
  // linear_acceleration
  geometry_msgs__msg__Vector3__fini(&msg->linear_acceleration);
  // passivity_output
  halodi_msgs__msg__PassivityData__Sequence__fini(&msg->passivity_output);
}

halodi_msgs__msg__TaskSpaceFeedback *
halodi_msgs__msg__TaskSpaceFeedback__create()
{
  halodi_msgs__msg__TaskSpaceFeedback * msg = (halodi_msgs__msg__TaskSpaceFeedback *)malloc(sizeof(halodi_msgs__msg__TaskSpaceFeedback));
  if (!msg) {
    return NULL;
  }
  memset(msg, 0, sizeof(halodi_msgs__msg__TaskSpaceFeedback));
  bool success = halodi_msgs__msg__TaskSpaceFeedback__init(msg);
  if (!success) {
    free(msg);
    return NULL;
  }
  return msg;
}

void
halodi_msgs__msg__TaskSpaceFeedback__destroy(halodi_msgs__msg__TaskSpaceFeedback * msg)
{
  if (msg) {
    halodi_msgs__msg__TaskSpaceFeedback__fini(msg);
  }
  free(msg);
}


bool
halodi_msgs__msg__TaskSpaceFeedback__Sequence__init(halodi_msgs__msg__TaskSpaceFeedback__Sequence * array, size_t size)
{
  if (!array) {
    return false;
  }
  halodi_msgs__msg__TaskSpaceFeedback * data = NULL;
  if (size) {
    data = (halodi_msgs__msg__TaskSpaceFeedback *)calloc(size, sizeof(halodi_msgs__msg__TaskSpaceFeedback));
    if (!data) {
      return false;
    }
    // initialize all array elements
    size_t i;
    for (i = 0; i < size; ++i) {
      bool success = halodi_msgs__msg__TaskSpaceFeedback__init(&data[i]);
      if (!success) {
        break;
      }
    }
    if (i < size) {
      // if initialization failed finalize the already initialized array elements
      for (; i > 0; --i) {
        halodi_msgs__msg__TaskSpaceFeedback__fini(&data[i - 1]);
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
halodi_msgs__msg__TaskSpaceFeedback__Sequence__fini(halodi_msgs__msg__TaskSpaceFeedback__Sequence * array)
{
  if (!array) {
    return;
  }
  if (array->data) {
    // ensure that data and capacity values are consistent
    assert(array->capacity > 0);
    // finalize all array elements
    for (size_t i = 0; i < array->capacity; ++i) {
      halodi_msgs__msg__TaskSpaceFeedback__fini(&array->data[i]);
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

halodi_msgs__msg__TaskSpaceFeedback__Sequence *
halodi_msgs__msg__TaskSpaceFeedback__Sequence__create(size_t size)
{
  halodi_msgs__msg__TaskSpaceFeedback__Sequence * array = (halodi_msgs__msg__TaskSpaceFeedback__Sequence *)malloc(sizeof(halodi_msgs__msg__TaskSpaceFeedback__Sequence));
  if (!array) {
    return NULL;
  }
  bool success = halodi_msgs__msg__TaskSpaceFeedback__Sequence__init(array, size);
  if (!success) {
    free(array);
    return NULL;
  }
  return array;
}

void
halodi_msgs__msg__TaskSpaceFeedback__Sequence__destroy(halodi_msgs__msg__TaskSpaceFeedback__Sequence * array)
{
  if (array) {
    halodi_msgs__msg__TaskSpaceFeedback__Sequence__fini(array);
  }
  free(array);
}
