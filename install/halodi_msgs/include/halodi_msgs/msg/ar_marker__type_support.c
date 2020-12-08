// generated from rosidl_typesupport_introspection_c/resource/idl__type_support.c.em
// with input from halodi_msgs:msg/ARMarker.idl
// generated code does not contain a copyright notice

#include <stddef.h>
#include "halodi_msgs/msg/ar_marker__rosidl_typesupport_introspection_c.h"
#include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
#include "rosidl_typesupport_introspection_c/field_types.h"
#include "rosidl_typesupport_introspection_c/identifier.h"
#include "rosidl_typesupport_introspection_c/message_introspection.h"
#include "halodi_msgs/msg/ar_marker__functions.h"
#include "halodi_msgs/msg/ar_marker__struct.h"


// Include directives for member types
// Member `data`
#include "rosidl_generator_c/string_functions.h"
// Member `points`
#include "geometry_msgs/msg/point.h"
// Member `points`
#include "geometry_msgs/msg/point__rosidl_typesupport_introspection_c.h"
// Member `pose`
#include "geometry_msgs/msg/pose_stamped.h"
// Member `pose`
#include "geometry_msgs/msg/pose_stamped__rosidl_typesupport_introspection_c.h"

#ifdef __cplusplus
extern "C"
{
#endif

void ARMarker__rosidl_typesupport_introspection_c__ARMarker_init_function(
  void * message_memory, enum rosidl_runtime_c_message_initialization _init)
{
  // TODO(karsten1987): initializers are not yet implemented for typesupport c
  // see https://github.com/ros2/ros2/issues/397
  (void) _init;
  halodi_msgs__msg__ARMarker__init(message_memory);
}

void ARMarker__rosidl_typesupport_introspection_c__ARMarker_fini_function(void * message_memory)
{
  halodi_msgs__msg__ARMarker__fini(message_memory);
}

size_t ARMarker__rosidl_typesupport_introspection_c__size_function__Point__points(
  const void * untyped_member)
{
  const geometry_msgs__msg__Point__Sequence * member =
    (const geometry_msgs__msg__Point__Sequence *)(untyped_member);
  return member->size;
}

const void * ARMarker__rosidl_typesupport_introspection_c__get_const_function__Point__points(
  const void * untyped_member, size_t index)
{
  const geometry_msgs__msg__Point__Sequence * member =
    (const geometry_msgs__msg__Point__Sequence *)(untyped_member);
  return &member->data[index];
}

void * ARMarker__rosidl_typesupport_introspection_c__get_function__Point__points(
  void * untyped_member, size_t index)
{
  geometry_msgs__msg__Point__Sequence * member =
    (geometry_msgs__msg__Point__Sequence *)(untyped_member);
  return &member->data[index];
}

bool ARMarker__rosidl_typesupport_introspection_c__resize_function__Point__points(
  void * untyped_member, size_t size)
{
  geometry_msgs__msg__Point__Sequence * member =
    (geometry_msgs__msg__Point__Sequence *)(untyped_member);
  geometry_msgs__msg__Point__Sequence__fini(member);
  return geometry_msgs__msg__Point__Sequence__init(member, size);
}

static rosidl_typesupport_introspection_c__MessageMember ARMarker__rosidl_typesupport_introspection_c__ARMarker_message_member_array[3] = {
  {
    "data",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_STRING,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__ARMarker, data),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "points",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    4,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__ARMarker, points),  // bytes offset in struct
    NULL,  // default value
    ARMarker__rosidl_typesupport_introspection_c__size_function__Point__points,  // size() function pointer
    ARMarker__rosidl_typesupport_introspection_c__get_const_function__Point__points,  // get_const(index) function pointer
    ARMarker__rosidl_typesupport_introspection_c__get_function__Point__points,  // get(index) function pointer
    ARMarker__rosidl_typesupport_introspection_c__resize_function__Point__points  // resize(index) function pointer
  },
  {
    "pose",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__ARMarker, pose),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  }
};

static const rosidl_typesupport_introspection_c__MessageMembers ARMarker__rosidl_typesupport_introspection_c__ARMarker_message_members = {
  "halodi_msgs__msg",  // message namespace
  "ARMarker",  // message name
  3,  // number of fields
  sizeof(halodi_msgs__msg__ARMarker),
  ARMarker__rosidl_typesupport_introspection_c__ARMarker_message_member_array,  // message members
  ARMarker__rosidl_typesupport_introspection_c__ARMarker_init_function,  // function to initialize message memory (memory has to be allocated)
  ARMarker__rosidl_typesupport_introspection_c__ARMarker_fini_function  // function to terminate message instance (will not free memory)
};

// this is not const since it must be initialized on first access
// since C does not allow non-integral compile-time constants
static rosidl_message_type_support_t ARMarker__rosidl_typesupport_introspection_c__ARMarker_message_type_support_handle = {
  0,
  &ARMarker__rosidl_typesupport_introspection_c__ARMarker_message_members,
  get_message_typesupport_handle_function,
};

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, ARMarker)() {
  ARMarker__rosidl_typesupport_introspection_c__ARMarker_message_member_array[1].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, Point)();
  ARMarker__rosidl_typesupport_introspection_c__ARMarker_message_member_array[2].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, PoseStamped)();
  if (!ARMarker__rosidl_typesupport_introspection_c__ARMarker_message_type_support_handle.typesupport_identifier) {
    ARMarker__rosidl_typesupport_introspection_c__ARMarker_message_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  return &ARMarker__rosidl_typesupport_introspection_c__ARMarker_message_type_support_handle;
}
#ifdef __cplusplus
}
#endif
