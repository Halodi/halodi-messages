// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/ContactPointCommand.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__CONTACT_POINT_COMMAND__STRUCT_H_
#define HALODI_MSGS__MSG__CONTACT_POINT_COMMAND__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

// Include directives for member types
// Member 'parent_joint'
#include "halodi_msgs/msg/joint_name__struct.h"
// Member 'normal'
#include "geometry_msgs/msg/vector3__struct.h"
// Member 'coefficient_of_friction'
// Member 'maximum_contact_force'
// Member 'rho_weight_divider'
#include "rosidl_generator_c/primitives_sequence.h"

// constants for array fields with an upper bound
// normal
enum
{
  halodi_msgs__msg__ContactPointCommand__normal__MAX_SIZE = 1
};
// coefficient_of_friction
enum
{
  halodi_msgs__msg__ContactPointCommand__coefficient_of_friction__MAX_SIZE = 1
};
// maximum_contact_force
enum
{
  halodi_msgs__msg__ContactPointCommand__maximum_contact_force__MAX_SIZE = 1
};
// rho_weight_divider
enum
{
  halodi_msgs__msg__ContactPointCommand__rho_weight_divider__MAX_SIZE = 1
};

// Struct defined in msg/ContactPointCommand in the package halodi_msgs.
typedef struct halodi_msgs__msg__ContactPointCommand
{
  halodi_msgs__msg__JointName parent_joint;
  int32_t contact_point_id;
  bool point_in_contact;
  geometry_msgs__msg__Vector3__Sequence normal;
  rosidl_generator_c__double__Sequence coefficient_of_friction;
  rosidl_generator_c__double__Sequence maximum_contact_force;
  rosidl_generator_c__double__Sequence rho_weight_divider;
} halodi_msgs__msg__ContactPointCommand;

// Struct for a sequence of halodi_msgs__msg__ContactPointCommand.
typedef struct halodi_msgs__msg__ContactPointCommand__Sequence
{
  halodi_msgs__msg__ContactPointCommand * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__ContactPointCommand__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__CONTACT_POINT_COMMAND__STRUCT_H_
