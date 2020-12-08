// generated from rosidl_generator_c/resource/idl__functions.c.em
// with input from halodi_msgs:msg/ARMarkers.idl
// generated code does not contain a copyright notice
#include "halodi_msgs/msg/ar_markers__functions.h"

#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>


// Include directives for member types
// Member `header`
#include "std_msgs/msg/header__functions.h"
// Member `markers`
#include "halodi_msgs/msg/ar_marker__functions.h"

bool
halodi_msgs__msg__ARMarkers__init(halodi_msgs__msg__ARMarkers * msg)
{
  if (!msg) {
    return false;
  }
  // header
  if (!std_msgs__msg__Header__init(&msg->header)) {
    halodi_msgs__msg__ARMarkers__fini(msg);
    return false;
  }
  // markers
  if (!halodi_msgs__msg__ARMarker__Sequence__init(&msg->markers, 0)) {
    halodi_msgs__msg__ARMarkers__fini(msg);
    return false;
  }
  return true;
}

void
halodi_msgs__msg__ARMarkers__fini(halodi_msgs__msg__ARMarkers * msg)
{
  if (!msg) {
    return;
  }
  // header
  std_msgs__msg__Header__fini(&msg->header);
  // markers
  halodi_msgs__msg__ARMarker__Sequence__fini(&msg->markers);
}

halodi_msgs__msg__ARMarkers *
halodi_msgs__msg__ARMarkers__create()
{
  halodi_msgs__msg__ARMarkers * msg = (halodi_msgs__msg__ARMarkers *)malloc(sizeof(halodi_msgs__msg__ARMarkers));
  if (!msg) {
    return NULL;
  }
  memset(msg, 0, sizeof(halodi_msgs__msg__ARMarkers));
  bool success = halodi_msgs__msg__ARMarkers__init(msg);
  if (!success) {
    free(msg);
    return NULL;
  }
  return msg;
}

void
halodi_msgs__msg__ARMarkers__destroy(halodi_msgs__msg__ARMarkers * msg)
{
  if (msg) {
    halodi_msgs__msg__ARMarkers__fini(msg);
  }
  free(msg);
}


bool
halodi_msgs__msg__ARMarkers__Sequence__init(halodi_msgs__msg__ARMarkers__Sequence * array, size_t size)
{
  if (!array) {
    return false;
  }
  halodi_msgs__msg__ARMarkers * data = NULL;
  if (size) {
    data = (halodi_msgs__msg__ARMarkers *)calloc(size, sizeof(halodi_msgs__msg__ARMarkers));
    if (!data) {
      return false;
    }
    // initialize all array elements
    size_t i;
    for (i = 0; i < size; ++i) {
      bool success = halodi_msgs__msg__ARMarkers__init(&data[i]);
      if (!success) {
        break;
      }
    }
    if (i < size) {
      // if initialization failed finalize the already initialized array elements
      for (; i > 0; --i) {
        halodi_msgs__msg__ARMarkers__fini(&data[i - 1]);
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
halodi_msgs__msg__ARMarkers__Sequence__fini(halodi_msgs__msg__ARMarkers__Sequence * array)
{
  if (!array) {
    return;
  }
  if (array->data) {
    // ensure that data and capacity values are consistent
    assert(array->capacity > 0);
    // finalize all array elements
    for (size_t i = 0; i < array->capacity; ++i) {
      halodi_msgs__msg__ARMarkers__fini(&array->data[i]);
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

halodi_msgs__msg__ARMarkers__Sequence *
halodi_msgs__msg__ARMarkers__Sequence__create(size_t size)
{
  halodi_msgs__msg__ARMarkers__Sequence * array = (halodi_msgs__msg__ARMarkers__Sequence *)malloc(sizeof(halodi_msgs__msg__ARMarkers__Sequence));
  if (!array) {
    return NULL;
  }
  bool success = halodi_msgs__msg__ARMarkers__Sequence__init(array, size);
  if (!success) {
    free(array);
    return NULL;
  }
  return array;
}

void
halodi_msgs__msg__ARMarkers__Sequence__destroy(halodi_msgs__msg__ARMarkers__Sequence * array)
{
  if (array) {
    halodi_msgs__msg__ARMarkers__Sequence__fini(array);
  }
  free(array);
}
