// generated from rosidl_generator_c/resource/idl__functions.c.em
// with input from halodi_msgs:msg/ContactPointCommand.idl
// generated code does not contain a copyright notice
#include "halodi_msgs/msg/contact_point_command__functions.h"

#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>


// Include directives for member types
// Member `parent_joint`
#include "halodi_msgs/msg/joint_name__functions.h"
// Member `normal`
#include "geometry_msgs/msg/vector3__functions.h"
// Member `coefficient_of_friction`
// Member `maximum_contact_force`
// Member `rho_weight_divider`
#include "rosidl_generator_c/primitives_sequence_functions.h"

bool
halodi_msgs__msg__ContactPointCommand__init(halodi_msgs__msg__ContactPointCommand * msg)
{
  if (!msg) {
    return false;
  }
  // parent_joint
  if (!halodi_msgs__msg__JointName__init(&msg->parent_joint)) {
    halodi_msgs__msg__ContactPointCommand__fini(msg);
    return false;
  }
  // contact_point_id
  // point_in_contact
  // normal
  if (!geometry_msgs__msg__Vector3__Sequence__init(&msg->normal, 0)) {
    halodi_msgs__msg__ContactPointCommand__fini(msg);
    return false;
  }
  // coefficient_of_friction
  if (!rosidl_generator_c__double__Sequence__init(&msg->coefficient_of_friction, 0)) {
    halodi_msgs__msg__ContactPointCommand__fini(msg);
    return false;
  }
  // maximum_contact_force
  if (!rosidl_generator_c__double__Sequence__init(&msg->maximum_contact_force, 0)) {
    halodi_msgs__msg__ContactPointCommand__fini(msg);
    return false;
  }
  // rho_weight_divider
  if (!rosidl_generator_c__double__Sequence__init(&msg->rho_weight_divider, 0)) {
    halodi_msgs__msg__ContactPointCommand__fini(msg);
    return false;
  }
  return true;
}

void
halodi_msgs__msg__ContactPointCommand__fini(halodi_msgs__msg__ContactPointCommand * msg)
{
  if (!msg) {
    return;
  }
  // parent_joint
  halodi_msgs__msg__JointName__fini(&msg->parent_joint);
  // contact_point_id
  // point_in_contact
  // normal
  geometry_msgs__msg__Vector3__Sequence__fini(&msg->normal);
  // coefficient_of_friction
  rosidl_generator_c__double__Sequence__fini(&msg->coefficient_of_friction);
  // maximum_contact_force
  rosidl_generator_c__double__Sequence__fini(&msg->maximum_contact_force);
  // rho_weight_divider
  rosidl_generator_c__double__Sequence__fini(&msg->rho_weight_divider);
}

halodi_msgs__msg__ContactPointCommand *
halodi_msgs__msg__ContactPointCommand__create()
{
  halodi_msgs__msg__ContactPointCommand * msg = (halodi_msgs__msg__ContactPointCommand *)malloc(sizeof(halodi_msgs__msg__ContactPointCommand));
  if (!msg) {
    return NULL;
  }
  memset(msg, 0, sizeof(halodi_msgs__msg__ContactPointCommand));
  bool success = halodi_msgs__msg__ContactPointCommand__init(msg);
  if (!success) {
    free(msg);
    return NULL;
  }
  return msg;
}

void
halodi_msgs__msg__ContactPointCommand__destroy(halodi_msgs__msg__ContactPointCommand * msg)
{
  if (msg) {
    halodi_msgs__msg__ContactPointCommand__fini(msg);
  }
  free(msg);
}


bool
halodi_msgs__msg__ContactPointCommand__Sequence__init(halodi_msgs__msg__ContactPointCommand__Sequence * array, size_t size)
{
  if (!array) {
    return false;
  }
  halodi_msgs__msg__ContactPointCommand * data = NULL;
  if (size) {
    data = (halodi_msgs__msg__ContactPointCommand *)calloc(size, sizeof(halodi_msgs__msg__ContactPointCommand));
    if (!data) {
      return false;
    }
    // initialize all array elements
    size_t i;
    for (i = 0; i < size; ++i) {
      bool success = halodi_msgs__msg__ContactPointCommand__init(&data[i]);
      if (!success) {
        break;
      }
    }
    if (i < size) {
      // if initialization failed finalize the already initialized array elements
      for (; i > 0; --i) {
        halodi_msgs__msg__ContactPointCommand__fini(&data[i - 1]);
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
halodi_msgs__msg__ContactPointCommand__Sequence__fini(halodi_msgs__msg__ContactPointCommand__Sequence * array)
{
  if (!array) {
    return;
  }
  if (array->data) {
    // ensure that data and capacity values are consistent
    assert(array->capacity > 0);
    // finalize all array elements
    for (size_t i = 0; i < array->capacity; ++i) {
      halodi_msgs__msg__ContactPointCommand__fini(&array->data[i]);
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

halodi_msgs__msg__ContactPointCommand__Sequence *
halodi_msgs__msg__ContactPointCommand__Sequence__create(size_t size)
{
  halodi_msgs__msg__ContactPointCommand__Sequence * array = (halodi_msgs__msg__ContactPointCommand__Sequence *)malloc(sizeof(halodi_msgs__msg__ContactPointCommand__Sequence));
  if (!array) {
    return NULL;
  }
  bool success = halodi_msgs__msg__ContactPointCommand__Sequence__init(array, size);
  if (!success) {
    free(array);
    return NULL;
  }
  return array;
}

void
halodi_msgs__msg__ContactPointCommand__Sequence__destroy(halodi_msgs__msg__ContactPointCommand__Sequence * array)
{
  if (array) {
    halodi_msgs__msg__ContactPointCommand__Sequence__fini(array);
  }
  free(array);
}
