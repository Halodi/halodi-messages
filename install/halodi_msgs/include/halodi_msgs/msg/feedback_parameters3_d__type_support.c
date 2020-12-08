// generated from rosidl_typesupport_introspection_c/resource/idl__type_support.c.em
// with input from halodi_msgs:msg/FeedbackParameters3D.idl
// generated code does not contain a copyright notice

#include <stddef.h>
#include "halodi_msgs/msg/feedback_parameters3_d__rosidl_typesupport_introspection_c.h"
#include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
#include "rosidl_typesupport_introspection_c/field_types.h"
#include "rosidl_typesupport_introspection_c/identifier.h"
#include "rosidl_typesupport_introspection_c/message_introspection.h"
#include "halodi_msgs/msg/feedback_parameters3_d__functions.h"
#include "halodi_msgs/msg/feedback_parameters3_d__struct.h"


// Include directives for member types
// Member `proportional`
// Member `integral`
// Member `derivative`
#include "geometry_msgs/msg/vector3.h"
// Member `proportional`
// Member `integral`
// Member `derivative`
#include "geometry_msgs/msg/vector3__rosidl_typesupport_introspection_c.h"
// Member `maximum_proportional_error`
// Member `maximum_integral_windup`
// Member `maximum_derivative_error`
// Member `maximum_feedback`
// Member `maximum_feedback_rate`
// Member `integral_leakage`
#include "rosidl_generator_c/primitives_sequence_functions.h"

#ifdef __cplusplus
extern "C"
{
#endif

void FeedbackParameters3D__rosidl_typesupport_introspection_c__FeedbackParameters3D_init_function(
  void * message_memory, enum rosidl_runtime_c_message_initialization _init)
{
  // TODO(karsten1987): initializers are not yet implemented for typesupport c
  // see https://github.com/ros2/ros2/issues/397
  (void) _init;
  halodi_msgs__msg__FeedbackParameters3D__init(message_memory);
}

void FeedbackParameters3D__rosidl_typesupport_introspection_c__FeedbackParameters3D_fini_function(void * message_memory)
{
  halodi_msgs__msg__FeedbackParameters3D__fini(message_memory);
}

size_t FeedbackParameters3D__rosidl_typesupport_introspection_c__size_function__Vector3__integral(
  const void * untyped_member)
{
  const geometry_msgs__msg__Vector3__Sequence * member =
    (const geometry_msgs__msg__Vector3__Sequence *)(untyped_member);
  return member->size;
}

const void * FeedbackParameters3D__rosidl_typesupport_introspection_c__get_const_function__Vector3__integral(
  const void * untyped_member, size_t index)
{
  const geometry_msgs__msg__Vector3__Sequence * member =
    (const geometry_msgs__msg__Vector3__Sequence *)(untyped_member);
  return &member->data[index];
}

void * FeedbackParameters3D__rosidl_typesupport_introspection_c__get_function__Vector3__integral(
  void * untyped_member, size_t index)
{
  geometry_msgs__msg__Vector3__Sequence * member =
    (geometry_msgs__msg__Vector3__Sequence *)(untyped_member);
  return &member->data[index];
}

bool FeedbackParameters3D__rosidl_typesupport_introspection_c__resize_function__Vector3__integral(
  void * untyped_member, size_t size)
{
  geometry_msgs__msg__Vector3__Sequence * member =
    (geometry_msgs__msg__Vector3__Sequence *)(untyped_member);
  geometry_msgs__msg__Vector3__Sequence__fini(member);
  return geometry_msgs__msg__Vector3__Sequence__init(member, size);
}

static rosidl_typesupport_introspection_c__MessageMember FeedbackParameters3D__rosidl_typesupport_introspection_c__FeedbackParameters3D_message_member_array[9] = {
  {
    "proportional",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__FeedbackParameters3D, proportional),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "integral",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__FeedbackParameters3D, integral),  // bytes offset in struct
    NULL,  // default value
    FeedbackParameters3D__rosidl_typesupport_introspection_c__size_function__Vector3__integral,  // size() function pointer
    FeedbackParameters3D__rosidl_typesupport_introspection_c__get_const_function__Vector3__integral,  // get_const(index) function pointer
    FeedbackParameters3D__rosidl_typesupport_introspection_c__get_function__Vector3__integral,  // get(index) function pointer
    FeedbackParameters3D__rosidl_typesupport_introspection_c__resize_function__Vector3__integral  // resize(index) function pointer
  },
  {
    "derivative",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__FeedbackParameters3D, derivative),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "maximum_proportional_error",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__FeedbackParameters3D, maximum_proportional_error),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "maximum_integral_windup",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__FeedbackParameters3D, maximum_integral_windup),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "maximum_derivative_error",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__FeedbackParameters3D, maximum_derivative_error),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "maximum_feedback",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__FeedbackParameters3D, maximum_feedback),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "maximum_feedback_rate",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__FeedbackParameters3D, maximum_feedback_rate),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "integral_leakage",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__FeedbackParameters3D, integral_leakage),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  }
};

static const rosidl_typesupport_introspection_c__MessageMembers FeedbackParameters3D__rosidl_typesupport_introspection_c__FeedbackParameters3D_message_members = {
  "halodi_msgs__msg",  // message namespace
  "FeedbackParameters3D",  // message name
  9,  // number of fields
  sizeof(halodi_msgs__msg__FeedbackParameters3D),
  FeedbackParameters3D__rosidl_typesupport_introspection_c__FeedbackParameters3D_message_member_array,  // message members
  FeedbackParameters3D__rosidl_typesupport_introspection_c__FeedbackParameters3D_init_function,  // function to initialize message memory (memory has to be allocated)
  FeedbackParameters3D__rosidl_typesupport_introspection_c__FeedbackParameters3D_fini_function  // function to terminate message instance (will not free memory)
};

// this is not const since it must be initialized on first access
// since C does not allow non-integral compile-time constants
static rosidl_message_type_support_t FeedbackParameters3D__rosidl_typesupport_introspection_c__FeedbackParameters3D_message_type_support_handle = {
  0,
  &FeedbackParameters3D__rosidl_typesupport_introspection_c__FeedbackParameters3D_message_members,
  get_message_typesupport_handle_function,
};

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, FeedbackParameters3D)() {
  FeedbackParameters3D__rosidl_typesupport_introspection_c__FeedbackParameters3D_message_member_array[0].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, Vector3)();
  FeedbackParameters3D__rosidl_typesupport_introspection_c__FeedbackParameters3D_message_member_array[1].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, Vector3)();
  FeedbackParameters3D__rosidl_typesupport_introspection_c__FeedbackParameters3D_message_member_array[2].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, Vector3)();
  if (!FeedbackParameters3D__rosidl_typesupport_introspection_c__FeedbackParameters3D_message_type_support_handle.typesupport_identifier) {
    FeedbackParameters3D__rosidl_typesupport_introspection_c__FeedbackParameters3D_message_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  return &FeedbackParameters3D__rosidl_typesupport_introspection_c__FeedbackParameters3D_message_type_support_handle;
}
#ifdef __cplusplus
}
#endif
