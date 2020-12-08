// generated from rosidl_generator_c/resource/idl__functions.c.em
// with input from halodi_msgs:msg/ImuMeasurement.idl
// generated code does not contain a copyright notice
#include "halodi_msgs/msg/imu_measurement__functions.h"

#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>


// Include directives for member types
// Member `imu`
#include "halodi_msgs/msg/imu_name__functions.h"
// Member `orientation`
#include "geometry_msgs/msg/quaternion__functions.h"
// Member `angular_velocity`
// Member `linear_acceleration`
#include "geometry_msgs/msg/vector3__functions.h"

bool
halodi_msgs__msg__ImuMeasurement__init(halodi_msgs__msg__ImuMeasurement * msg)
{
  if (!msg) {
    return false;
  }
  // imu
  if (!halodi_msgs__msg__ImuName__init(&msg->imu)) {
    halodi_msgs__msg__ImuMeasurement__fini(msg);
    return false;
  }
  // orientation
  if (!geometry_msgs__msg__Quaternion__init(&msg->orientation)) {
    halodi_msgs__msg__ImuMeasurement__fini(msg);
    return false;
  }
  // angular_velocity
  if (!geometry_msgs__msg__Vector3__init(&msg->angular_velocity)) {
    halodi_msgs__msg__ImuMeasurement__fini(msg);
    return false;
  }
  // linear_acceleration
  if (!geometry_msgs__msg__Vector3__init(&msg->linear_acceleration)) {
    halodi_msgs__msg__ImuMeasurement__fini(msg);
    return false;
  }
  return true;
}

void
halodi_msgs__msg__ImuMeasurement__fini(halodi_msgs__msg__ImuMeasurement * msg)
{
  if (!msg) {
    return;
  }
  // imu
  halodi_msgs__msg__ImuName__fini(&msg->imu);
  // orientation
  geometry_msgs__msg__Quaternion__fini(&msg->orientation);
  // angular_velocity
  geometry_msgs__msg__Vector3__fini(&msg->angular_velocity);
  // linear_acceleration
  geometry_msgs__msg__Vector3__fini(&msg->linear_acceleration);
}

halodi_msgs__msg__ImuMeasurement *
halodi_msgs__msg__ImuMeasurement__create()
{
  halodi_msgs__msg__ImuMeasurement * msg = (halodi_msgs__msg__ImuMeasurement *)malloc(sizeof(halodi_msgs__msg__ImuMeasurement));
  if (!msg) {
    return NULL;
  }
  memset(msg, 0, sizeof(halodi_msgs__msg__ImuMeasurement));
  bool success = halodi_msgs__msg__ImuMeasurement__init(msg);
  if (!success) {
    free(msg);
    return NULL;
  }
  return msg;
}

void
halodi_msgs__msg__ImuMeasurement__destroy(halodi_msgs__msg__ImuMeasurement * msg)
{
  if (msg) {
    halodi_msgs__msg__ImuMeasurement__fini(msg);
  }
  free(msg);
}


bool
halodi_msgs__msg__ImuMeasurement__Sequence__init(halodi_msgs__msg__ImuMeasurement__Sequence * array, size_t size)
{
  if (!array) {
    return false;
  }
  halodi_msgs__msg__ImuMeasurement * data = NULL;
  if (size) {
    data = (halodi_msgs__msg__ImuMeasurement *)calloc(size, sizeof(halodi_msgs__msg__ImuMeasurement));
    if (!data) {
      return false;
    }
    // initialize all array elements
    size_t i;
    for (i = 0; i < size; ++i) {
      bool success = halodi_msgs__msg__ImuMeasurement__init(&data[i]);
      if (!success) {
        break;
      }
    }
    if (i < size) {
      // if initialization failed finalize the already initialized array elements
      for (; i > 0; --i) {
        halodi_msgs__msg__ImuMeasurement__fini(&data[i - 1]);
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
halodi_msgs__msg__ImuMeasurement__Sequence__fini(halodi_msgs__msg__ImuMeasurement__Sequence * array)
{
  if (!array) {
    return;
  }
  if (array->data) {
    // ensure that data and capacity values are consistent
    assert(array->capacity > 0);
    // finalize all array elements
    for (size_t i = 0; i < array->capacity; ++i) {
      halodi_msgs__msg__ImuMeasurement__fini(&array->data[i]);
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

halodi_msgs__msg__ImuMeasurement__Sequence *
halodi_msgs__msg__ImuMeasurement__Sequence__create(size_t size)
{
  halodi_msgs__msg__ImuMeasurement__Sequence * array = (halodi_msgs__msg__ImuMeasurement__Sequence *)malloc(sizeof(halodi_msgs__msg__ImuMeasurement__Sequence));
  if (!array) {
    return NULL;
  }
  bool success = halodi_msgs__msg__ImuMeasurement__Sequence__init(array, size);
  if (!success) {
    free(array);
    return NULL;
  }
  return array;
}

void
halodi_msgs__msg__ImuMeasurement__Sequence__destroy(halodi_msgs__msg__ImuMeasurement__Sequence * array)
{
  if (array) {
    halodi_msgs__msg__ImuMeasurement__Sequence__fini(array);
  }
  free(array);
}
