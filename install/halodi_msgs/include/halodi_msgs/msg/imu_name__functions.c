// generated from rosidl_generator_c/resource/idl__functions.c.em
// with input from halodi_msgs:msg/ImuName.idl
// generated code does not contain a copyright notice
#include "halodi_msgs/msg/imu_name__functions.h"

#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>


bool
halodi_msgs__msg__ImuName__init(halodi_msgs__msg__ImuName * msg)
{
  if (!msg) {
    return false;
  }
  // imu_id
  return true;
}

void
halodi_msgs__msg__ImuName__fini(halodi_msgs__msg__ImuName * msg)
{
  if (!msg) {
    return;
  }
  // imu_id
}

halodi_msgs__msg__ImuName *
halodi_msgs__msg__ImuName__create()
{
  halodi_msgs__msg__ImuName * msg = (halodi_msgs__msg__ImuName *)malloc(sizeof(halodi_msgs__msg__ImuName));
  if (!msg) {
    return NULL;
  }
  memset(msg, 0, sizeof(halodi_msgs__msg__ImuName));
  bool success = halodi_msgs__msg__ImuName__init(msg);
  if (!success) {
    free(msg);
    return NULL;
  }
  return msg;
}

void
halodi_msgs__msg__ImuName__destroy(halodi_msgs__msg__ImuName * msg)
{
  if (msg) {
    halodi_msgs__msg__ImuName__fini(msg);
  }
  free(msg);
}


bool
halodi_msgs__msg__ImuName__Sequence__init(halodi_msgs__msg__ImuName__Sequence * array, size_t size)
{
  if (!array) {
    return false;
  }
  halodi_msgs__msg__ImuName * data = NULL;
  if (size) {
    data = (halodi_msgs__msg__ImuName *)calloc(size, sizeof(halodi_msgs__msg__ImuName));
    if (!data) {
      return false;
    }
    // initialize all array elements
    size_t i;
    for (i = 0; i < size; ++i) {
      bool success = halodi_msgs__msg__ImuName__init(&data[i]);
      if (!success) {
        break;
      }
    }
    if (i < size) {
      // if initialization failed finalize the already initialized array elements
      for (; i > 0; --i) {
        halodi_msgs__msg__ImuName__fini(&data[i - 1]);
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
halodi_msgs__msg__ImuName__Sequence__fini(halodi_msgs__msg__ImuName__Sequence * array)
{
  if (!array) {
    return;
  }
  if (array->data) {
    // ensure that data and capacity values are consistent
    assert(array->capacity > 0);
    // finalize all array elements
    for (size_t i = 0; i < array->capacity; ++i) {
      halodi_msgs__msg__ImuName__fini(&array->data[i]);
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

halodi_msgs__msg__ImuName__Sequence *
halodi_msgs__msg__ImuName__Sequence__create(size_t size)
{
  halodi_msgs__msg__ImuName__Sequence * array = (halodi_msgs__msg__ImuName__Sequence *)malloc(sizeof(halodi_msgs__msg__ImuName__Sequence));
  if (!array) {
    return NULL;
  }
  bool success = halodi_msgs__msg__ImuName__Sequence__init(array, size);
  if (!success) {
    free(array);
    return NULL;
  }
  return array;
}

void
halodi_msgs__msg__ImuName__Sequence__destroy(halodi_msgs__msg__ImuName__Sequence * array)
{
  if (array) {
    halodi_msgs__msg__ImuName__Sequence__fini(array);
  }
  free(array);
}
