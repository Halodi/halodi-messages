// generated from rosidl_typesupport_introspection_c/resource/idl__type_support.c.em
// with input from halodi_msgs:msg/JointStatus.idl
// generated code does not contain a copyright notice

#include <stddef.h>
#include "halodi_msgs/msg/joint_status__rosidl_typesupport_introspection_c.h"
#include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
#include "rosidl_typesupport_introspection_c/field_types.h"
#include "rosidl_typesupport_introspection_c/identifier.h"
#include "rosidl_typesupport_introspection_c/message_introspection.h"
#include "halodi_msgs/msg/joint_status__functions.h"
#include "halodi_msgs/msg/joint_status__struct.h"


// Include directives for member types
// Member `joint`
#include "halodi_msgs/msg/joint_name.h"
// Member `joint`
#include "halodi_msgs/msg/joint_name__rosidl_typesupport_introspection_c.h"

#ifdef __cplusplus
extern "C"
{
#endif

void JointStatus__rosidl_typesupport_introspection_c__JointStatus_init_function(
  void * message_memory, enum rosidl_runtime_c_message_initialization _init)
{
  // TODO(karsten1987): initializers are not yet implemented for typesupport c
  // see https://github.com/ros2/ros2/issues/397
  (void) _init;
  halodi_msgs__msg__JointStatus__init(message_memory);
}

void JointStatus__rosidl_typesupport_introspection_c__JointStatus_fini_function(void * message_memory)
{
  halodi_msgs__msg__JointStatus__fini(message_memory);
}

static rosidl_typesupport_introspection_c__MessageMember JointStatus__rosidl_typesupport_introspection_c__JointStatus_message_member_array[5] = {
  {
    "joint",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__JointStatus, joint),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "status_level",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_OCTET,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__JointStatus, status_level),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "critical_for_balance",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__JointStatus, critical_for_balance),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "output_encoder_fault",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__JointStatus, output_encoder_fault),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "tension_ropes",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__JointStatus, tension_ropes),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  }
};

static const rosidl_typesupport_introspection_c__MessageMembers JointStatus__rosidl_typesupport_introspection_c__JointStatus_message_members = {
  "halodi_msgs__msg",  // message namespace
  "JointStatus",  // message name
  5,  // number of fields
  sizeof(halodi_msgs__msg__JointStatus),
  JointStatus__rosidl_typesupport_introspection_c__JointStatus_message_member_array,  // message members
  JointStatus__rosidl_typesupport_introspection_c__JointStatus_init_function,  // function to initialize message memory (memory has to be allocated)
  JointStatus__rosidl_typesupport_introspection_c__JointStatus_fini_function  // function to terminate message instance (will not free memory)
};

// this is not const since it must be initialized on first access
// since C does not allow non-integral compile-time constants
static rosidl_message_type_support_t JointStatus__rosidl_typesupport_introspection_c__JointStatus_message_type_support_handle = {
  0,
  &JointStatus__rosidl_typesupport_introspection_c__JointStatus_message_members,
  get_message_typesupport_handle_function,
};

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, JointStatus)() {
  JointStatus__rosidl_typesupport_introspection_c__JointStatus_message_member_array[0].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, JointName)();
  if (!JointStatus__rosidl_typesupport_introspection_c__JointStatus_message_type_support_handle.typesupport_identifier) {
    JointStatus__rosidl_typesupport_introspection_c__JointStatus_message_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  return &JointStatus__rosidl_typesupport_introspection_c__JointStatus_message_type_support_handle;
}
#ifdef __cplusplus
}
#endif
