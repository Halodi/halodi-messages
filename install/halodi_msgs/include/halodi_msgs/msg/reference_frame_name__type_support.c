// generated from rosidl_typesupport_introspection_c/resource/idl__type_support.c.em
// with input from halodi_msgs:msg/ReferenceFrameName.idl
// generated code does not contain a copyright notice

#include <stddef.h>
#include "halodi_msgs/msg/reference_frame_name__rosidl_typesupport_introspection_c.h"
#include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
#include "rosidl_typesupport_introspection_c/field_types.h"
#include "rosidl_typesupport_introspection_c/identifier.h"
#include "rosidl_typesupport_introspection_c/message_introspection.h"
#include "halodi_msgs/msg/reference_frame_name__functions.h"
#include "halodi_msgs/msg/reference_frame_name__struct.h"


#ifdef __cplusplus
extern "C"
{
#endif

void ReferenceFrameName__rosidl_typesupport_introspection_c__ReferenceFrameName_init_function(
  void * message_memory, enum rosidl_runtime_c_message_initialization _init)
{
  // TODO(karsten1987): initializers are not yet implemented for typesupport c
  // see https://github.com/ros2/ros2/issues/397
  (void) _init;
  halodi_msgs__msg__ReferenceFrameName__init(message_memory);
}

void ReferenceFrameName__rosidl_typesupport_introspection_c__ReferenceFrameName_fini_function(void * message_memory)
{
  halodi_msgs__msg__ReferenceFrameName__fini(message_memory);
}

static rosidl_typesupport_introspection_c__MessageMember ReferenceFrameName__rosidl_typesupport_introspection_c__ReferenceFrameName_message_member_array[1] = {
  {
    "frame_id",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_INT32,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__ReferenceFrameName, frame_id),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  }
};

static const rosidl_typesupport_introspection_c__MessageMembers ReferenceFrameName__rosidl_typesupport_introspection_c__ReferenceFrameName_message_members = {
  "halodi_msgs__msg",  // message namespace
  "ReferenceFrameName",  // message name
  1,  // number of fields
  sizeof(halodi_msgs__msg__ReferenceFrameName),
  ReferenceFrameName__rosidl_typesupport_introspection_c__ReferenceFrameName_message_member_array,  // message members
  ReferenceFrameName__rosidl_typesupport_introspection_c__ReferenceFrameName_init_function,  // function to initialize message memory (memory has to be allocated)
  ReferenceFrameName__rosidl_typesupport_introspection_c__ReferenceFrameName_fini_function  // function to terminate message instance (will not free memory)
};

// this is not const since it must be initialized on first access
// since C does not allow non-integral compile-time constants
static rosidl_message_type_support_t ReferenceFrameName__rosidl_typesupport_introspection_c__ReferenceFrameName_message_type_support_handle = {
  0,
  &ReferenceFrameName__rosidl_typesupport_introspection_c__ReferenceFrameName_message_members,
  get_message_typesupport_handle_function,
};

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, ReferenceFrameName)() {
  if (!ReferenceFrameName__rosidl_typesupport_introspection_c__ReferenceFrameName_message_type_support_handle.typesupport_identifier) {
    ReferenceFrameName__rosidl_typesupport_introspection_c__ReferenceFrameName_message_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  return &ReferenceFrameName__rosidl_typesupport_introspection_c__ReferenceFrameName_message_type_support_handle;
}
#ifdef __cplusplus
}
#endif
