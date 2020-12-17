// generated from rosidl_generator_c/resource/idl__functions.c.em
// with input from halodi_msgs:msg/WholeBodyState.idl
// generated code does not contain a copyright notice
#include "halodi_msgs/msg/whole_body_state__functions.h"

#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>


// Include directives for member types
// Member `header`
#include "std_msgs/msg/header__functions.h"
// Member `controller_state`
#include "rosidl_generator_c/string_functions.h"
// Member `current_balance_mode`
#include "halodi_msgs/msg/balance_mode__functions.h"
// Member `pose`
#include "geometry_msgs/msg/pose__functions.h"
// Member `angular_velocity`
// Member `linear_velocity`
#include "geometry_msgs/msg/vector3__functions.h"
// Member `imu_measurements`
#include "halodi_msgs/msg/imu_measurement__functions.h"
// Member `joint_states`
#include "halodi_msgs/msg/joint_measurement__functions.h"
// Member `taskspace_feedback`
#include "halodi_msgs/msg/task_space_feedback__functions.h"

bool
halodi_msgs__msg__WholeBodyState__init(halodi_msgs__msg__WholeBodyState * msg)
{
  if (!msg) {
    return false;
  }
  // header
  if (!std_msgs__msg__Header__init(&msg->header)) {
    halodi_msgs__msg__WholeBodyState__fini(msg);
    return false;
  }
  // last_received_sequence_id
  // controller_state
  if (!rosidl_generator_c__String__init(&msg->controller_state)) {
    halodi_msgs__msg__WholeBodyState__fini(msg);
    return false;
  }
  // current_balance_mode
  if (!halodi_msgs__msg__BalanceMode__init(&msg->current_balance_mode)) {
    halodi_msgs__msg__WholeBodyState__fini(msg);
    return false;
  }
  // robot_status
  // pose
  if (!geometry_msgs__msg__Pose__init(&msg->pose)) {
    halodi_msgs__msg__WholeBodyState__fini(msg);
    return false;
  }
  // angular_velocity
  if (!geometry_msgs__msg__Vector3__init(&msg->angular_velocity)) {
    halodi_msgs__msg__WholeBodyState__fini(msg);
    return false;
  }
  // linear_velocity
  if (!geometry_msgs__msg__Vector3__init(&msg->linear_velocity)) {
    halodi_msgs__msg__WholeBodyState__fini(msg);
    return false;
  }
  // imu_measurements
  if (!halodi_msgs__msg__ImuMeasurement__Sequence__init(&msg->imu_measurements, 0)) {
    halodi_msgs__msg__WholeBodyState__fini(msg);
    return false;
  }
  // joint_states
  if (!halodi_msgs__msg__JointMeasurement__Sequence__init(&msg->joint_states, 0)) {
    halodi_msgs__msg__WholeBodyState__fini(msg);
    return false;
  }
  // taskspace_feedback
  if (!halodi_msgs__msg__TaskSpaceFeedback__Sequence__init(&msg->taskspace_feedback, 0)) {
    halodi_msgs__msg__WholeBodyState__fini(msg);
    return false;
  }
  return true;
}

void
halodi_msgs__msg__WholeBodyState__fini(halodi_msgs__msg__WholeBodyState * msg)
{
  if (!msg) {
    return;
  }
  // header
  std_msgs__msg__Header__fini(&msg->header);
  // last_received_sequence_id
  // controller_state
  rosidl_generator_c__String__fini(&msg->controller_state);
  // current_balance_mode
  halodi_msgs__msg__BalanceMode__fini(&msg->current_balance_mode);
  // robot_status
  // pose
  geometry_msgs__msg__Pose__fini(&msg->pose);
  // angular_velocity
  geometry_msgs__msg__Vector3__fini(&msg->angular_velocity);
  // linear_velocity
  geometry_msgs__msg__Vector3__fini(&msg->linear_velocity);
  // imu_measurements
  halodi_msgs__msg__ImuMeasurement__Sequence__fini(&msg->imu_measurements);
  // joint_states
  halodi_msgs__msg__JointMeasurement__Sequence__fini(&msg->joint_states);
  // taskspace_feedback
  halodi_msgs__msg__TaskSpaceFeedback__Sequence__fini(&msg->taskspace_feedback);
}

halodi_msgs__msg__WholeBodyState *
halodi_msgs__msg__WholeBodyState__create()
{
  halodi_msgs__msg__WholeBodyState * msg = (halodi_msgs__msg__WholeBodyState *)malloc(sizeof(halodi_msgs__msg__WholeBodyState));
  if (!msg) {
    return NULL;
  }
  memset(msg, 0, sizeof(halodi_msgs__msg__WholeBodyState));
  bool success = halodi_msgs__msg__WholeBodyState__init(msg);
  if (!success) {
    free(msg);
    return NULL;
  }
  return msg;
}

void
halodi_msgs__msg__WholeBodyState__destroy(halodi_msgs__msg__WholeBodyState * msg)
{
  if (msg) {
    halodi_msgs__msg__WholeBodyState__fini(msg);
  }
  free(msg);
}


bool
halodi_msgs__msg__WholeBodyState__Sequence__init(halodi_msgs__msg__WholeBodyState__Sequence * array, size_t size)
{
  if (!array) {
    return false;
  }
  halodi_msgs__msg__WholeBodyState * data = NULL;
  if (size) {
    data = (halodi_msgs__msg__WholeBodyState *)calloc(size, sizeof(halodi_msgs__msg__WholeBodyState));
    if (!data) {
      return false;
    }
    // initialize all array elements
    size_t i;
    for (i = 0; i < size; ++i) {
      bool success = halodi_msgs__msg__WholeBodyState__init(&data[i]);
      if (!success) {
        break;
      }
    }
    if (i < size) {
      // if initialization failed finalize the already initialized array elements
      for (; i > 0; --i) {
        halodi_msgs__msg__WholeBodyState__fini(&data[i - 1]);
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
halodi_msgs__msg__WholeBodyState__Sequence__fini(halodi_msgs__msg__WholeBodyState__Sequence * array)
{
  if (!array) {
    return;
  }
  if (array->data) {
    // ensure that data and capacity values are consistent
    assert(array->capacity > 0);
    // finalize all array elements
    for (size_t i = 0; i < array->capacity; ++i) {
      halodi_msgs__msg__WholeBodyState__fini(&array->data[i]);
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

halodi_msgs__msg__WholeBodyState__Sequence *
halodi_msgs__msg__WholeBodyState__Sequence__create(size_t size)
{
  halodi_msgs__msg__WholeBodyState__Sequence * array = (halodi_msgs__msg__WholeBodyState__Sequence *)malloc(sizeof(halodi_msgs__msg__WholeBodyState__Sequence));
  if (!array) {
    return NULL;
  }
  bool success = halodi_msgs__msg__WholeBodyState__Sequence__init(array, size);
  if (!success) {
    free(array);
    return NULL;
  }
  return array;
}

void
halodi_msgs__msg__WholeBodyState__Sequence__destroy(halodi_msgs__msg__WholeBodyState__Sequence * array)
{
  if (array) {
    halodi_msgs__msg__WholeBodyState__Sequence__fini(array);
  }
  free(array);
}
