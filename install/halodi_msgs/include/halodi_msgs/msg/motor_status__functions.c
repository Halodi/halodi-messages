// generated from rosidl_generator_c/resource/idl__functions.c.em
// with input from halodi_msgs:msg/MotorStatus.idl
// generated code does not contain a copyright notice
#include "halodi_msgs/msg/motor_status__functions.h"

#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>


// Include directives for member types
// Member `joints`
#include "halodi_msgs/msg/joint_name__functions.h"

bool
halodi_msgs__msg__MotorStatus__init(halodi_msgs__msg__MotorStatus * msg)
{
  if (!msg) {
    return false;
  }
  // status_level
  // joints
  if (!halodi_msgs__msg__JointName__Sequence__init(&msg->joints, 0)) {
    halodi_msgs__msg__MotorStatus__fini(msg);
    return false;
  }
  // motor_id
  // sto_enabled
  // over_temperature
  // motor_serial_number
  // driver_serial_number
  // motor_initialized
  // motor_temperature
  // driver_temperature
  // motor_error
  return true;
}

void
halodi_msgs__msg__MotorStatus__fini(halodi_msgs__msg__MotorStatus * msg)
{
  if (!msg) {
    return;
  }
  // status_level
  // joints
  halodi_msgs__msg__JointName__Sequence__fini(&msg->joints);
  // motor_id
  // sto_enabled
  // over_temperature
  // motor_serial_number
  // driver_serial_number
  // motor_initialized
  // motor_temperature
  // driver_temperature
  // motor_error
}

halodi_msgs__msg__MotorStatus *
halodi_msgs__msg__MotorStatus__create()
{
  halodi_msgs__msg__MotorStatus * msg = (halodi_msgs__msg__MotorStatus *)malloc(sizeof(halodi_msgs__msg__MotorStatus));
  if (!msg) {
    return NULL;
  }
  memset(msg, 0, sizeof(halodi_msgs__msg__MotorStatus));
  bool success = halodi_msgs__msg__MotorStatus__init(msg);
  if (!success) {
    free(msg);
    return NULL;
  }
  return msg;
}

void
halodi_msgs__msg__MotorStatus__destroy(halodi_msgs__msg__MotorStatus * msg)
{
  if (msg) {
    halodi_msgs__msg__MotorStatus__fini(msg);
  }
  free(msg);
}


bool
halodi_msgs__msg__MotorStatus__Sequence__init(halodi_msgs__msg__MotorStatus__Sequence * array, size_t size)
{
  if (!array) {
    return false;
  }
  halodi_msgs__msg__MotorStatus * data = NULL;
  if (size) {
    data = (halodi_msgs__msg__MotorStatus *)calloc(size, sizeof(halodi_msgs__msg__MotorStatus));
    if (!data) {
      return false;
    }
    // initialize all array elements
    size_t i;
    for (i = 0; i < size; ++i) {
      bool success = halodi_msgs__msg__MotorStatus__init(&data[i]);
      if (!success) {
        break;
      }
    }
    if (i < size) {
      // if initialization failed finalize the already initialized array elements
      for (; i > 0; --i) {
        halodi_msgs__msg__MotorStatus__fini(&data[i - 1]);
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
halodi_msgs__msg__MotorStatus__Sequence__fini(halodi_msgs__msg__MotorStatus__Sequence * array)
{
  if (!array) {
    return;
  }
  if (array->data) {
    // ensure that data and capacity values are consistent
    assert(array->capacity > 0);
    // finalize all array elements
    for (size_t i = 0; i < array->capacity; ++i) {
      halodi_msgs__msg__MotorStatus__fini(&array->data[i]);
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

halodi_msgs__msg__MotorStatus__Sequence *
halodi_msgs__msg__MotorStatus__Sequence__create(size_t size)
{
  halodi_msgs__msg__MotorStatus__Sequence * array = (halodi_msgs__msg__MotorStatus__Sequence *)malloc(sizeof(halodi_msgs__msg__MotorStatus__Sequence));
  if (!array) {
    return NULL;
  }
  bool success = halodi_msgs__msg__MotorStatus__Sequence__init(array, size);
  if (!success) {
    free(array);
    return NULL;
  }
  return array;
}

void
halodi_msgs__msg__MotorStatus__Sequence__destroy(halodi_msgs__msg__MotorStatus__Sequence * array)
{
  if (array) {
    halodi_msgs__msg__MotorStatus__Sequence__fini(array);
  }
  free(array);
}
