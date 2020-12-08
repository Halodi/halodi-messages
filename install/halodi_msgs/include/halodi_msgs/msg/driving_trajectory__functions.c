// generated from rosidl_generator_c/resource/idl__functions.c.em
// with input from halodi_msgs:msg/DrivingTrajectory.idl
// generated code does not contain a copyright notice
#include "halodi_msgs/msg/driving_trajectory__functions.h"

#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>


// Include directives for member types
// Member `trajectory_points`
#include "halodi_msgs/msg/driving_trajectory_point__functions.h"

bool
halodi_msgs__msg__DrivingTrajectory__init(halodi_msgs__msg__DrivingTrajectory * msg)
{
  if (!msg) {
    return false;
  }
  // look_ahead_distance
  // K
  // trajectory_points
  if (!halodi_msgs__msg__DrivingTrajectoryPoint__Sequence__init(&msg->trajectory_points, 0)) {
    halodi_msgs__msg__DrivingTrajectory__fini(msg);
    return false;
  }
  return true;
}

void
halodi_msgs__msg__DrivingTrajectory__fini(halodi_msgs__msg__DrivingTrajectory * msg)
{
  if (!msg) {
    return;
  }
  // look_ahead_distance
  // K
  // trajectory_points
  halodi_msgs__msg__DrivingTrajectoryPoint__Sequence__fini(&msg->trajectory_points);
}

halodi_msgs__msg__DrivingTrajectory *
halodi_msgs__msg__DrivingTrajectory__create()
{
  halodi_msgs__msg__DrivingTrajectory * msg = (halodi_msgs__msg__DrivingTrajectory *)malloc(sizeof(halodi_msgs__msg__DrivingTrajectory));
  if (!msg) {
    return NULL;
  }
  memset(msg, 0, sizeof(halodi_msgs__msg__DrivingTrajectory));
  bool success = halodi_msgs__msg__DrivingTrajectory__init(msg);
  if (!success) {
    free(msg);
    return NULL;
  }
  return msg;
}

void
halodi_msgs__msg__DrivingTrajectory__destroy(halodi_msgs__msg__DrivingTrajectory * msg)
{
  if (msg) {
    halodi_msgs__msg__DrivingTrajectory__fini(msg);
  }
  free(msg);
}


bool
halodi_msgs__msg__DrivingTrajectory__Sequence__init(halodi_msgs__msg__DrivingTrajectory__Sequence * array, size_t size)
{
  if (!array) {
    return false;
  }
  halodi_msgs__msg__DrivingTrajectory * data = NULL;
  if (size) {
    data = (halodi_msgs__msg__DrivingTrajectory *)calloc(size, sizeof(halodi_msgs__msg__DrivingTrajectory));
    if (!data) {
      return false;
    }
    // initialize all array elements
    size_t i;
    for (i = 0; i < size; ++i) {
      bool success = halodi_msgs__msg__DrivingTrajectory__init(&data[i]);
      if (!success) {
        break;
      }
    }
    if (i < size) {
      // if initialization failed finalize the already initialized array elements
      for (; i > 0; --i) {
        halodi_msgs__msg__DrivingTrajectory__fini(&data[i - 1]);
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
halodi_msgs__msg__DrivingTrajectory__Sequence__fini(halodi_msgs__msg__DrivingTrajectory__Sequence * array)
{
  if (!array) {
    return;
  }
  if (array->data) {
    // ensure that data and capacity values are consistent
    assert(array->capacity > 0);
    // finalize all array elements
    for (size_t i = 0; i < array->capacity; ++i) {
      halodi_msgs__msg__DrivingTrajectory__fini(&array->data[i]);
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

halodi_msgs__msg__DrivingTrajectory__Sequence *
halodi_msgs__msg__DrivingTrajectory__Sequence__create(size_t size)
{
  halodi_msgs__msg__DrivingTrajectory__Sequence * array = (halodi_msgs__msg__DrivingTrajectory__Sequence *)malloc(sizeof(halodi_msgs__msg__DrivingTrajectory__Sequence));
  if (!array) {
    return NULL;
  }
  bool success = halodi_msgs__msg__DrivingTrajectory__Sequence__init(array, size);
  if (!success) {
    free(array);
    return NULL;
  }
  return array;
}

void
halodi_msgs__msg__DrivingTrajectory__Sequence__destroy(halodi_msgs__msg__DrivingTrajectory__Sequence * array)
{
  if (array) {
    halodi_msgs__msg__DrivingTrajectory__Sequence__fini(array);
  }
  free(array);
}
