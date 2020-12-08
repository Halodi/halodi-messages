// generated from rosidl_generator_c/resource/idl__functions.c.em
// with input from halodi_msgs:msg/ARMarker.idl
// generated code does not contain a copyright notice
#include "halodi_msgs/msg/ar_marker__functions.h"

#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>


// Include directives for member types
// Member `data`
#include "rosidl_generator_c/string_functions.h"
// Member `points`
#include "geometry_msgs/msg/point__functions.h"
// Member `pose`
#include "geometry_msgs/msg/pose_stamped__functions.h"

bool
halodi_msgs__msg__ARMarker__init(halodi_msgs__msg__ARMarker * msg)
{
  if (!msg) {
    return false;
  }
  // data
  if (!rosidl_generator_c__String__init(&msg->data)) {
    halodi_msgs__msg__ARMarker__fini(msg);
    return false;
  }
  // points
  if (!geometry_msgs__msg__Point__Sequence__init(&msg->points, 0)) {
    halodi_msgs__msg__ARMarker__fini(msg);
    return false;
  }
  // pose
  if (!geometry_msgs__msg__PoseStamped__init(&msg->pose)) {
    halodi_msgs__msg__ARMarker__fini(msg);
    return false;
  }
  return true;
}

void
halodi_msgs__msg__ARMarker__fini(halodi_msgs__msg__ARMarker * msg)
{
  if (!msg) {
    return;
  }
  // data
  rosidl_generator_c__String__fini(&msg->data);
  // points
  geometry_msgs__msg__Point__Sequence__fini(&msg->points);
  // pose
  geometry_msgs__msg__PoseStamped__fini(&msg->pose);
}

halodi_msgs__msg__ARMarker *
halodi_msgs__msg__ARMarker__create()
{
  halodi_msgs__msg__ARMarker * msg = (halodi_msgs__msg__ARMarker *)malloc(sizeof(halodi_msgs__msg__ARMarker));
  if (!msg) {
    return NULL;
  }
  memset(msg, 0, sizeof(halodi_msgs__msg__ARMarker));
  bool success = halodi_msgs__msg__ARMarker__init(msg);
  if (!success) {
    free(msg);
    return NULL;
  }
  return msg;
}

void
halodi_msgs__msg__ARMarker__destroy(halodi_msgs__msg__ARMarker * msg)
{
  if (msg) {
    halodi_msgs__msg__ARMarker__fini(msg);
  }
  free(msg);
}


bool
halodi_msgs__msg__ARMarker__Sequence__init(halodi_msgs__msg__ARMarker__Sequence * array, size_t size)
{
  if (!array) {
    return false;
  }
  halodi_msgs__msg__ARMarker * data = NULL;
  if (size) {
    data = (halodi_msgs__msg__ARMarker *)calloc(size, sizeof(halodi_msgs__msg__ARMarker));
    if (!data) {
      return false;
    }
    // initialize all array elements
    size_t i;
    for (i = 0; i < size; ++i) {
      bool success = halodi_msgs__msg__ARMarker__init(&data[i]);
      if (!success) {
        break;
      }
    }
    if (i < size) {
      // if initialization failed finalize the already initialized array elements
      for (; i > 0; --i) {
        halodi_msgs__msg__ARMarker__fini(&data[i - 1]);
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
halodi_msgs__msg__ARMarker__Sequence__fini(halodi_msgs__msg__ARMarker__Sequence * array)
{
  if (!array) {
    return;
  }
  if (array->data) {
    // ensure that data and capacity values are consistent
    assert(array->capacity > 0);
    // finalize all array elements
    for (size_t i = 0; i < array->capacity; ++i) {
      halodi_msgs__msg__ARMarker__fini(&array->data[i]);
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

halodi_msgs__msg__ARMarker__Sequence *
halodi_msgs__msg__ARMarker__Sequence__create(size_t size)
{
  halodi_msgs__msg__ARMarker__Sequence * array = (halodi_msgs__msg__ARMarker__Sequence *)malloc(sizeof(halodi_msgs__msg__ARMarker__Sequence));
  if (!array) {
    return NULL;
  }
  bool success = halodi_msgs__msg__ARMarker__Sequence__init(array, size);
  if (!success) {
    free(array);
    return NULL;
  }
  return array;
}

void
halodi_msgs__msg__ARMarker__Sequence__destroy(halodi_msgs__msg__ARMarker__Sequence * array)
{
  if (array) {
    halodi_msgs__msg__ARMarker__Sequence__fini(array);
  }
  free(array);
}
