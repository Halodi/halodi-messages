// generated from rosidl_generator_c/resource/idl__functions.c.em
// with input from halodi_msgs:msg/WholeBodyControllerCommand.idl
// generated code does not contain a copyright notice
#include "halodi_msgs/msg/whole_body_controller_command__functions.h"

#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>


// Include directives for member types
// Member `balance_mode`
#include "halodi_msgs/msg/balance_mode__functions.h"
// Member `task_space_commands`
#include "halodi_msgs/msg/task_space_command__functions.h"
// Member `joint_space_commands`
#include "halodi_msgs/msg/joint_space_command__functions.h"
// Member `contact_point_commands`
#include "halodi_msgs/msg/contact_point_command__functions.h"
// Member `driving_command`
#include "halodi_msgs/msg/driving_command__functions.h"
// Member `icp_command`
#include "geometry_msgs/msg/vector3__functions.h"

bool
halodi_msgs__msg__WholeBodyControllerCommand__init(halodi_msgs__msg__WholeBodyControllerCommand * msg)
{
  if (!msg) {
    return false;
  }
  // sequence_id
  // balance_mode
  if (!halodi_msgs__msg__BalanceMode__init(&msg->balance_mode)) {
    halodi_msgs__msg__WholeBodyControllerCommand__fini(msg);
    return false;
  }
  // task_space_commands
  if (!halodi_msgs__msg__TaskSpaceCommand__Sequence__init(&msg->task_space_commands, 0)) {
    halodi_msgs__msg__WholeBodyControllerCommand__fini(msg);
    return false;
  }
  // joint_space_commands
  if (!halodi_msgs__msg__JointSpaceCommand__Sequence__init(&msg->joint_space_commands, 0)) {
    halodi_msgs__msg__WholeBodyControllerCommand__fini(msg);
    return false;
  }
  // contact_point_commands
  if (!halodi_msgs__msg__ContactPointCommand__Sequence__init(&msg->contact_point_commands, 0)) {
    halodi_msgs__msg__WholeBodyControllerCommand__fini(msg);
    return false;
  }
  // driving_command
  if (!halodi_msgs__msg__DrivingCommand__Sequence__init(&msg->driving_command, 0)) {
    halodi_msgs__msg__WholeBodyControllerCommand__fini(msg);
    return false;
  }
  // icp_command
  if (!geometry_msgs__msg__Vector3__Sequence__init(&msg->icp_command, 0)) {
    halodi_msgs__msg__WholeBodyControllerCommand__fini(msg);
    return false;
  }
  return true;
}

void
halodi_msgs__msg__WholeBodyControllerCommand__fini(halodi_msgs__msg__WholeBodyControllerCommand * msg)
{
  if (!msg) {
    return;
  }
  // sequence_id
  // balance_mode
  halodi_msgs__msg__BalanceMode__fini(&msg->balance_mode);
  // task_space_commands
  halodi_msgs__msg__TaskSpaceCommand__Sequence__fini(&msg->task_space_commands);
  // joint_space_commands
  halodi_msgs__msg__JointSpaceCommand__Sequence__fini(&msg->joint_space_commands);
  // contact_point_commands
  halodi_msgs__msg__ContactPointCommand__Sequence__fini(&msg->contact_point_commands);
  // driving_command
  halodi_msgs__msg__DrivingCommand__Sequence__fini(&msg->driving_command);
  // icp_command
  geometry_msgs__msg__Vector3__Sequence__fini(&msg->icp_command);
}

halodi_msgs__msg__WholeBodyControllerCommand *
halodi_msgs__msg__WholeBodyControllerCommand__create()
{
  halodi_msgs__msg__WholeBodyControllerCommand * msg = (halodi_msgs__msg__WholeBodyControllerCommand *)malloc(sizeof(halodi_msgs__msg__WholeBodyControllerCommand));
  if (!msg) {
    return NULL;
  }
  memset(msg, 0, sizeof(halodi_msgs__msg__WholeBodyControllerCommand));
  bool success = halodi_msgs__msg__WholeBodyControllerCommand__init(msg);
  if (!success) {
    free(msg);
    return NULL;
  }
  return msg;
}

void
halodi_msgs__msg__WholeBodyControllerCommand__destroy(halodi_msgs__msg__WholeBodyControllerCommand * msg)
{
  if (msg) {
    halodi_msgs__msg__WholeBodyControllerCommand__fini(msg);
  }
  free(msg);
}


bool
halodi_msgs__msg__WholeBodyControllerCommand__Sequence__init(halodi_msgs__msg__WholeBodyControllerCommand__Sequence * array, size_t size)
{
  if (!array) {
    return false;
  }
  halodi_msgs__msg__WholeBodyControllerCommand * data = NULL;
  if (size) {
    data = (halodi_msgs__msg__WholeBodyControllerCommand *)calloc(size, sizeof(halodi_msgs__msg__WholeBodyControllerCommand));
    if (!data) {
      return false;
    }
    // initialize all array elements
    size_t i;
    for (i = 0; i < size; ++i) {
      bool success = halodi_msgs__msg__WholeBodyControllerCommand__init(&data[i]);
      if (!success) {
        break;
      }
    }
    if (i < size) {
      // if initialization failed finalize the already initialized array elements
      for (; i > 0; --i) {
        halodi_msgs__msg__WholeBodyControllerCommand__fini(&data[i - 1]);
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
halodi_msgs__msg__WholeBodyControllerCommand__Sequence__fini(halodi_msgs__msg__WholeBodyControllerCommand__Sequence * array)
{
  if (!array) {
    return;
  }
  if (array->data) {
    // ensure that data and capacity values are consistent
    assert(array->capacity > 0);
    // finalize all array elements
    for (size_t i = 0; i < array->capacity; ++i) {
      halodi_msgs__msg__WholeBodyControllerCommand__fini(&array->data[i]);
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

halodi_msgs__msg__WholeBodyControllerCommand__Sequence *
halodi_msgs__msg__WholeBodyControllerCommand__Sequence__create(size_t size)
{
  halodi_msgs__msg__WholeBodyControllerCommand__Sequence * array = (halodi_msgs__msg__WholeBodyControllerCommand__Sequence *)malloc(sizeof(halodi_msgs__msg__WholeBodyControllerCommand__Sequence));
  if (!array) {
    return NULL;
  }
  bool success = halodi_msgs__msg__WholeBodyControllerCommand__Sequence__init(array, size);
  if (!success) {
    free(array);
    return NULL;
  }
  return array;
}

void
halodi_msgs__msg__WholeBodyControllerCommand__Sequence__destroy(halodi_msgs__msg__WholeBodyControllerCommand__Sequence * array)
{
  if (array) {
    halodi_msgs__msg__WholeBodyControllerCommand__Sequence__fini(array);
  }
  free(array);
}
