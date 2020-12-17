// generated from rosidl_typesupport_introspection_c/resource/idl__type_support.c.em
// with input from halodi_msgs:msg/WholeBodyTrajectoryPoint.idl
// generated code does not contain a copyright notice

#include <stddef.h>
#include "halodi_msgs/msg/whole_body_trajectory_point__rosidl_typesupport_introspection_c.h"
#include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
#include "rosidl_typesupport_introspection_c/field_types.h"
#include "rosidl_typesupport_introspection_c/identifier.h"
#include "rosidl_typesupport_introspection_c/message_introspection.h"
#include "halodi_msgs/msg/whole_body_trajectory_point__functions.h"
#include "halodi_msgs/msg/whole_body_trajectory_point__struct.h"


// Include directives for member types
// Member `time_from_start`
#include "builtin_interfaces/msg/duration.h"
// Member `time_from_start`
#include "builtin_interfaces/msg/duration__rosidl_typesupport_introspection_c.h"
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
// Member `icp_offset_command`
#include "geometry_msgs/msg/vector3.h"
// Member `icp_offset_command`
#include "geometry_msgs/msg/vector3__rosidl_typesupport_introspection_c.h"

#ifdef __cplusplus
extern "C"
{
#endif

void WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__WholeBodyTrajectoryPoint_init_function(
  void * message_memory, enum rosidl_runtime_c_message_initialization _init)
{
  // TODO(karsten1987): initializers are not yet implemented for typesupport c
  // see https://github.com/ros2/ros2/issues/397
  (void) _init;
  halodi_msgs__msg__WholeBodyTrajectoryPoint__init(message_memory);
}

void WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__WholeBodyTrajectoryPoint_fini_function(void * message_memory)
{
  halodi_msgs__msg__WholeBodyTrajectoryPoint__fini(message_memory);
}

size_t WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__size_function__TaskSpaceCommand__task_space_commands(
  const void * untyped_member)
{
  const halodi_msgs__msg__TaskSpaceCommand__Sequence * member =
    (const halodi_msgs__msg__TaskSpaceCommand__Sequence *)(untyped_member);
  return member->size;
}

const void * WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__get_const_function__TaskSpaceCommand__task_space_commands(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__TaskSpaceCommand__Sequence * member =
    (const halodi_msgs__msg__TaskSpaceCommand__Sequence *)(untyped_member);
  return &member->data[index];
}

void * WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__get_function__TaskSpaceCommand__task_space_commands(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__TaskSpaceCommand__Sequence * member =
    (halodi_msgs__msg__TaskSpaceCommand__Sequence *)(untyped_member);
  return &member->data[index];
}

bool WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__resize_function__TaskSpaceCommand__task_space_commands(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__TaskSpaceCommand__Sequence * member =
    (halodi_msgs__msg__TaskSpaceCommand__Sequence *)(untyped_member);
  halodi_msgs__msg__TaskSpaceCommand__Sequence__fini(member);
  return halodi_msgs__msg__TaskSpaceCommand__Sequence__init(member, size);
}

size_t WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__size_function__JointSpaceCommand__joint_space_commands(
  const void * untyped_member)
{
  const halodi_msgs__msg__JointSpaceCommand__Sequence * member =
    (const halodi_msgs__msg__JointSpaceCommand__Sequence *)(untyped_member);
  return member->size;
}

const void * WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__get_const_function__JointSpaceCommand__joint_space_commands(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__JointSpaceCommand__Sequence * member =
    (const halodi_msgs__msg__JointSpaceCommand__Sequence *)(untyped_member);
  return &member->data[index];
}

void * WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__get_function__JointSpaceCommand__joint_space_commands(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__JointSpaceCommand__Sequence * member =
    (halodi_msgs__msg__JointSpaceCommand__Sequence *)(untyped_member);
  return &member->data[index];
}

bool WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__resize_function__JointSpaceCommand__joint_space_commands(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__JointSpaceCommand__Sequence * member =
    (halodi_msgs__msg__JointSpaceCommand__Sequence *)(untyped_member);
  halodi_msgs__msg__JointSpaceCommand__Sequence__fini(member);
  return halodi_msgs__msg__JointSpaceCommand__Sequence__init(member, size);
}

size_t WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__size_function__ContactPointCommand__contact_point_commands(
  const void * untyped_member)
{
  const halodi_msgs__msg__ContactPointCommand__Sequence * member =
    (const halodi_msgs__msg__ContactPointCommand__Sequence *)(untyped_member);
  return member->size;
}

const void * WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__get_const_function__ContactPointCommand__contact_point_commands(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__ContactPointCommand__Sequence * member =
    (const halodi_msgs__msg__ContactPointCommand__Sequence *)(untyped_member);
  return &member->data[index];
}

void * WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__get_function__ContactPointCommand__contact_point_commands(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__ContactPointCommand__Sequence * member =
    (halodi_msgs__msg__ContactPointCommand__Sequence *)(untyped_member);
  return &member->data[index];
}

bool WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__resize_function__ContactPointCommand__contact_point_commands(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__ContactPointCommand__Sequence * member =
    (halodi_msgs__msg__ContactPointCommand__Sequence *)(untyped_member);
  halodi_msgs__msg__ContactPointCommand__Sequence__fini(member);
  return halodi_msgs__msg__ContactPointCommand__Sequence__init(member, size);
}

size_t WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__size_function__Vector3__icp_offset_command(
  const void * untyped_member)
{
  const geometry_msgs__msg__Vector3__Sequence * member =
    (const geometry_msgs__msg__Vector3__Sequence *)(untyped_member);
  return member->size;
}

const void * WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__get_const_function__Vector3__icp_offset_command(
  const void * untyped_member, size_t index)
{
  const geometry_msgs__msg__Vector3__Sequence * member =
    (const geometry_msgs__msg__Vector3__Sequence *)(untyped_member);
  return &member->data[index];
}

void * WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__get_function__Vector3__icp_offset_command(
  void * untyped_member, size_t index)
{
  geometry_msgs__msg__Vector3__Sequence * member =
    (geometry_msgs__msg__Vector3__Sequence *)(untyped_member);
  return &member->data[index];
}

bool WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__resize_function__Vector3__icp_offset_command(
  void * untyped_member, size_t size)
{
  geometry_msgs__msg__Vector3__Sequence * member =
    (geometry_msgs__msg__Vector3__Sequence *)(untyped_member);
  geometry_msgs__msg__Vector3__Sequence__fini(member);
  return geometry_msgs__msg__Vector3__Sequence__init(member, size);
}

static rosidl_typesupport_introspection_c__MessageMember WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__WholeBodyTrajectoryPoint_message_member_array[5] = {
  {
    "time_from_start",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyTrajectoryPoint, time_from_start),  // bytes offset in struct
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
    offsetof(halodi_msgs__msg__WholeBodyTrajectoryPoint, task_space_commands),  // bytes offset in struct
    NULL,  // default value
    WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__size_function__TaskSpaceCommand__task_space_commands,  // size() function pointer
    WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__get_const_function__TaskSpaceCommand__task_space_commands,  // get_const(index) function pointer
    WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__get_function__TaskSpaceCommand__task_space_commands,  // get(index) function pointer
    WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__resize_function__TaskSpaceCommand__task_space_commands  // resize(index) function pointer
  },
  {
    "joint_space_commands",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    25,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyTrajectoryPoint, joint_space_commands),  // bytes offset in struct
    NULL,  // default value
    WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__size_function__JointSpaceCommand__joint_space_commands,  // size() function pointer
    WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__get_const_function__JointSpaceCommand__joint_space_commands,  // get_const(index) function pointer
    WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__get_function__JointSpaceCommand__joint_space_commands,  // get(index) function pointer
    WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__resize_function__JointSpaceCommand__joint_space_commands  // resize(index) function pointer
  },
  {
    "contact_point_commands",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    5,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyTrajectoryPoint, contact_point_commands),  // bytes offset in struct
    NULL,  // default value
    WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__size_function__ContactPointCommand__contact_point_commands,  // size() function pointer
    WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__get_const_function__ContactPointCommand__contact_point_commands,  // get_const(index) function pointer
    WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__get_function__ContactPointCommand__contact_point_commands,  // get(index) function pointer
    WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__resize_function__ContactPointCommand__contact_point_commands  // resize(index) function pointer
  },
  {
    "icp_offset_command",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyTrajectoryPoint, icp_offset_command),  // bytes offset in struct
    NULL,  // default value
    WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__size_function__Vector3__icp_offset_command,  // size() function pointer
    WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__get_const_function__Vector3__icp_offset_command,  // get_const(index) function pointer
    WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__get_function__Vector3__icp_offset_command,  // get(index) function pointer
    WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__resize_function__Vector3__icp_offset_command  // resize(index) function pointer
  }
};

static const rosidl_typesupport_introspection_c__MessageMembers WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__WholeBodyTrajectoryPoint_message_members = {
  "halodi_msgs__msg",  // message namespace
  "WholeBodyTrajectoryPoint",  // message name
  5,  // number of fields
  sizeof(halodi_msgs__msg__WholeBodyTrajectoryPoint),
  WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__WholeBodyTrajectoryPoint_message_member_array,  // message members
  WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__WholeBodyTrajectoryPoint_init_function,  // function to initialize message memory (memory has to be allocated)
  WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__WholeBodyTrajectoryPoint_fini_function  // function to terminate message instance (will not free memory)
};

// this is not const since it must be initialized on first access
// since C does not allow non-integral compile-time constants
static rosidl_message_type_support_t WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__WholeBodyTrajectoryPoint_message_type_support_handle = {
  0,
  &WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__WholeBodyTrajectoryPoint_message_members,
  get_message_typesupport_handle_function,
};

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, WholeBodyTrajectoryPoint)() {
  WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__WholeBodyTrajectoryPoint_message_member_array[0].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, builtin_interfaces, msg, Duration)();
  WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__WholeBodyTrajectoryPoint_message_member_array[1].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, TaskSpaceCommand)();
  WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__WholeBodyTrajectoryPoint_message_member_array[2].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, JointSpaceCommand)();
  WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__WholeBodyTrajectoryPoint_message_member_array[3].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, ContactPointCommand)();
  WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__WholeBodyTrajectoryPoint_message_member_array[4].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, Vector3)();
  if (!WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__WholeBodyTrajectoryPoint_message_type_support_handle.typesupport_identifier) {
    WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__WholeBodyTrajectoryPoint_message_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  return &WholeBodyTrajectoryPoint__rosidl_typesupport_introspection_c__WholeBodyTrajectoryPoint_message_type_support_handle;
}
#ifdef __cplusplus
}
#endif
