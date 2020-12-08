// generated from rosidl_typesupport_introspection_c/resource/idl__type_support.c.em
// with input from halodi_msgs:msg/ARMarkers.idl
// generated code does not contain a copyright notice

#include <stddef.h>
#include "halodi_msgs/msg/ar_markers__rosidl_typesupport_introspection_c.h"
#include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
#include "rosidl_typesupport_introspection_c/field_types.h"
#include "rosidl_typesupport_introspection_c/identifier.h"
#include "rosidl_typesupport_introspection_c/message_introspection.h"
#include "halodi_msgs/msg/ar_markers__functions.h"
#include "halodi_msgs/msg/ar_markers__struct.h"


// Include directives for member types
// Member `header`
#include "std_msgs/msg/header.h"
// Member `header`
#include "std_msgs/msg/header__rosidl_typesupport_introspection_c.h"
// Member `markers`
#include "halodi_msgs/msg/ar_marker.h"
// Member `markers`
#include "halodi_msgs/msg/ar_marker__rosidl_typesupport_introspection_c.h"

#ifdef __cplusplus
extern "C"
{
#endif

void ARMarkers__rosidl_typesupport_introspection_c__ARMarkers_init_function(
  void * message_memory, enum rosidl_runtime_c_message_initialization _init)
{
  // TODO(karsten1987): initializers are not yet implemented for typesupport c
  // see https://github.com/ros2/ros2/issues/397
  (void) _init;
  halodi_msgs__msg__ARMarkers__init(message_memory);
}

void ARMarkers__rosidl_typesupport_introspection_c__ARMarkers_fini_function(void * message_memory)
{
  halodi_msgs__msg__ARMarkers__fini(message_memory);
}

size_t ARMarkers__rosidl_typesupport_introspection_c__size_function__ARMarker__markers(
  const void * untyped_member)
{
  const halodi_msgs__msg__ARMarker__Sequence * member =
    (const halodi_msgs__msg__ARMarker__Sequence *)(untyped_member);
  return member->size;
}

const void * ARMarkers__rosidl_typesupport_introspection_c__get_const_function__ARMarker__markers(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__ARMarker__Sequence * member =
    (const halodi_msgs__msg__ARMarker__Sequence *)(untyped_member);
  return &member->data[index];
}

void * ARMarkers__rosidl_typesupport_introspection_c__get_function__ARMarker__markers(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__ARMarker__Sequence * member =
    (halodi_msgs__msg__ARMarker__Sequence *)(untyped_member);
  return &member->data[index];
}

bool ARMarkers__rosidl_typesupport_introspection_c__resize_function__ARMarker__markers(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__ARMarker__Sequence * member =
    (halodi_msgs__msg__ARMarker__Sequence *)(untyped_member);
  halodi_msgs__msg__ARMarker__Sequence__fini(member);
  return halodi_msgs__msg__ARMarker__Sequence__init(member, size);
}

static rosidl_typesupport_introspection_c__MessageMember ARMarkers__rosidl_typesupport_introspection_c__ARMarkers_message_member_array[2] = {
  {
    "header",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__ARMarkers, header),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "markers",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    255,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__ARMarkers, markers),  // bytes offset in struct
    NULL,  // default value
    ARMarkers__rosidl_typesupport_introspection_c__size_function__ARMarker__markers,  // size() function pointer
    ARMarkers__rosidl_typesupport_introspection_c__get_const_function__ARMarker__markers,  // get_const(index) function pointer
    ARMarkers__rosidl_typesupport_introspection_c__get_function__ARMarker__markers,  // get(index) function pointer
    ARMarkers__rosidl_typesupport_introspection_c__resize_function__ARMarker__markers  // resize(index) function pointer
  }
};

static const rosidl_typesupport_introspection_c__MessageMembers ARMarkers__rosidl_typesupport_introspection_c__ARMarkers_message_members = {
  "halodi_msgs__msg",  // message namespace
  "ARMarkers",  // message name
  2,  // number of fields
  sizeof(halodi_msgs__msg__ARMarkers),
  ARMarkers__rosidl_typesupport_introspection_c__ARMarkers_message_member_array,  // message members
  ARMarkers__rosidl_typesupport_introspection_c__ARMarkers_init_function,  // function to initialize message memory (memory has to be allocated)
  ARMarkers__rosidl_typesupport_introspection_c__ARMarkers_fini_function  // function to terminate message instance (will not free memory)
};

// this is not const since it must be initialized on first access
// since C does not allow non-integral compile-time constants
static rosidl_message_type_support_t ARMarkers__rosidl_typesupport_introspection_c__ARMarkers_message_type_support_handle = {
  0,
  &ARMarkers__rosidl_typesupport_introspection_c__ARMarkers_message_members,
  get_message_typesupport_handle_function,
};

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, ARMarkers)() {
  ARMarkers__rosidl_typesupport_introspection_c__ARMarkers_message_member_array[0].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, std_msgs, msg, Header)();
  ARMarkers__rosidl_typesupport_introspection_c__ARMarkers_message_member_array[1].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, ARMarker)();
  if (!ARMarkers__rosidl_typesupport_introspection_c__ARMarkers_message_type_support_handle.typesupport_identifier) {
    ARMarkers__rosidl_typesupport_introspection_c__ARMarkers_message_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  return &ARMarkers__rosidl_typesupport_introspection_c__ARMarkers_message_type_support_handle;
}
#ifdef __cplusplus
}
#endif
