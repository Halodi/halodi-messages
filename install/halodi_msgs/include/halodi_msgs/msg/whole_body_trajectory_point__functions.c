// generated from rosidl_generator_c/resource/idl__functions.c.em
// with input from halodi_msgs:msg/WholeBodyTrajectoryPoint.idl
// generated code does not contain a copyright notice
#include "halodi_msgs/msg/whole_body_trajectory_point__functions.h"

#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>


// Include directives for member types
// Member `time_from_start`
#include "builtin_interfaces/msg/duration__functions.h"
// Member `task_space_commands`
#include "halodi_msgs/msg/task_space_command__functions.h"
// Member `joint_space_commands`
#include "halodi_msgs/msg/joint_space_command__functions.h"
// Member `contact_point_commands`
#include "halodi_msgs/msg/contact_point_command__functions.h"
// Member `icp_offset_command`
#include "geometry_msgs/msg/vector3__functions.h"

bool
halodi_msgs__msg__WholeBodyTrajectoryPoint__init(halodi_msgs__msg__WholeBodyTrajectoryPoint * msg)
{
  if (!msg) {
    return false;
  }
  // time_from_start
  if (!builtin_interfaces__msg__Duration__init(&msg->time_from_start)) {
    halodi_msgs__msg__WholeBodyTrajectoryPoint__fini(msg);
    return false;
  }
  // task_space_commands
  if (!halodi_msgs__msg__TaskSpaceCommand__Sequence__init(&msg->task_space_commands, 0)) {
    halodi_msgs__msg__WholeBodyTrajectoryPoint__fini(msg);
    return false;
  }
  // joint_space_commands
  if (!halodi_msgs__msg__JointSpaceCommand__Sequence__init(&msg->joint_space_commands, 0)) {
    halodi_msgs__msg__WholeBodyTrajectoryPoint__fini(msg);
    return false;
  }
  // contact_point_commands
  if (!halodi_msgs__msg__ContactPointCommand__Sequence__init(&msg->contact_point_commands, 0)) {
    halodi_msgs__msg__WholeBodyTrajectoryPoint__fini(msg);
    return false;
  }
  // icp_offset_command
  if (!geometry_msgs__msg__Vector3__Sequence__init(&msg->icp_offset_command, 0)) {
    halodi_msgs__msg__WholeBodyTrajectoryPoint__fini(msg);
    return false;
  }
  return true;
}

void
halodi_msgs__msg__WholeBodyTrajectoryPoint__fini(halodi_msgs__msg__WholeBodyTrajectoryPoint * msg)
{
  if (!msg) {
    return;
  }
  // time_from_start
  builtin_interfaces__msg__Duration__fini(&msg->time_from_start);
  // task_space_commands
  halodi_msgs__msg__TaskSpaceCommand__Sequence__fini(&msg->task_space_commands);
  // joint_space_commands
  halodi_msgs__msg__JointSpaceCommand__Sequence__fini(&msg->joint_space_commands);
  // contact_point_commands
  halodi_msgs__msg__ContactPointCommand__Sequence__fini(&msg->contact_point_commands);
  // icp_offset_command
  geometry_msgs__msg__Vector3__Sequence__fini(&msg->icp_offset_command);
}

halodi_msgs__msg__WholeBodyTrajectoryPoint *
halodi_msgs__msg__WholeBodyTrajectoryPoint__create()
{
  halodi_msgs__msg__WholeBodyTrajectoryPoint * msg = (halodi_msgs__msg__WholeBodyTrajectoryPoint *)malloc(sizeof(halodi_msgs__msg__WholeBodyTrajectoryPoint));
  if (!msg) {
    return NULL;
  }
  memset(msg, 0, sizeof(halodi_msgs__msg__WholeBodyTrajectoryPoint));
  bool success = halodi_msgs__msg__WholeBodyTrajectoryPoint__init(msg);
  if (!success) {
    free(msg);
    return NULL;
  }
  return msg;
}

void
halodi_msgs__msg__WholeBodyTrajectoryPoint__destroy(halodi_msgs__msg__WholeBodyTrajectoryPoint * msg)
{
  if (msg) {
    halodi_msgs__msg__WholeBodyTrajectoryPoint__fini(msg);
  }
  free(msg);
}


bool
halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence__init(halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence * array, size_t size)
{
  if (!array) {
    return false;
  }
  halodi_msgs__msg__WholeBodyTrajectoryPoint * data = NULL;
  if (size) {
    data = (halodi_msgs__msg__WholeBodyTrajectoryPoint *)calloc(size, sizeof(halodi_msgs__msg__WholeBodyTrajectoryPoint));
    if (!data) {
      return false;
    }
    // initialize all array elements
    size_t i;
    for (i = 0; i < size; ++i) {
      bool success = halodi_msgs__msg__WholeBodyTrajectoryPoint__init(&data[i]);
      if (!success) {
        break;
      }
    }
    if (i < size) {
      // if initialization failed finalize the already initialized array elements
      for (; i > 0; --i) {
        halodi_msgs__msg__WholeBodyTrajectoryPoint__fini(&data[i - 1]);
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
halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence__fini(halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence * array)
{
  if (!array) {
    return;
  }
  if (array->data) {
    // ensure that data and capacity values are consistent
    assert(array->capacity > 0);
    // finalize all array elements
    for (size_t i = 0; i < array->capacity; ++i) {
      halodi_msgs__msg__WholeBodyTrajectoryPoint__fini(&array->data[i]);
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

halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence *
halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence__create(size_t size)
{
  halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence * array = (halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence *)malloc(sizeof(halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence));
  if (!array) {
    return NULL;
  }
  bool success = halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence__init(array, size);
  if (!success) {
    free(array);
    return NULL;
  }
  return array;
}

void
halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence__destroy(halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence * array)
{
  if (array) {
    halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence__fini(array);
  }
  free(array);
}
