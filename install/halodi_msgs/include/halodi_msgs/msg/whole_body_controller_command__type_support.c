// generated from rosidl_typesupport_introspection_c/resource/idl__type_support.c.em
// with input from halodi_msgs:msg/WholeBodyControllerCommand.idl
// generated code does not contain a copyright notice

#include <stddef.h>
#include "halodi_msgs/msg/whole_body_controller_command__rosidl_typesupport_introspection_c.h"
#include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
#include "rosidl_typesupport_introspection_c/field_types.h"
#include "rosidl_typesupport_introspection_c/identifier.h"
#include "rosidl_typesupport_introspection_c/message_introspection.h"
#include "halodi_msgs/msg/whole_body_controller_command__functions.h"
#include "halodi_msgs/msg/whole_body_controller_command__struct.h"


// Include directives for member types
// Member `balance_mode`
#include "halodi_msgs/msg/balance_mode.h"
// Member `balance_mode`
#include "halodi_msgs/msg/balance_mode__rosidl_typesupport_introspection_c.h"
// Member `task_space_commands`
#include "halodi_msgs/msg/task_space_command.h"
// Member `task_space_commands`
#include "halodi_msgs/msg/task_space_command__rosidl_typesupport_introspection_c.h"
// Member `joint_space_commands`
#include "halodi_msgs/msg/joint_space_command.h"
// Member `joint_space_commands`
#include "halodi_msgs/msg/joint_space_command__rosidl_typesupport_introspection_c.h"
// Member `contact_point_commands`
#include "halodi_msgs/msg/contact_point_command.h"
// Member `contact_point_commands`
#include "halodi_msgs/msg/contact_point_command__rosidl_typesupport_introspection_c.h"
// Member `driving_command`
#include "halodi_msgs/msg/driving_command.h"
// Member `driving_command`
#include "halodi_msgs/msg/driving_command__rosidl_typesupport_introspection_c.h"
// Member `icp_command`
#include "geometry_msgs/msg/vector3.h"
// Member `icp_command`
#include "geometry_msgs/msg/vector3__rosidl_typesupport_introspection_c.h"

#ifdef __cplusplus
extern "C"
{
#endif

void WholeBodyControllerCommand__rosidl_typesupport_introspection_c__WholeBodyControllerCommand_init_function(
  void * message_memory, enum rosidl_runtime_c_message_initialization _init)
{
  // TODO(karsten1987): initializers are not yet implemented for typesupport c
  // see https://github.com/ros2/ros2/issues/397
  (void) _init;
  halodi_msgs__msg__WholeBodyControllerCommand__init(message_memory);
}

void WholeBodyControllerCommand__rosidl_typesupport_introspection_c__WholeBodyControllerCommand_fini_function(void * message_memory)
{
  halodi_msgs__msg__WholeBodyControllerCommand__fini(message_memory);
}

size_t WholeBodyControllerCommand__rosidl_typesupport_introspection_c__size_function__TaskSpaceCommand__task_space_commands(
  const void * untyped_member)
{
  const halodi_msgs__msg__TaskSpaceCommand__Sequence * member =
    (const halodi_msgs__msg__TaskSpaceCommand__Sequence *)(untyped_member);
  return member->size;
}

const void * WholeBodyControllerCommand__rosidl_typesupport_introspection_c__get_const_function__TaskSpaceCommand__task_space_commands(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__TaskSpaceCommand__Sequence * member =
    (const halodi_msgs__msg__TaskSpaceCommand__Sequence *)(untyped_member);
  return &member->data[index];
}

void * WholeBodyControllerCommand__rosidl_typesupport_introspection_c__get_function__TaskSpaceCommand__task_space_commands(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__TaskSpaceCommand__Sequence * member =
    (halodi_msgs__msg__TaskSpaceCommand__Sequence *)(untyped_member);
  return &member->data[index];
}

bool WholeBodyControllerCommand__rosidl_typesupport_introspection_c__resize_function__TaskSpaceCommand__task_space_commands(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__TaskSpaceCommand__Sequence * member =
    (halodi_msgs__msg__TaskSpaceCommand__Sequence *)(untyped_member);
  halodi_msgs__msg__TaskSpaceCommand__Sequence__fini(member);
  return halodi_msgs__msg__TaskSpaceCommand__Sequence__init(member, size);
}

size_t WholeBodyControllerCommand__rosidl_typesupport_introspection_c__size_function__JointSpaceCommand__joint_space_commands(
  const void * untyped_member)
{
  const halodi_msgs__msg__JointSpaceCommand__Sequence * member =
    (const halodi_msgs__msg__JointSpaceCommand__Sequence *)(untyped_member);
  return member->size;
}

const void * WholeBodyControllerCommand__rosidl_typesupport_introspection_c__get_const_function__JointSpaceCommand__joint_space_commands(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__JointSpaceCommand__Sequence * member =
    (const halodi_msgs__msg__JointSpaceCommand__Sequence *)(untyped_member);
  return &member->data[index];
}

void * WholeBodyControllerCommand__rosidl_typesupport_introspection_c__get_function__JointSpaceCommand__joint_space_commands(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__JointSpaceCommand__Sequence * member =
    (halodi_msgs__msg__JointSpaceCommand__Sequence *)(untyped_member);
  return &member->data[index];
}

bool WholeBodyControllerCommand__rosidl_typesupport_introspection_c__resize_function__JointSpaceCommand__joint_space_commands(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__JointSpaceCommand__Sequence * member =
    (halodi_msgs__msg__JointSpaceCommand__Sequence *)(untyped_member);
  halodi_msgs__msg__JointSpaceCommand__Sequence__fini(member);
  return halodi_msgs__msg__JointSpaceCommand__Sequence__init(member, size);
}

size_t WholeBodyControllerCommand__rosidl_typesupport_introspection_c__size_function__ContactPointCommand__contact_point_commands(
  const void * untyped_member)
{
  const halodi_msgs__msg__ContactPointCommand__Sequence * member =
    (const halodi_msgs__msg__ContactPointCommand__Sequence *)(untyped_member);
  return member->size;
}

const void * WholeBodyControllerCommand__rosidl_typesupport_introspection_c__get_const_function__ContactPointCommand__contact_point_commands(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__ContactPointCommand__Sequence * member =
    (const halodi_msgs__msg__ContactPointCommand__Sequence *)(untyped_member);
  return &member->data[index];
}

void * WholeBodyControllerCommand__rosidl_typesupport_introspection_c__get_function__ContactPointCommand__contact_point_commands(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__ContactPointCommand__Sequence * member =
    (halodi_msgs__msg__ContactPointCommand__Sequence *)(untyped_member);
  return &member->data[index];
}

bool WholeBodyControllerCommand__rosidl_typesupport_introspection_c__resize_function__ContactPointCommand__contact_point_commands(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__ContactPointCommand__Sequence * member =
    (halodi_msgs__msg__ContactPointCommand__Sequence *)(untyped_member);
  halodi_msgs__msg__ContactPointCommand__Sequence__fini(member);
  return halodi_msgs__msg__ContactPointCommand__Sequence__init(member, size);
}

size_t WholeBodyControllerCommand__rosidl_typesupport_introspection_c__size_function__DrivingCommand__driving_command(
  const void * untyped_member)
{
  const halodi_msgs__msg__DrivingCommand__Sequence * member =
    (const halodi_msgs__msg__DrivingCommand__Sequence *)(untyped_member);
  return member->size;
}

const void * WholeBodyControllerCommand__rosidl_typesupport_introspection_c__get_const_function__DrivingCommand__driving_command(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__DrivingCommand__Sequence * member =
    (const halodi_msgs__msg__DrivingCommand__Sequence *)(untyped_member);
  return &member->data[index];
}

void * WholeBodyControllerCommand__rosidl_typesupport_introspection_c__get_function__DrivingCommand__driving_command(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__DrivingCommand__Sequence * member =
    (halodi_msgs__msg__DrivingCommand__Sequence *)(untyped_member);
  return &member->data[index];
}

bool WholeBodyControllerCommand__rosidl_typesupport_introspection_c__resize_function__DrivingCommand__driving_command(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__DrivingCommand__Sequence * member =
    (halodi_msgs__msg__DrivingCommand__Sequence *)(untyped_member);
  halodi_msgs__msg__DrivingCommand__Sequence__fini(member);
  return halodi_msgs__msg__DrivingCommand__Sequence__init(member, size);
}

size_t WholeBodyControllerCommand__rosidl_typesupport_introspection_c__size_function__Vector3__icp_command(
  const void * untyped_member)
{
  const geometry_msgs__msg__Vector3__Sequence * member =
    (const geometry_msgs__msg__Vector3__Sequence *)(untyped_member);
  return member->size;
}

const void * WholeBodyControllerCommand__rosidl_typesupport_introspection_c__get_const_function__Vector3__icp_command(
  const void * untyped_member, size_t index)
{
  const geometry_msgs__msg__Vector3__Sequence * member =
    (const geometry_msgs__msg__Vector3__Sequence *)(untyped_member);
  return &member->data[index];
}

void * WholeBodyControllerCommand__rosidl_typesupport_introspection_c__get_function__Vector3__icp_command(
  void * untyped_member, size_t index)
{
  geometry_msgs__msg__Vector3__Sequence * member =
    (geometry_msgs__msg__Vector3__Sequence *)(untyped_member);
  return &member->data[index];
}

bool WholeBodyControllerCommand__rosidl_typesupport_introspection_c__resize_function__Vector3__icp_command(
  void * untyped_member, size_t size)
{
  geometry_msgs__msg__Vector3__Sequence * member =
    (geometry_msgs__msg__Vector3__Sequence *)(untyped_member);
  geometry_msgs__msg__Vector3__Sequence__fini(member);
  return geometry_msgs__msg__Vector3__Sequence__init(member, size);
}

static rosidl_typesupport_introspection_c__MessageMember WholeBodyControllerCommand__rosidl_typesupport_introspection_c__WholeBodyControllerCommand_message_member_array[7] = {
  {
    "sequence_id",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_INT32,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyControllerCommand, sequence_id),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "balance_mode",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyControllerCommand, balance_mode),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "task_space_commands",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    5,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyControllerCommand, task_space_commands),  // bytes offset in struct
    NULL,  // default value
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__size_function__TaskSpaceCommand__task_space_commands,  // size() function pointer
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__get_const_function__TaskSpaceCommand__task_space_commands,  // get_const(index) function pointer
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__get_function__TaskSpaceCommand__task_space_commands,  // get(index) function pointer
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__resize_function__TaskSpaceCommand__task_space_commands  // resize(index) function pointer
  },
  {
    "joint_space_commands",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    25,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyControllerCommand, joint_space_commands),  // bytes offset in struct
    NULL,  // default value
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__size_function__JointSpaceCommand__joint_space_commands,  // size() function pointer
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__get_const_function__JointSpaceCommand__joint_space_commands,  // get_const(index) function pointer
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__get_function__JointSpaceCommand__joint_space_commands,  // get(index) function pointer
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__resize_function__JointSpaceCommand__joint_space_commands  // resize(index) function pointer
  },
  {
    "contact_point_commands",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    5,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyControllerCommand, contact_point_commands),  // bytes offset in struct
    NULL,  // default value
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__size_function__ContactPointCommand__contact_point_commands,  // size() function pointer
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__get_const_function__ContactPointCommand__contact_point_commands,  // get_const(index) function pointer
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__get_function__ContactPointCommand__contact_point_commands,  // get(index) function pointer
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__resize_function__ContactPointCommand__contact_point_commands  // resize(index) function pointer
  },
  {
    "driving_command",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    20,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyControllerCommand, driving_command),  // bytes offset in struct
    NULL,  // default value
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__size_function__DrivingCommand__driving_command,  // size() function pointer
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__get_const_function__DrivingCommand__driving_command,  // get_const(index) function pointer
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__get_function__DrivingCommand__driving_command,  // get(index) function pointer
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__resize_function__DrivingCommand__driving_command  // resize(index) function pointer
  },
  {
    "icp_command",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    20,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyControllerCommand, icp_command),  // bytes offset in struct
    NULL,  // default value
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__size_function__Vector3__icp_command,  // size() function pointer
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__get_const_function__Vector3__icp_command,  // get_const(index) function pointer
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__get_function__Vector3__icp_command,  // get(index) function pointer
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__resize_function__Vector3__icp_command  // resize(index) function pointer
  }
};

static const rosidl_typesupport_introspection_c__MessageMembers WholeBodyControllerCommand__rosidl_typesupport_introspection_c__WholeBodyControllerCommand_message_members = {
  "halodi_msgs__msg",  // message namespace
  "WholeBodyControllerCommand",  // message name
  7,  // number of fields
  sizeof(halodi_msgs__msg__WholeBodyControllerCommand),
  WholeBodyControllerCommand__rosidl_typesupport_introspection_c__WholeBodyControllerCommand_message_member_array,  // message members
  WholeBodyControllerCommand__rosidl_typesupport_introspection_c__WholeBodyControllerCommand_init_function,  // function to initialize message memory (memory has to be allocated)
  WholeBodyControllerCommand__rosidl_typesupport_introspection_c__WholeBodyControllerCommand_fini_function  // function to terminate message instance (will not free memory)
};

// this is not const since it must be initialized on first access
// since C does not allow non-integral compile-time constants
static rosidl_message_type_support_t WholeBodyControllerCommand__rosidl_typesupport_introspection_c__WholeBodyControllerCommand_message_type_support_handle = {
  0,
  &WholeBodyControllerCommand__rosidl_typesupport_introspection_c__WholeBodyControllerCommand_message_members,
  get_message_typesupport_handle_function,
};

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, WholeBodyControllerCommand)() {
  WholeBodyControllerCommand__rosidl_typesupport_introspection_c__WholeBodyControllerCommand_message_member_array[1].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, BalanceMode)();
  WholeBodyControllerCommand__rosidl_typesupport_introspection_c__WholeBodyControllerCommand_message_member_array[2].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, TaskSpaceCommand)();
  WholeBodyControllerCommand__rosidl_typesupport_introspection_c__WholeBodyControllerCommand_message_member_array[3].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, JointSpaceCommand)();
  WholeBodyControllerCommand__rosidl_typesupport_introspection_c__WholeBodyControllerCommand_message_member_array[4].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, ContactPointCommand)();
  WholeBodyControllerCommand__rosidl_typesupport_introspection_c__WholeBodyControllerCommand_message_member_array[5].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, DrivingCommand)();
  WholeBodyControllerCommand__rosidl_typesupport_introspection_c__WholeBodyControllerCommand_message_member_array[6].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, Vector3)();
  if (!WholeBodyControllerCommand__rosidl_typesupport_introspection_c__WholeBodyControllerCommand_message_type_support_handle.typesupport_identifier) {
    WholeBodyControllerCommand__rosidl_typesupport_introspection_c__WholeBodyControllerCommand_message_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  return &WholeBodyControllerCommand__rosidl_typesupport_introspection_c__WholeBodyControllerCommand_message_type_support_handle;
}
#ifdef __cplusplus
}
#endif
