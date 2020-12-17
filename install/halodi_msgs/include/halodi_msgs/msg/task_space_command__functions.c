// generated from rosidl_generator_c/resource/idl__functions.c.em
// with input from halodi_msgs:msg/TaskSpaceCommand.idl
// generated code does not contain a copyright notice
#include "halodi_msgs/msg/task_space_command__functions.h"

#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>


// Include directives for member types
// Member `body_frame`
// Member `expressed_in_frame`
#include "halodi_msgs/msg/reference_frame_name__functions.h"
// Member `pose`
#include "geometry_msgs/msg/pose__functions.h"
// Member `angular_velocity`
// Member `linear_velocity`
// Member `angular_acceleration`
// Member `linear_acceleration`
#include "geometry_msgs/msg/vector3__functions.h"
// Member `passivity_input`
#include "halodi_msgs/msg/passivity_data__functions.h"
// Member `orientation_feedback_parameters`
// Member `position_feedback_parameters`
#include "halodi_msgs/msg/feedback_parameters3_d__functions.h"
// Member `nullspace_command`
#include "halodi_msgs/msg/joint_null_space_configuration__functions.h"

bool
halodi_msgs__msg__TaskSpaceCommand__init(halodi_msgs__msg__TaskSpaceCommand * msg)
{
  if (!msg) {
    return false;
  }
  // body_frame
  if (!halodi_msgs__msg__ReferenceFrameName__init(&msg->body_frame)) {
    halodi_msgs__msg__TaskSpaceCommand__fini(msg);
    return false;
  }
  // expressed_in_frame
  if (!halodi_msgs__msg__ReferenceFrameName__init(&msg->expressed_in_frame)) {
    halodi_msgs__msg__TaskSpaceCommand__fini(msg);
    return false;
  }
  // express_in_z_up
  // pose
  if (!geometry_msgs__msg__Pose__init(&msg->pose)) {
    halodi_msgs__msg__TaskSpaceCommand__fini(msg);
    return false;
  }
  // angular_velocity
  if (!geometry_msgs__msg__Vector3__init(&msg->angular_velocity)) {
    halodi_msgs__msg__TaskSpaceCommand__fini(msg);
    return false;
  }
  // linear_velocity
  if (!geometry_msgs__msg__Vector3__init(&msg->linear_velocity)) {
    halodi_msgs__msg__TaskSpaceCommand__fini(msg);
    return false;
  }
  // angular_acceleration
  if (!geometry_msgs__msg__Vector3__init(&msg->angular_acceleration)) {
    halodi_msgs__msg__TaskSpaceCommand__fini(msg);
    return false;
  }
  // linear_acceleration
  if (!geometry_msgs__msg__Vector3__init(&msg->linear_acceleration)) {
    halodi_msgs__msg__TaskSpaceCommand__fini(msg);
    return false;
  }
  // passivity_input
  if (!halodi_msgs__msg__PassivityData__Sequence__init(&msg->passivity_input, 0)) {
    halodi_msgs__msg__TaskSpaceCommand__fini(msg);
    return false;
  }
  // orientation_feedback_parameters
  if (!halodi_msgs__msg__FeedbackParameters3D__Sequence__init(&msg->orientation_feedback_parameters, 0)) {
    halodi_msgs__msg__TaskSpaceCommand__fini(msg);
    return false;
  }
  // position_feedback_parameters
  if (!halodi_msgs__msg__FeedbackParameters3D__Sequence__init(&msg->position_feedback_parameters, 0)) {
    halodi_msgs__msg__TaskSpaceCommand__fini(msg);
    return false;
  }
  // nullspace_command
  if (!halodi_msgs__msg__JointNullSpaceConfiguration__Sequence__init(&msg->nullspace_command, 0)) {
    halodi_msgs__msg__TaskSpaceCommand__fini(msg);
    return false;
  }
  return true;
}

void
halodi_msgs__msg__TaskSpaceCommand__fini(halodi_msgs__msg__TaskSpaceCommand * msg)
{
  if (!msg) {
    return;
  }
  // body_frame
  halodi_msgs__msg__ReferenceFrameName__fini(&msg->body_frame);
  // expressed_in_frame
  halodi_msgs__msg__ReferenceFrameName__fini(&msg->expressed_in_frame);
  // express_in_z_up
  // pose
  geometry_msgs__msg__Pose__fini(&msg->pose);
  // angular_velocity
  geometry_msgs__msg__Vector3__fini(&msg->angular_velocity);
  // linear_velocity
  geometry_msgs__msg__Vector3__fini(&msg->linear_velocity);
  // angular_acceleration
  geometry_msgs__msg__Vector3__fini(&msg->angular_acceleration);
  // linear_acceleration
  geometry_msgs__msg__Vector3__fini(&msg->linear_acceleration);
  // passivity_input
  halodi_msgs__msg__PassivityData__Sequence__fini(&msg->passivity_input);
  // orientation_feedback_parameters
  halodi_msgs__msg__FeedbackParameters3D__Sequence__fini(&msg->orientation_feedback_parameters);
  // position_feedback_parameters
  halodi_msgs__msg__FeedbackParameters3D__Sequence__fini(&msg->position_feedback_parameters);
  // nullspace_command
  halodi_msgs__msg__JointNullSpaceConfiguration__Sequence__fini(&msg->nullspace_command);
}

halodi_msgs__msg__TaskSpaceCommand *
halodi_msgs__msg__TaskSpaceCommand__create()
{
  halodi_msgs__msg__TaskSpaceCommand * msg = (halodi_msgs__msg__TaskSpaceCommand *)malloc(sizeof(halodi_msgs__msg__TaskSpaceCommand));
  if (!msg) {
    return NULL;
  }
  memset(msg, 0, sizeof(halodi_msgs__msg__TaskSpaceCommand));
  bool success = halodi_msgs__msg__TaskSpaceCommand__init(msg);
  if (!success) {
    free(msg);
    return NULL;
  }
  return msg;
}

void
halodi_msgs__msg__TaskSpaceCommand__destroy(halodi_msgs__msg__TaskSpaceCommand * msg)
{
  if (msg) {
    halodi_msgs__msg__TaskSpaceCommand__fini(msg);
  }
  free(msg);
}


bool
halodi_msgs__msg__TaskSpaceCommand__Sequence__init(halodi_msgs__msg__TaskSpaceCommand__Sequence * array, size_t size)
{
  if (!array) {
    return false;
  }
  halodi_msgs__msg__TaskSpaceCommand * data = NULL;
  if (size) {
    data = (halodi_msgs__msg__TaskSpaceCommand *)calloc(size, sizeof(halodi_msgs__msg__TaskSpaceCommand));
    if (!data) {
      return false;
    }
    // initialize all array elements
    size_t i;
    for (i = 0; i < size; ++i) {
      bool success = halodi_msgs__msg__TaskSpaceCommand__init(&data[i]);
      if (!success) {
        break;
      }
    }
    if (i < size) {
      // if initialization failed finalize the already initialized array elements
      for (; i > 0; --i) {
        halodi_msgs__msg__TaskSpaceCommand__fini(&data[i - 1]);
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
halodi_msgs__msg__TaskSpaceCommand__Sequence__fini(halodi_msgs__msg__TaskSpaceCommand__Sequence * array)
{
  if (!array) {
    return;
  }
  if (array->data) {
    // ensure that data and capacity values are consistent
    assert(array->capacity > 0);
    // finalize all array elements
    for (size_t i = 0; i < array->capacity; ++i) {
      halodi_msgs__msg__TaskSpaceCommand__fini(&array->data[i]);
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

halodi_msgs__msg__TaskSpaceCommand__Sequence *
halodi_msgs__msg__TaskSpaceCommand__Sequence__create(size_t size)
{
  halodi_msgs__msg__TaskSpaceCommand__Sequence * array = (halodi_msgs__msg__TaskSpaceCommand__Sequence *)malloc(sizeof(halodi_msgs__msg__TaskSpaceCommand__Sequence));
  if (!array) {
    return NULL;
  }
  bool success = halodi_msgs__msg__TaskSpaceCommand__Sequence__init(array, size);
  if (!success) {
    free(array);
    return NULL;
  }
  return array;
}

void
halodi_msgs__msg__TaskSpaceCommand__Sequence__destroy(halodi_msgs__msg__TaskSpaceCommand__Sequence * array)
{
  if (array) {
    halodi_msgs__msg__TaskSpaceCommand__Sequence__fini(array);
  }
  free(array);
}
