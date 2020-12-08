// generated from rosidl_typesupport_introspection_c/resource/idl__type_support.c.em
// with input from halodi_msgs:msg/TaskSpaceFeedback.idl
// generated code does not contain a copyright notice

#include <stddef.h>
#include "halodi_msgs/msg/task_space_feedback__rosidl_typesupport_introspection_c.h"
#include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
#include "rosidl_typesupport_introspection_c/field_types.h"
#include "rosidl_typesupport_introspection_c/identifier.h"
#include "rosidl_typesupport_introspection_c/message_introspection.h"
#include "halodi_msgs/msg/task_space_feedback__functions.h"
#include "halodi_msgs/msg/task_space_feedback__struct.h"


// Include directives for member types
// Member `body_frame`
// Member `expressed_in_frame`
#include "halodi_msgs/msg/reference_frame_name.h"
// Member `body_frame`
// Member `expressed_in_frame`
#include "halodi_msgs/msg/reference_frame_name__rosidl_typesupport_introspection_c.h"
// Member `angular_acceleration`
// Member `linear_acceleration`
#include "geometry_msgs/msg/vector3.h"
// Member `angular_acceleration`
// Member `linear_acceleration`
#include "geometry_msgs/msg/vector3__rosidl_typesupport_introspection_c.h"
// Member `passivity_output`
#include "halodi_msgs/msg/passivity_data.h"
// Member `passivity_output`
#include "halodi_msgs/msg/passivity_data__rosidl_typesupport_introspection_c.h"

#ifdef __cplusplus
extern "C"
{
#endif

void TaskSpaceFeedback__rosidl_typesupport_introspection_c__TaskSpaceFeedback_init_function(
  void * message_memory, enum rosidl_runtime_c_message_initialization _init)
{
  // TODO(karsten1987): initializers are not yet implemented for typesupport c
  // see https://github.com/ros2/ros2/issues/397
  (void) _init;
  halodi_msgs__msg__TaskSpaceFeedback__init(message_memory);
}

void TaskSpaceFeedback__rosidl_typesupport_introspection_c__TaskSpaceFeedback_fini_function(void * message_memory)
{
  halodi_msgs__msg__TaskSpaceFeedback__fini(message_memory);
}

size_t TaskSpaceFeedback__rosidl_typesupport_introspection_c__size_function__PassivityData__passivity_output(
  const void * untyped_member)
{
  const halodi_msgs__msg__PassivityData__Sequence * member =
    (const halodi_msgs__msg__PassivityData__Sequence *)(untyped_member);
  return member->size;
}

const void * TaskSpaceFeedback__rosidl_typesupport_introspection_c__get_const_function__PassivityData__passivity_output(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__PassivityData__Sequence * member =
    (const halodi_msgs__msg__PassivityData__Sequence *)(untyped_member);
  return &member->data[index];
}

void * TaskSpaceFeedback__rosidl_typesupport_introspection_c__get_function__PassivityData__passivity_output(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__PassivityData__Sequence * member =
    (halodi_msgs__msg__PassivityData__Sequence *)(untyped_member);
  return &member->data[index];
}

bool TaskSpaceFeedback__rosidl_typesupport_introspection_c__resize_function__PassivityData__passivity_output(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__PassivityData__Sequence * member =
    (halodi_msgs__msg__PassivityData__Sequence *)(untyped_member);
  halodi_msgs__msg__PassivityData__Sequence__fini(member);
  return halodi_msgs__msg__PassivityData__Sequence__init(member, size);
}

static rosidl_typesupport_introspection_c__MessageMember TaskSpaceFeedback__rosidl_typesupport_introspection_c__TaskSpaceFeedback_message_member_array[6] = {
  {
    "body_frame",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__TaskSpaceFeedback, body_frame),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "expressed_in_frame",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__TaskSpaceFeedback, expressed_in_frame),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "express_in_z_up",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__TaskSpaceFeedback, express_in_z_up),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "angular_acceleration",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__TaskSpaceFeedback, angular_acceleration),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "linear_acceleration",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__TaskSpaceFeedback, linear_acceleration),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "passivity_output",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__TaskSpaceFeedback, passivity_output),  // bytes offset in struct
    NULL,  // default value
    TaskSpaceFeedback__rosidl_typesupport_introspection_c__size_function__PassivityData__passivity_output,  // size() function pointer
    TaskSpaceFeedback__rosidl_typesupport_introspection_c__get_const_function__PassivityData__passivity_output,  // get_const(index) function pointer
    TaskSpaceFeedback__rosidl_typesupport_introspection_c__get_function__PassivityData__passivity_output,  // get(index) function pointer
    TaskSpaceFeedback__rosidl_typesupport_introspection_c__resize_function__PassivityData__passivity_output  // resize(index) function pointer
  }
};

static const rosidl_typesupport_introspection_c__MessageMembers TaskSpaceFeedback__rosidl_typesupport_introspection_c__TaskSpaceFeedback_message_members = {
  "halodi_msgs__msg",  // message namespace
  "TaskSpaceFeedback",  // message name
  6,  // number of fields
  sizeof(halodi_msgs__msg__TaskSpaceFeedback),
  TaskSpaceFeedback__rosidl_typesupport_introspection_c__TaskSpaceFeedback_message_member_array,  // message members
  TaskSpaceFeedback__rosidl_typesupport_introspection_c__TaskSpaceFeedback_init_function,  // function to initialize message memory (memory has to be allocated)
  TaskSpaceFeedback__rosidl_typesupport_introspection_c__TaskSpaceFeedback_fini_function  // function to terminate message instance (will not free memory)
};

// this is not const since it must be initialized on first access
// since C does not allow non-integral compile-time constants
static rosidl_message_type_support_t TaskSpaceFeedback__rosidl_typesupport_introspection_c__TaskSpaceFeedback_message_type_support_handle = {
  0,
  &TaskSpaceFeedback__rosidl_typesupport_introspection_c__TaskSpaceFeedback_message_members,
  get_message_typesupport_handle_function,
};

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, TaskSpaceFeedback)() {
  TaskSpaceFeedback__rosidl_typesupport_introspection_c__TaskSpaceFeedback_message_member_array[0].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, ReferenceFrameName)();
  TaskSpaceFeedback__rosidl_typesupport_introspection_c__TaskSpaceFeedback_message_member_array[1].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, ReferenceFrameName)();
  TaskSpaceFeedback__rosidl_typesupport_introspection_c__TaskSpaceFeedback_message_member_array[3].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, Vector3)();
  TaskSpaceFeedback__rosidl_typesupport_introspection_c__TaskSpaceFeedback_message_member_array[4].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, Vector3)();
  TaskSpaceFeedback__rosidl_typesupport_introspection_c__TaskSpaceFeedback_message_member_array[5].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, PassivityData)();
  if (!TaskSpaceFeedback__rosidl_typesupport_introspection_c__TaskSpaceFeedback_message_type_support_handle.typesupport_identifier) {
    TaskSpaceFeedback__rosidl_typesupport_introspection_c__TaskSpaceFeedback_message_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  return &TaskSpaceFeedback__rosidl_typesupport_introspection_c__TaskSpaceFeedback_message_type_support_handle;
}
#ifdef __cplusplus
}
#endif
