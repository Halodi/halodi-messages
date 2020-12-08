// generated from rosidl_generator_c/resource/idl__functions.c.em
// with input from halodi_msgs:msg/RobotStatus.idl
// generated code does not contain a copyright notice
#include "halodi_msgs/msg/robot_status__functions.h"

#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>


// Include directives for member types
// Member `header`
#include "std_msgs/msg/header__functions.h"
// Member `battery_status`
#include "halodi_msgs/msg/battery_status__functions.h"
// Member `joint_status`
#include "halodi_msgs/msg/joint_status__functions.h"
// Member `motor_status`
#include "halodi_msgs/msg/motor_status__functions.h"

bool
halodi_msgs__msg__RobotStatus__init(halodi_msgs__msg__RobotStatus * msg)
{
  if (!msg) {
    return false;
  }
  // header
  if (!std_msgs__msg__Header__init(&msg->header)) {
    halodi_msgs__msg__RobotStatus__fini(msg);
    return false;
  }
  // robot_status_level
  // battery_status
  if (!halodi_msgs__msg__BatteryStatus__init(&msg->battery_status)) {
    halodi_msgs__msg__RobotStatus__fini(msg);
    return false;
  }
  // backpack_estop_enabled
  // wireless_estop_enabled
  // over_temperature
  // driving_disabled
  // joint_status
  if (!halodi_msgs__msg__JointStatus__Sequence__init(&msg->joint_status, 0)) {
    halodi_msgs__msg__RobotStatus__fini(msg);
    return false;
  }
  // motor_status
  if (!halodi_msgs__msg__MotorStatus__Sequence__init(&msg->motor_status, 0)) {
    halodi_msgs__msg__RobotStatus__fini(msg);
    return false;
  }
  // runtime_since_start
  // total_runtime
  // numberOfRuns
  return true;
}

void
halodi_msgs__msg__RobotStatus__fini(halodi_msgs__msg__RobotStatus * msg)
{
  if (!msg) {
    return;
  }
  // header
  std_msgs__msg__Header__fini(&msg->header);
  // robot_status_level
  // battery_status
  halodi_msgs__msg__BatteryStatus__fini(&msg->battery_status);
  // backpack_estop_enabled
  // wireless_estop_enabled
  // over_temperature
  // driving_disabled
  // joint_status
  halodi_msgs__msg__JointStatus__Sequence__fini(&msg->joint_status);
  // motor_status
  halodi_msgs__msg__MotorStatus__Sequence__fini(&msg->motor_status);
  // runtime_since_start
  // total_runtime
  // numberOfRuns
}

halodi_msgs__msg__RobotStatus *
halodi_msgs__msg__RobotStatus__create()
{
  halodi_msgs__msg__RobotStatus * msg = (halodi_msgs__msg__RobotStatus *)malloc(sizeof(halodi_msgs__msg__RobotStatus));
  if (!msg) {
    return NULL;
  }
  memset(msg, 0, sizeof(halodi_msgs__msg__RobotStatus));
  bool success = halodi_msgs__msg__RobotStatus__init(msg);
  if (!success) {
    free(msg);
    return NULL;
  }
  return msg;
}

void
halodi_msgs__msg__RobotStatus__destroy(halodi_msgs__msg__RobotStatus * msg)
{
  if (msg) {
    halodi_msgs__msg__RobotStatus__fini(msg);
  }
  free(msg);
}


bool
halodi_msgs__msg__RobotStatus__Sequence__init(halodi_msgs__msg__RobotStatus__Sequence * array, size_t size)
{
  if (!array) {
    return false;
  }
  halodi_msgs__msg__RobotStatus * data = NULL;
  if (size) {
    data = (halodi_msgs__msg__RobotStatus *)calloc(size, sizeof(halodi_msgs__msg__RobotStatus));
    if (!data) {
      return false;
    }
    // initialize all array elements
    size_t i;
    for (i = 0; i < size; ++i) {
      bool success = halodi_msgs__msg__RobotStatus__init(&data[i]);
      if (!success) {
        break;
      }
    }
    if (i < size) {
      // if initialization failed finalize the already initialized array elements
      for (; i > 0; --i) {
        halodi_msgs__msg__RobotStatus__fini(&data[i - 1]);
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
halodi_msgs__msg__RobotStatus__Sequence__fini(halodi_msgs__msg__RobotStatus__Sequence * array)
{
  if (!array) {
    return;
  }
  if (array->data) {
    // ensure that data and capacity values are consistent
    assert(array->capacity > 0);
    // finalize all array elements
    for (size_t i = 0; i < array->capacity; ++i) {
      halodi_msgs__msg__RobotStatus__fini(&array->data[i]);
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

halodi_msgs__msg__RobotStatus__Sequence *
halodi_msgs__msg__RobotStatus__Sequence__create(size_t size)
{
  halodi_msgs__msg__RobotStatus__Sequence * array = (halodi_msgs__msg__RobotStatus__Sequence *)malloc(sizeof(halodi_msgs__msg__RobotStatus__Sequence));
  if (!array) {
    return NULL;
  }
  bool success = halodi_msgs__msg__RobotStatus__Sequence__init(array, size);
  if (!success) {
    free(array);
    return NULL;
  }
  return array;
}

void
halodi_msgs__msg__RobotStatus__Sequence__destroy(halodi_msgs__msg__RobotStatus__Sequence * array)
{
  if (array) {
    halodi_msgs__msg__RobotStatus__Sequence__fini(array);
  }
  free(array);
}
