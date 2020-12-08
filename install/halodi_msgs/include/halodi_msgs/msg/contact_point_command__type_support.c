// generated from rosidl_typesupport_introspection_c/resource/idl__type_support.c.em
// with input from halodi_msgs:msg/ContactPointCommand.idl
// generated code does not contain a copyright notice

#include <stddef.h>
#include "halodi_msgs/msg/contact_point_command__rosidl_typesupport_introspection_c.h"
#include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
#include "rosidl_typesupport_introspection_c/field_types.h"
#include "rosidl_typesupport_introspection_c/identifier.h"
#include "rosidl_typesupport_introspection_c/message_introspection.h"
#include "halodi_msgs/msg/contact_point_command__functions.h"
#include "halodi_msgs/msg/contact_point_command__struct.h"


// Include directives for member types
// Member `parent_joint`
#include "halodi_msgs/msg/joint_name.h"
// Member `parent_joint`
#include "halodi_msgs/msg/joint_name__rosidl_typesupport_introspection_c.h"
// Member `normal`
#include "geometry_msgs/msg/vector3.h"
// Member `normal`
#include "geometry_msgs/msg/vector3__rosidl_typesupport_introspection_c.h"
// Member `coefficient_of_friction`
// Member `maximum_contact_force`
// Member `rho_weight_divider`
#include "rosidl_generator_c/primitives_sequence_functions.h"

#ifdef __cplusplus
extern "C"
{
#endif

void ContactPointCommand__rosidl_typesupport_introspection_c__ContactPointCommand_init_function(
  void * message_memory, enum rosidl_runtime_c_message_initialization _init)
{
  // TODO(karsten1987): initializers are not yet implemented for typesupport c
  // see https://github.com/ros2/ros2/issues/397
  (void) _init;
  halodi_msgs__msg__ContactPointCommand__init(message_memory);
}

void ContactPointCommand__rosidl_typesupport_introspection_c__ContactPointCommand_fini_function(void * message_memory)
{
  halodi_msgs__msg__ContactPointCommand__fini(message_memory);
}

size_t ContactPointCommand__rosidl_typesupport_introspection_c__size_function__Vector3__normal(
  const void * untyped_member)
{
  const geometry_msgs__msg__Vector3__Sequence * member =
    (const geometry_msgs__msg__Vector3__Sequence *)(untyped_member);
  return member->size;
}

const void * ContactPointCommand__rosidl_typesupport_introspection_c__get_const_function__Vector3__normal(
  const void * untyped_member, size_t index)
{
  const geometry_msgs__msg__Vector3__Sequence * member =
    (const geometry_msgs__msg__Vector3__Sequence *)(untyped_member);
  return &member->data[index];
}

void * ContactPointCommand__rosidl_typesupport_introspection_c__get_function__Vector3__normal(
  void * untyped_member, size_t index)
{
  geometry_msgs__msg__Vector3__Sequence * member =
    (geometry_msgs__msg__Vector3__Sequence *)(untyped_member);
  return &member->data[index];
}

bool ContactPointCommand__rosidl_typesupport_introspection_c__resize_function__Vector3__normal(
  void * untyped_member, size_t size)
{
  geometry_msgs__msg__Vector3__Sequence * member =
    (geometry_msgs__msg__Vector3__Sequence *)(untyped_member);
  geometry_msgs__msg__Vector3__Sequence__fini(member);
  return geometry_msgs__msg__Vector3__Sequence__init(member, size);
}

static rosidl_typesupport_introspection_c__MessageMember ContactPointCommand__rosidl_typesupport_introspection_c__ContactPointCommand_message_member_array[7] = {
  {
    "parent_joint",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__ContactPointCommand, parent_joint),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "contact_point_id",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_INT32,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__ContactPointCommand, contact_point_id),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "point_in_contact",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__ContactPointCommand, point_in_contact),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "normal",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__ContactPointCommand, normal),  // bytes offset in struct
    NULL,  // default value
    ContactPointCommand__rosidl_typesupport_introspection_c__size_function__Vector3__normal,  // size() function pointer
    ContactPointCommand__rosidl_typesupport_introspection_c__get_const_function__Vector3__normal,  // get_const(index) function pointer
    ContactPointCommand__rosidl_typesupport_introspection_c__get_function__Vector3__normal,  // get(index) function pointer
    ContactPointCommand__rosidl_typesupport_introspection_c__resize_function__Vector3__normal  // resize(index) function pointer
  },
  {
    "coefficient_of_friction",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__ContactPointCommand, coefficient_of_friction),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "maximum_contact_force",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__ContactPointCommand, maximum_contact_force),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "rho_weight_divider",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__ContactPointCommand, rho_weight_divider),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  }
};

static const rosidl_typesupport_introspection_c__MessageMembers ContactPointCommand__rosidl_typesupport_introspection_c__ContactPointCommand_message_members = {
  "halodi_msgs__msg",  // message namespace
  "ContactPointCommand",  // message name
  7,  // number of fields
  sizeof(halodi_msgs__msg__ContactPointCommand),
  ContactPointCommand__rosidl_typesupport_introspection_c__ContactPointCommand_message_member_array,  // message members
  ContactPointCommand__rosidl_typesupport_introspection_c__ContactPointCommand_init_function,  // function to initialize message memory (memory has to be allocated)
  ContactPointCommand__rosidl_typesupport_introspection_c__ContactPointCommand_fini_function  // function to terminate message instance (will not free memory)
};

// this is not const since it must be initialized on first access
// since C does not allow non-integral compile-time constants
static rosidl_message_type_support_t ContactPointCommand__rosidl_typesupport_introspection_c__ContactPointCommand_message_type_support_handle = {
  0,
  &ContactPointCommand__rosidl_typesupport_introspection_c__ContactPointCommand_message_members,
  get_message_typesupport_handle_function,
};

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, ContactPointCommand)() {
  ContactPointCommand__rosidl_typesupport_introspection_c__ContactPointCommand_message_member_array[0].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, JointName)();
  ContactPointCommand__rosidl_typesupport_introspection_c__ContactPointCommand_message_member_array[3].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, Vector3)();
  if (!ContactPointCommand__rosidl_typesupport_introspection_c__ContactPointCommand_message_type_support_handle.typesupport_identifier) {
    ContactPointCommand__rosidl_typesupport_introspection_c__ContactPointCommand_message_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  return &ContactPointCommand__rosidl_typesupport_introspection_c__ContactPointCommand_message_type_support_handle;
}
#ifdef __cplusplus
}
#endif
