// generated from rosidl_generator_c/resource/idl__functions.c.em
// with input from halodi_msgs:msg/BatteryStatus.idl
// generated code does not contain a copyright notice
#include "halodi_msgs/msg/battery_status__functions.h"

#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>


bool
halodi_msgs__msg__BatteryStatus__init(halodi_msgs__msg__BatteryStatus * msg)
{
  if (!msg) {
    return false;
  }
  // battery_status_level
  // battery_voltage
  // low_battery_voltage
  // shutdown_battery_voltage
  return true;
}

void
halodi_msgs__msg__BatteryStatus__fini(halodi_msgs__msg__BatteryStatus * msg)
{
  if (!msg) {
    return;
  }
  // battery_status_level
  // battery_voltage
  // low_battery_voltage
  // shutdown_battery_voltage
}

halodi_msgs__msg__BatteryStatus *
halodi_msgs__msg__BatteryStatus__create()
{
  halodi_msgs__msg__BatteryStatus * msg = (halodi_msgs__msg__BatteryStatus *)malloc(sizeof(halodi_msgs__msg__BatteryStatus));
  if (!msg) {
    return NULL;
  }
  memset(msg, 0, sizeof(halodi_msgs__msg__BatteryStatus));
  bool success = halodi_msgs__msg__BatteryStatus__init(msg);
  if (!success) {
    free(msg);
    return NULL;
  }
  return msg;
}

void
halodi_msgs__msg__BatteryStatus__destroy(halodi_msgs__msg__BatteryStatus * msg)
{
  if (msg) {
    halodi_msgs__msg__BatteryStatus__fini(msg);
  }
  free(msg);
}


bool
halodi_msgs__msg__BatteryStatus__Sequence__init(halodi_msgs__msg__BatteryStatus__Sequence * array, size_t size)
{
  if (!array) {
    return false;
  }
  halodi_msgs__msg__BatteryStatus * data = NULL;
  if (size) {
    data = (halodi_msgs__msg__BatteryStatus *)calloc(size, sizeof(halodi_msgs__msg__BatteryStatus));
    if (!data) {
      return false;
    }
    // initialize all array elements
    size_t i;
    for (i = 0; i < size; ++i) {
      bool success = halodi_msgs__msg__BatteryStatus__init(&data[i]);
      if (!success) {
        break;
      }
    }
    if (i < size) {
      // if initialization failed finalize the already initialized array elements
      for (; i > 0; --i) {
        halodi_msgs__msg__BatteryStatus__fini(&data[i - 1]);
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
halodi_msgs__msg__BatteryStatus__Sequence__fini(halodi_msgs__msg__BatteryStatus__Sequence * array)
{
  if (!array) {
    return;
  }
  if (array->data) {
    // ensure that data and capacity values are consistent
    assert(array->capacity > 0);
    // finalize all array elements
    for (size_t i = 0; i < array->capacity; ++i) {
      halodi_msgs__msg__BatteryStatus__fini(&array->data[i]);
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

halodi_msgs__msg__BatteryStatus__Sequence *
halodi_msgs__msg__BatteryStatus__Sequence__create(size_t size)
{
  halodi_msgs__msg__BatteryStatus__Sequence * array = (halodi_msgs__msg__BatteryStatus__Sequence *)malloc(sizeof(halodi_msgs__msg__BatteryStatus__Sequence));
  if (!array) {
    return NULL;
  }
  bool success = halodi_msgs__msg__BatteryStatus__Sequence__init(array, size);
  if (!success) {
    free(array);
    return NULL;
  }
  return array;
}

void
halodi_msgs__msg__BatteryStatus__Sequence__destroy(halodi_msgs__msg__BatteryStatus__Sequence * array)
{
  if (array) {
    halodi_msgs__msg__BatteryStatus__Sequence__fini(array);
  }
  free(array);
}
