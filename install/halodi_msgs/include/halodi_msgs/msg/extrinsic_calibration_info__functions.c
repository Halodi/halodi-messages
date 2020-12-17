// generated from rosidl_generator_c/resource/idl__functions.c.em
// with input from halodi_msgs:msg/ExtrinsicCalibrationInfo.idl
// generated code does not contain a copyright notice
#include "halodi_msgs/msg/extrinsic_calibration_info__functions.h"

#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>


// Include directives for member types
// Member `sensor_transforms`
// Member `link_infos`
#include "geometry_msgs/msg/transform_stamped__functions.h"
// Member `joint_infos`
#include "halodi_msgs/msg/robot_joint_calibration_info__functions.h"

bool
halodi_msgs__msg__ExtrinsicCalibrationInfo__init(halodi_msgs__msg__ExtrinsicCalibrationInfo * msg)
{
  if (!msg) {
    return false;
  }
  // sensor_transforms
  if (!geometry_msgs__msg__TransformStamped__Sequence__init(&msg->sensor_transforms, 0)) {
    halodi_msgs__msg__ExtrinsicCalibrationInfo__fini(msg);
    return false;
  }
  // link_infos
  if (!geometry_msgs__msg__TransformStamped__Sequence__init(&msg->link_infos, 0)) {
    halodi_msgs__msg__ExtrinsicCalibrationInfo__fini(msg);
    return false;
  }
  // joint_infos
  if (!halodi_msgs__msg__RobotJointCalibrationInfo__Sequence__init(&msg->joint_infos, 0)) {
    halodi_msgs__msg__ExtrinsicCalibrationInfo__fini(msg);
    return false;
  }
  return true;
}

void
halodi_msgs__msg__ExtrinsicCalibrationInfo__fini(halodi_msgs__msg__ExtrinsicCalibrationInfo * msg)
{
  if (!msg) {
    return;
  }
  // sensor_transforms
  geometry_msgs__msg__TransformStamped__Sequence__fini(&msg->sensor_transforms);
  // link_infos
  geometry_msgs__msg__TransformStamped__Sequence__fini(&msg->link_infos);
  // joint_infos
  halodi_msgs__msg__RobotJointCalibrationInfo__Sequence__fini(&msg->joint_infos);
}

halodi_msgs__msg__ExtrinsicCalibrationInfo *
halodi_msgs__msg__ExtrinsicCalibrationInfo__create()
{
  halodi_msgs__msg__ExtrinsicCalibrationInfo * msg = (halodi_msgs__msg__ExtrinsicCalibrationInfo *)malloc(sizeof(halodi_msgs__msg__ExtrinsicCalibrationInfo));
  if (!msg) {
    return NULL;
  }
  memset(msg, 0, sizeof(halodi_msgs__msg__ExtrinsicCalibrationInfo));
  bool success = halodi_msgs__msg__ExtrinsicCalibrationInfo__init(msg);
  if (!success) {
    free(msg);
    return NULL;
  }
  return msg;
}

void
halodi_msgs__msg__ExtrinsicCalibrationInfo__destroy(halodi_msgs__msg__ExtrinsicCalibrationInfo * msg)
{
  if (msg) {
    halodi_msgs__msg__ExtrinsicCalibrationInfo__fini(msg);
  }
  free(msg);
}


bool
halodi_msgs__msg__ExtrinsicCalibrationInfo__Sequence__init(halodi_msgs__msg__ExtrinsicCalibrationInfo__Sequence * array, size_t size)
{
  if (!array) {
    return false;
  }
  halodi_msgs__msg__ExtrinsicCalibrationInfo * data = NULL;
  if (size) {
    data = (halodi_msgs__msg__ExtrinsicCalibrationInfo *)calloc(size, sizeof(halodi_msgs__msg__ExtrinsicCalibrationInfo));
    if (!data) {
      return false;
    }
    // initialize all array elements
    size_t i;
    for (i = 0; i < size; ++i) {
      bool success = halodi_msgs__msg__ExtrinsicCalibrationInfo__init(&data[i]);
      if (!success) {
        break;
      }
    }
    if (i < size) {
      // if initialization failed finalize the already initialized array elements
      for (; i > 0; --i) {
        halodi_msgs__msg__ExtrinsicCalibrationInfo__fini(&data[i - 1]);
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
halodi_msgs__msg__ExtrinsicCalibrationInfo__Sequence__fini(halodi_msgs__msg__ExtrinsicCalibrationInfo__Sequence * array)
{
  if (!array) {
    return;
  }
  if (array->data) {
    // ensure that data and capacity values are consistent
    assert(array->capacity > 0);
    // finalize all array elements
    for (size_t i = 0; i < array->capacity; ++i) {
      halodi_msgs__msg__ExtrinsicCalibrationInfo__fini(&array->data[i]);
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

halodi_msgs__msg__ExtrinsicCalibrationInfo__Sequence *
halodi_msgs__msg__ExtrinsicCalibrationInfo__Sequence__create(size_t size)
{
  halodi_msgs__msg__ExtrinsicCalibrationInfo__Sequence * array = (halodi_msgs__msg__ExtrinsicCalibrationInfo__Sequence *)malloc(sizeof(halodi_msgs__msg__ExtrinsicCalibrationInfo__Sequence));
  if (!array) {
    return NULL;
  }
  bool success = halodi_msgs__msg__ExtrinsicCalibrationInfo__Sequence__init(array, size);
  if (!success) {
    free(array);
    return NULL;
  }
  return array;
}

void
halodi_msgs__msg__ExtrinsicCalibrationInfo__Sequence__destroy(halodi_msgs__msg__ExtrinsicCalibrationInfo__Sequence * array)
{
  if (array) {
    halodi_msgs__msg__ExtrinsicCalibrationInfo__Sequence__fini(array);
  }
  free(array);
}
