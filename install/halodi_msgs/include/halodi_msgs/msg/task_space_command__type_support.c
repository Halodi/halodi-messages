// generated from rosidl_typesupport_introspection_c/resource/idl__type_support.c.em
// with input from halodi_msgs:msg/TaskSpaceCommand.idl
// generated code does not contain a copyright notice

#include <stddef.h>
#include "halodi_msgs/msg/task_space_command__rosidl_typesupport_introspection_c.h"
#include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
#include "rosidl_typesupport_introspection_c/field_types.h"
#include "rosidl_typesupport_introspection_c/identifier.h"
#include "rosidl_typesupport_introspection_c/message_introspection.h"
#include "halodi_msgs/msg/task_space_command__functions.h"
#include "halodi_msgs/msg/task_space_command__struct.h"


// Include directives for member types
// Member `body_frame`
// Member `expressed_in_frame`
#include "halodi_msgs/msg/reference_frame_name.h"
// Member `body_frame`
// Member `expressed_in_frame`
#include "halodi_msgs/msg/reference_frame_name__rosidl_typesupport_introspection_c.h"
// Member `pose`
#include "geometry_msgs/msg/pose.h"
// Member `pose`
#include "geometry_msgs/msg/pose__rosidl_typesupport_introspection_c.h"
// Member `angular_velocity`
// Member `linear_velocity`
// Member `angular_acceleration`
// Member `linear_acceleration`
#include "geometry_msgs/msg/vector3.h"
// Member `angular_velocity`
// Member `linear_velocity`
// Member `angular_acceleration`
// Member `linear_acceleration`
#include "geometry_msgs/msg/vector3__rosidl_typesupport_introspection_c.h"
// Member `passivity_input`
#include "halodi_msgs/msg/passivity_data.h"
// Member `passivity_input`
#include "halodi_msgs/msg/passivity_data__rosidl_typesupport_introspection_c.h"
// Member `orientation_feedback_parameters`
// Member `position_feedback_parameters`
#include "halodi_msgs/msg/feedback_parameters3_d.h"
// Member `orientation_feedback_parameters`
// Member `position_feedback_parameters`
#include "halodi_msgs/msg/feedback_parameters3_d__rosidl_typesupport_introspection_c.h"
// Member `nullspace_command`
#include "halodi_msgs/msg/joint_null_space_configuration.h"
// Member `nullspace_command`
#include "halodi_msgs/msg/joint_null_space_configuration__rosidl_typesupport_introspection_c.h"

#ifdef __cplusplus
extern "C"
{
#endif

void TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_init_function(
  void * message_memory, enum rosidl_runtime_c_message_initialization _init)
{
  // TODO(karsten1987): initializers are not yet implemented for typesupport c
  // see https://github.com/ros2/ros2/issues/397
  (void) _init;
  halodi_msgs__msg__TaskSpaceCommand__init(message_memory);
}

void TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_fini_function(void * message_memory)
{
  halodi_msgs__msg__TaskSpaceCommand__fini(message_memory);
}

size_t TaskSpaceCommand__rosidl_typesupport_introspection_c__size_function__PassivityData__passivity_input(
  const void * untyped_member)
{
  const halodi_msgs__msg__PassivityData__Sequence * member =
    (const halodi_msgs__msg__PassivityData__Sequence *)(untyped_member);
  return member->size;
}

const void * TaskSpaceCommand__rosidl_typesupport_introspection_c__get_const_function__PassivityData__passivity_input(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__PassivityData__Sequence * member =
    (const halodi_msgs__msg__PassivityData__Sequence *)(untyped_member);
  return &member->data[index];
}

void * TaskSpaceCommand__rosidl_typesupport_introspection_c__get_function__PassivityData__passivity_input(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__PassivityData__Sequence * member =
    (halodi_msgs__msg__PassivityData__Sequence *)(untyped_member);
  return &member->data[index];
}

bool TaskSpaceCommand__rosidl_typesupport_introspection_c__resize_function__PassivityData__passivity_input(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__PassivityData__Sequence * member =
    (halodi_msgs__msg__PassivityData__Sequence *)(untyped_member);
  halodi_msgs__msg__PassivityData__Sequence__fini(member);
  return halodi_msgs__msg__PassivityData__Sequence__init(member, size);
}

size_t TaskSpaceCommand__rosidl_typesupport_introspection_c__size_function__FeedbackParameters3D__orientation_feedback_parameters(
  const void * untyped_member)
{
  const halodi_msgs__msg__FeedbackParameters3D__Sequence * member =
    (const halodi_msgs__msg__FeedbackParameters3D__Sequence *)(untyped_member);
  return member->size;
}

const void * TaskSpaceCommand__rosidl_typesupport_introspection_c__get_const_function__FeedbackParameters3D__orientation_feedback_parameters(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__FeedbackParameters3D__Sequence * member =
    (const halodi_msgs__msg__FeedbackParameters3D__Sequence *)(untyped_member);
  return &member->data[index];
}

void * TaskSpaceCommand__rosidl_typesupport_introspection_c__get_function__FeedbackParameters3D__orientation_feedback_parameters(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__FeedbackParameters3D__Sequence * member =
    (halodi_msgs__msg__FeedbackParameters3D__Sequence *)(untyped_member);
  return &member->data[index];
}

bool TaskSpaceCommand__rosidl_typesupport_introspection_c__resize_function__FeedbackParameters3D__orientation_feedback_parameters(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__FeedbackParameters3D__Sequence * member =
    (halodi_msgs__msg__FeedbackParameters3D__Sequence *)(untyped_member);
  halodi_msgs__msg__FeedbackParameters3D__Sequence__fini(member);
  return halodi_msgs__msg__FeedbackParameters3D__Sequence__init(member, size);
}

size_t TaskSpaceCommand__rosidl_typesupport_introspection_c__size_function__FeedbackParameters3D__position_feedback_parameters(
  const void * untyped_member)
{
  const halodi_msgs__msg__FeedbackParameters3D__Sequence * member =
    (const halodi_msgs__msg__FeedbackParameters3D__Sequence *)(untyped_member);
  return member->size;
}

const void * TaskSpaceCommand__rosidl_typesupport_introspection_c__get_const_function__FeedbackParameters3D__position_feedback_parameters(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__FeedbackParameters3D__Sequence * member =
    (const halodi_msgs__msg__FeedbackParameters3D__Sequence *)(untyped_member);
  return &member->data[index];
}

void * TaskSpaceCommand__rosidl_typesupport_introspection_c__get_function__FeedbackParameters3D__position_feedback_parameters(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__FeedbackParameters3D__Sequence * member =
    (halodi_msgs__msg__FeedbackParameters3D__Sequence *)(untyped_member);
  return &member->data[index];
}

bool TaskSpaceCommand__rosidl_typesupport_introspection_c__resize_function__FeedbackParameters3D__position_feedback_parameters(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__FeedbackParameters3D__Sequence * member =
    (halodi_msgs__msg__FeedbackParameters3D__Sequence *)(untyped_member);
  halodi_msgs__msg__FeedbackParameters3D__Sequence__fini(member);
  return halodi_msgs__msg__FeedbackParameters3D__Sequence__init(member, size);
}

size_t TaskSpaceCommand__rosidl_typesupport_introspection_c__size_function__JointNullSpaceConfiguration__nullspace_command(
  const void * untyped_member)
{
  const halodi_msgs__msg__JointNullSpaceConfiguration__Sequence * member =
    (const halodi_msgs__msg__JointNullSpaceConfiguration__Sequence *)(untyped_member);
  return member->size;
}

const void * TaskSpaceCommand__rosidl_typesupport_introspection_c__get_const_function__JointNullSpaceConfiguration__nullspace_command(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__JointNullSpaceConfiguration__Sequence * member =
    (const halodi_msgs__msg__JointNullSpaceConfiguration__Sequence *)(untyped_member);
  return &member->data[index];
}

void * TaskSpaceCommand__rosidl_typesupport_introspection_c__get_function__JointNullSpaceConfiguration__nullspace_command(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__JointNullSpaceConfiguration__Sequence * member =
    (halodi_msgs__msg__JointNullSpaceConfiguration__Sequence *)(untyped_member);
  return &member->data[index];
}

bool TaskSpaceCommand__rosidl_typesupport_introspection_c__resize_function__JointNullSpaceConfiguration__nullspace_command(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__JointNullSpaceConfiguration__Sequence * member =
    (halodi_msgs__msg__JointNullSpaceConfiguration__Sequence *)(untyped_member);
  halodi_msgs__msg__JointNullSpaceConfiguration__Sequence__fini(member);
  return halodi_msgs__msg__JointNullSpaceConfiguration__Sequence__init(member, size);
}

static rosidl_typesupport_introspection_c__MessageMember TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_message_member_array[12] = {
  {
    "body_frame",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__TaskSpaceCommand, body_frame),  // bytes offset in struct
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
    offsetof(halodi_msgs__msg__TaskSpaceCommand, expressed_in_frame),  // bytes offset in struct
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
    offsetof(halodi_msgs__msg__TaskSpaceCommand, express_in_z_up),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "pose",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__TaskSpaceCommand, pose),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "angular_velocity",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__TaskSpaceCommand, angular_velocity),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "linear_velocity",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__TaskSpaceCommand, linear_velocity),  // bytes offset in struct
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
    offsetof(halodi_msgs__msg__TaskSpaceCommand, angular_acceleration),  // bytes offset in struct
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
    offsetof(halodi_msgs__msg__TaskSpaceCommand, linear_acceleration),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "passivity_input",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__TaskSpaceCommand, passivity_input),  // bytes offset in struct
    NULL,  // default value
    TaskSpaceCommand__rosidl_typesupport_introspection_c__size_function__PassivityData__passivity_input,  // size() function pointer
    TaskSpaceCommand__rosidl_typesupport_introspection_c__get_const_function__PassivityData__passivity_input,  // get_const(index) function pointer
    TaskSpaceCommand__rosidl_typesupport_introspection_c__get_function__PassivityData__passivity_input,  // get(index) function pointer
    TaskSpaceCommand__rosidl_typesupport_introspection_c__resize_function__PassivityData__passivity_input  // resize(index) function pointer
  },
  {
    "orientation_feedback_parameters",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__TaskSpaceCommand, orientation_feedback_parameters),  // bytes offset in struct
    NULL,  // default value
    TaskSpaceCommand__rosidl_typesupport_introspection_c__size_function__FeedbackParameters3D__orientation_feedback_parameters,  // size() function pointer
    TaskSpaceCommand__rosidl_typesupport_introspection_c__get_const_function__FeedbackParameters3D__orientation_feedback_parameters,  // get_const(index) function pointer
    TaskSpaceCommand__rosidl_typesupport_introspection_c__get_function__FeedbackParameters3D__orientation_feedback_parameters,  // get(index) function pointer
    TaskSpaceCommand__rosidl_typesupport_introspection_c__resize_function__FeedbackParameters3D__orientation_feedback_parameters  // resize(index) function pointer
  },
  {
    "position_feedback_parameters",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__TaskSpaceCommand, position_feedback_parameters),  // bytes offset in struct
    NULL,  // default value
    TaskSpaceCommand__rosidl_typesupport_introspection_c__size_function__FeedbackParameters3D__position_feedback_parameters,  // size() function pointer
    TaskSpaceCommand__rosidl_typesupport_introspection_c__get_const_function__FeedbackParameters3D__position_feedback_parameters,  // get_const(index) function pointer
    TaskSpaceCommand__rosidl_typesupport_introspection_c__get_function__FeedbackParameters3D__position_feedback_parameters,  // get(index) function pointer
    TaskSpaceCommand__rosidl_typesupport_introspection_c__resize_function__FeedbackParameters3D__position_feedback_parameters  // resize(index) function pointer
  },
  {
    "nullspace_command",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    7,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__TaskSpaceCommand, nullspace_command),  // bytes offset in struct
    NULL,  // default value
    TaskSpaceCommand__rosidl_typesupport_introspection_c__size_function__JointNullSpaceConfiguration__nullspace_command,  // size() function pointer
    TaskSpaceCommand__rosidl_typesupport_introspection_c__get_const_function__JointNullSpaceConfiguration__nullspace_command,  // get_const(index) function pointer
    TaskSpaceCommand__rosidl_typesupport_introspection_c__get_function__JointNullSpaceConfiguration__nullspace_command,  // get(index) function pointer
    TaskSpaceCommand__rosidl_typesupport_introspection_c__resize_function__JointNullSpaceConfiguration__nullspace_command  // resize(index) function pointer
  }
};

static const rosidl_typesupport_introspection_c__MessageMembers TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_message_members = {
  "halodi_msgs__msg",  // message namespace
  "TaskSpaceCommand",  // message name
  12,  // number of fields
  sizeof(halodi_msgs__msg__TaskSpaceCommand),
  TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_message_member_array,  // message members
  TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_init_function,  // function to initialize message memory (memory has to be allocated)
  TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_fini_function  // function to terminate message instance (will not free memory)
};

// this is not const since it must be initialized on first access
// since C does not allow non-integral compile-time constants
static rosidl_message_type_support_t TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_message_type_support_handle = {
  0,
  &TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_message_members,
  get_message_typesupport_handle_function,
};

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, TaskSpaceCommand)() {
  TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_message_member_array[0].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, ReferenceFrameName)();
  TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_message_member_array[1].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, ReferenceFrameName)();
  TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_message_member_array[3].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, Pose)();
  TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_message_member_array[4].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, Vector3)();
  TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_message_member_array[5].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, Vector3)();
  TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_message_member_array[6].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, Vector3)();
  TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_message_member_array[7].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, Vector3)();
  TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_message_member_array[8].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, PassivityData)();
  TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_message_member_array[9].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, FeedbackParameters3D)();
  TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_message_member_array[10].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, FeedbackParameters3D)();
  TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_message_member_array[11].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, JointNullSpaceConfiguration)();
  if (!TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_message_type_support_handle.typesupport_identifier) {
    TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_message_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  return &TaskSpaceCommand__rosidl_typesupport_introspection_c__TaskSpaceCommand_message_type_support_handle;
}
#ifdef __cplusplus
}
#endif
