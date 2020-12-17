// generated from rosidl_typesupport_introspection_c/resource/idl__type_support.c.em
// with input from halodi_msgs:msg/PassivityData.idl
// generated code does not contain a copyright notice

#include <stddef.h>
#include "halodi_msgs/msg/passivity_data__rosidl_typesupport_introspection_c.h"
#include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
#include "rosidl_typesupport_introspection_c/field_types.h"
#include "rosidl_typesupport_introspection_c/identifier.h"
#include "rosidl_typesupport_introspection_c/message_introspection.h"
#include "halodi_msgs/msg/passivity_data__functions.h"
#include "halodi_msgs/msg/passivity_data__struct.h"


#ifdef __cplusplus
extern "C"
{
#endif

void PassivityData__rosidl_typesupport_introspection_c__PassivityData_init_function(
  void * message_memory, enum rosidl_runtime_c_message_initialization _init)
{
  // TODO(karsten1987): initializers are not yet implemented for typesupport c
  // see https://github.com/ros2/ros2/issues/397
  (void) _init;
  halodi_msgs__msg__PassivityData__init(message_memory);
}

void PassivityData__rosidl_typesupport_introspection_c__PassivityData_fini_function(void * message_memory)
{
  halodi_msgs__msg__PassivityData__fini(message_memory);
}

static rosidl_typesupport_introspection_c__MessageMember PassivityData__rosidl_typesupport_introspection_c__PassivityData_message_member_array[3] = {
  {
    "energy_packet",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__PassivityData, energy_packet),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "energy_tank_level",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__PassivityData, energy_tank_level),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "virtual_mass",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__PassivityData, virtual_mass),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  }
};

static const rosidl_typesupport_introspection_c__MessageMembers PassivityData__rosidl_typesupport_introspection_c__PassivityData_message_members = {
  "halodi_msgs__msg",  // message namespace
  "PassivityData",  // message name
  3,  // number of fields
  sizeof(halodi_msgs__msg__PassivityData),
  PassivityData__rosidl_typesupport_introspection_c__PassivityData_message_member_array,  // message members
  PassivityData__rosidl_typesupport_introspection_c__PassivityData_init_function,  // function to initialize message memory (memory has to be allocated)
  PassivityData__rosidl_typesupport_introspection_c__PassivityData_fini_function  // function to terminate message instance (will not free memory)
};

// this is not const since it must be initialized on first access
// since C does not allow non-integral compile-time constants
static rosidl_message_type_support_t PassivityData__rosidl_typesupport_introspection_c__PassivityData_message_type_support_handle = {
  0,
  &PassivityData__rosidl_typesupport_introspection_c__PassivityData_message_members,
  get_message_typesupport_handle_function,
};

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, PassivityData)() {
  if (!PassivityData__rosidl_typesupport_introspection_c__PassivityData_message_type_support_handle.typesupport_identifier) {
    PassivityData__rosidl_typesupport_introspection_c__PassivityData_message_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  return &PassivityData__rosidl_typesupport_introspection_c__PassivityData_message_type_support_handle;
}
#ifdef __cplusplus
}
#endif
