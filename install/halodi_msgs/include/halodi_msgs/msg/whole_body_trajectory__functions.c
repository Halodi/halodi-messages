// generated from rosidl_generator_c/resource/idl__functions.c.em
// with input from halodi_msgs:msg/WholeBodyTrajectory.idl
// generated code does not contain a copyright notice
#include "halodi_msgs/msg/whole_body_trajectory__functions.h"

#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>


// Include directives for member types
// Member `trajectory_id`
#include "unique_identifier_msgs/msg/uuid__functions.h"
// Member `start_time`
#include "builtin_interfaces/msg/time__functions.h"
// Member `balance_mode`
#include "halodi_msgs/msg/balance_mode__functions.h"
// Member `interpolation_mode`
#include "halodi_msgs/msg/trajectory_interpolation__functions.h"
// Member `trajectory_points`
#include "halodi_msgs/msg/whole_body_trajectory_point__functions.h"

bool
halodi_msgs__msg__WholeBodyTrajectory__init(halodi_msgs__msg__WholeBodyTrajectory * msg)
{
  if (!msg) {
    return false;
  }
  // trajectory_id
  if (!unique_identifier_msgs__msg__UUID__init(&msg->trajectory_id)) {
    halodi_msgs__msg__WholeBodyTrajectory__fini(msg);
    return false;
  }
  // start_time
  if (!builtin_interfaces__msg__Time__Sequence__init(&msg->start_time, 0)) {
    halodi_msgs__msg__WholeBodyTrajectory__fini(msg);
    return false;
  }
  // balance_mode
  if (!halodi_msgs__msg__BalanceMode__Sequence__init(&msg->balance_mode, 0)) {
    halodi_msgs__msg__WholeBodyTrajectory__fini(msg);
    return false;
  }
  // append_trajectory
  // interpolation_mode
  if (!halodi_msgs__msg__TrajectoryInterpolation__init(&msg->interpolation_mode)) {
    halodi_msgs__msg__WholeBodyTrajectory__fini(msg);
    return false;
  }
  // trajectory_points
  if (!halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence__init(&msg->trajectory_points, 0)) {
    halodi_msgs__msg__WholeBodyTrajectory__fini(msg);
    return false;
  }
  return true;
}

void
halodi_msgs__msg__WholeBodyTrajectory__fini(halodi_msgs__msg__WholeBodyTrajectory * msg)
{
  if (!msg) {
    return;
  }
  // trajectory_id
  unique_identifier_msgs__msg__UUID__fini(&msg->trajectory_id);
  // start_time
  builtin_interfaces__msg__Time__Sequence__fini(&msg->start_time);
  // balance_mode
  halodi_msgs__msg__BalanceMode__Sequence__fini(&msg->balance_mode);
  // append_trajectory
  // interpolation_mode
  halodi_msgs__msg__TrajectoryInterpolation__fini(&msg->interpolation_mode);
  // trajectory_points
  halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence__fini(&msg->trajectory_points);
}

halodi_msgs__msg__WholeBodyTrajectory *
halodi_msgs__msg__WholeBodyTrajectory__create()
{
  halodi_msgs__msg__WholeBodyTrajectory * msg = (halodi_msgs__msg__WholeBodyTrajectory *)malloc(sizeof(halodi_msgs__msg__WholeBodyTrajectory));
  if (!msg) {
    return NULL;
  }
  memset(msg, 0, sizeof(halodi_msgs__msg__WholeBodyTrajectory));
  bool success = halodi_msgs__msg__WholeBodyTrajectory__init(msg);
  if (!success) {
    free(msg);
    return NULL;
  }
  return msg;
}

void
halodi_msgs__msg__WholeBodyTrajectory__destroy(halodi_msgs__msg__WholeBodyTrajectory * msg)
{
  if (msg) {
    halodi_msgs__msg__WholeBodyTrajectory__fini(msg);
  }
  free(msg);
}


bool
halodi_msgs__msg__WholeBodyTrajectory__Sequence__init(halodi_msgs__msg__WholeBodyTrajectory__Sequence * array, size_t size)
{
  if (!array) {
    return false;
  }
  halodi_msgs__msg__WholeBodyTrajectory * data = NULL;
  if (size) {
    data = (halodi_msgs__msg__WholeBodyTrajectory *)calloc(size, sizeof(halodi_msgs__msg__WholeBodyTrajectory));
    if (!data) {
      return false;
    }
    // initialize all array elements
    size_t i;
    for (i = 0; i < size; ++i) {
      bool success = halodi_msgs__msg__WholeBodyTrajectory__init(&data[i]);
      if (!success) {
        break;
      }
    }
    if (i < size) {
      // if initialization failed finalize the already initialized array elements
      for (; i > 0; --i) {
        halodi_msgs__msg__WholeBodyTrajectory__fini(&data[i - 1]);
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
halodi_msgs__msg__WholeBodyTrajectory__Sequence__fini(halodi_msgs__msg__WholeBodyTrajectory__Sequence * array)
{
  if (!array) {
    return;
  }
  if (array->data) {
    // ensure that data and capacity values are consistent
    assert(array->capacity > 0);
    // finalize all array elements
    for (size_t i = 0; i < array->capacity; ++i) {
      halodi_msgs__msg__WholeBodyTrajectory__fini(&array->data[i]);
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

halodi_msgs__msg__WholeBodyTrajectory__Sequence *
halodi_msgs__msg__WholeBodyTrajectory__Sequence__create(size_t size)
{
  halodi_msgs__msg__WholeBodyTrajectory__Sequence * array = (halodi_msgs__msg__WholeBodyTrajectory__Sequence *)malloc(sizeof(halodi_msgs__msg__WholeBodyTrajectory__Sequence));
  if (!array) {
    return NULL;
  }
  bool success = halodi_msgs__msg__WholeBodyTrajectory__Sequence__init(array, size);
  if (!success) {
    free(array);
    return NULL;
  }
  return array;
}

void
halodi_msgs__msg__WholeBodyTrajectory__Sequence__destroy(halodi_msgs__msg__WholeBodyTrajectory__Sequence * array)
{
  if (array) {
    halodi_msgs__msg__WholeBodyTrajectory__Sequence__fini(array);
  }
  free(array);
}
