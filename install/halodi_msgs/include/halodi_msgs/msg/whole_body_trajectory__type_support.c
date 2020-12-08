// generated from rosidl_typesupport_introspection_c/resource/idl__type_support.c.em
// with input from halodi_msgs:msg/WholeBodyTrajectory.idl
// generated code does not contain a copyright notice

#include <stddef.h>
#include "halodi_msgs/msg/whole_body_trajectory__rosidl_typesupport_introspection_c.h"
#include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
#include "rosidl_typesupport_introspection_c/field_types.h"
#include "rosidl_typesupport_introspection_c/identifier.h"
#include "rosidl_typesupport_introspection_c/message_introspection.h"
#include "halodi_msgs/msg/whole_body_trajectory__functions.h"
#include "halodi_msgs/msg/whole_body_trajectory__struct.h"


// Include directives for member types
// Member `trajectory_id`
#include "unique_identifier_msgs/msg/uuid.h"
// Member `trajectory_id`
#include "unique_identifier_msgs/msg/uuid__rosidl_typesupport_introspection_c.h"
// Member `start_time`
#include "builtin_interfaces/msg/time.h"
// Member `start_time`
#include "builtin_interfaces/msg/time__rosidl_typesupport_introspection_c.h"
// Member `balance_mode`
#include "halodi_msgs/msg/balance_mode.h"
// Member `balance_mode`
#include "halodi_msgs/msg/balance_mode__rosidl_typesupport_introspection_c.h"
// Member `interpolation_mode`
#include "halodi_msgs/msg/trajectory_interpolation.h"
// Member `interpolation_mode`
#include "halodi_msgs/msg/trajectory_interpolation__rosidl_typesupport_introspection_c.h"
// Member `trajectory_points`
#include "halodi_msgs/msg/whole_body_trajectory_point.h"
// Member `trajectory_points`
#include "halodi_msgs/msg/whole_body_trajectory_point__rosidl_typesupport_introspection_c.h"

#ifdef __cplusplus
extern "C"
{
#endif

void WholeBodyTrajectory__rosidl_typesupport_introspection_c__WholeBodyTrajectory_init_function(
  void * message_memory, enum rosidl_runtime_c_message_initialization _init)
{
  // TODO(karsten1987): initializers are not yet implemented for typesupport c
  // see https://github.com/ros2/ros2/issues/397
  (void) _init;
  halodi_msgs__msg__WholeBodyTrajectory__init(message_memory);
}

void WholeBodyTrajectory__rosidl_typesupport_introspection_c__WholeBodyTrajectory_fini_function(void * message_memory)
{
  halodi_msgs__msg__WholeBodyTrajectory__fini(message_memory);
}

size_t WholeBodyTrajectory__rosidl_typesupport_introspection_c__size_function__Time__start_time(
  const void * untyped_member)
{
  const builtin_interfaces__msg__Time__Sequence * member =
    (const builtin_interfaces__msg__Time__Sequence *)(untyped_member);
  return member->size;
}

const void * WholeBodyTrajectory__rosidl_typesupport_introspection_c__get_const_function__Time__start_time(
  const void * untyped_member, size_t index)
{
  const builtin_interfaces__msg__Time__Sequence * member =
    (const builtin_interfaces__msg__Time__Sequence *)(untyped_member);
  return &member->data[index];
}

void * WholeBodyTrajectory__rosidl_typesupport_introspection_c__get_function__Time__start_time(
  void * untyped_member, size_t index)
{
  builtin_interfaces__msg__Time__Sequence * member =
    (builtin_interfaces__msg__Time__Sequence *)(untyped_member);
  return &member->data[index];
}

bool WholeBodyTrajectory__rosidl_typesupport_introspection_c__resize_function__Time__start_time(
  void * untyped_member, size_t size)
{
  builtin_interfaces__msg__Time__Sequence * member =
    (builtin_interfaces__msg__Time__Sequence *)(untyped_member);
  builtin_interfaces__msg__Time__Sequence__fini(member);
  return builtin_interfaces__msg__Time__Sequence__init(member, size);
}

size_t WholeBodyTrajectory__rosidl_typesupport_introspection_c__size_function__BalanceMode__balance_mode(
  const void * untyped_member)
{
  const halodi_msgs__msg__BalanceMode__Sequence * member =
    (const halodi_msgs__msg__BalanceMode__Sequence *)(untyped_member);
  return member->size;
}

const void * WholeBodyTrajectory__rosidl_typesupport_introspection_c__get_const_function__BalanceMode__balance_mode(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__BalanceMode__Sequence * member =
    (const halodi_msgs__msg__BalanceMode__Sequence *)(untyped_member);
  return &member->data[index];
}

void * WholeBodyTrajectory__rosidl_typesupport_introspection_c__get_function__BalanceMode__balance_mode(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__BalanceMode__Sequence * member =
    (halodi_msgs__msg__BalanceMode__Sequence *)(untyped_member);
  return &member->data[index];
}

bool WholeBodyTrajectory__rosidl_typesupport_introspection_c__resize_function__BalanceMode__balance_mode(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__BalanceMode__Sequence * member =
    (halodi_msgs__msg__BalanceMode__Sequence *)(untyped_member);
  halodi_msgs__msg__BalanceMode__Sequence__fini(member);
  return halodi_msgs__msg__BalanceMode__Sequence__init(member, size);
}

size_t WholeBodyTrajectory__rosidl_typesupport_introspection_c__size_function__WholeBodyTrajectoryPoint__trajectory_points(
  const void * untyped_member)
{
  const halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence * member =
    (const halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence *)(untyped_member);
  return member->size;
}

const void * WholeBodyTrajectory__rosidl_typesupport_introspection_c__get_const_function__WholeBodyTrajectoryPoint__trajectory_points(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence * member =
    (const halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence *)(untyped_member);
  return &member->data[index];
}

void * WholeBodyTrajectory__rosidl_typesupport_introspection_c__get_function__WholeBodyTrajectoryPoint__trajectory_points(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence * member =
    (halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence *)(untyped_member);
  return &member->data[index];
}

bool WholeBodyTrajectory__rosidl_typesupport_introspection_c__resize_function__WholeBodyTrajectoryPoint__trajectory_points(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence * member =
    (halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence *)(untyped_member);
  halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence__fini(member);
  return halodi_msgs__msg__WholeBodyTrajectoryPoint__Sequence__init(member, size);
}

static rosidl_typesupport_introspection_c__MessageMember WholeBodyTrajectory__rosidl_typesupport_introspection_c__WholeBodyTrajectory_message_member_array[6] = {
  {
    "trajectory_id",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyTrajectory, trajectory_id),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "start_time",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyTrajectory, start_time),  // bytes offset in struct
    NULL,  // default value
    WholeBodyTrajectory__rosidl_typesupport_introspection_c__size_function__Time__start_time,  // size() function pointer
    WholeBodyTrajectory__rosidl_typesupport_introspection_c__get_const_function__Time__start_time,  // get_const(index) function pointer
    WholeBodyTrajectory__rosidl_typesupport_introspection_c__get_function__Time__start_time,  // get(index) function pointer
    WholeBodyTrajectory__rosidl_typesupport_introspection_c__resize_function__Time__start_time  // resize(index) function pointer
  },
  {
    "balance_mode",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyTrajectory, balance_mode),  // bytes offset in struct
    NULL,  // default value
    WholeBodyTrajectory__rosidl_typesupport_introspection_c__size_function__BalanceMode__balance_mode,  // size() function pointer
    WholeBodyTrajectory__rosidl_typesupport_introspection_c__get_const_function__BalanceMode__balance_mode,  // get_const(index) function pointer
    WholeBodyTrajectory__rosidl_typesupport_introspection_c__get_function__BalanceMode__balance_mode,  // get(index) function pointer
    WholeBodyTrajectory__rosidl_typesupport_introspection_c__resize_function__BalanceMode__balance_mode  // resize(index) function pointer
  },
  {
    "append_trajectory",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyTrajectory, append_trajectory),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "interpolation_mode",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyTrajectory, interpolation_mode),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "trajectory_points",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    255,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyTrajectory, trajectory_points),  // bytes offset in struct
    NULL,  // default value
    WholeBodyTrajectory__rosidl_typesupport_introspection_c__size_function__WholeBodyTrajectoryPoint__trajectory_points,  // size() function pointer
    WholeBodyTrajectory__rosidl_typesupport_introspection_c__get_const_function__WholeBodyTrajectoryPoint__trajectory_points,  // get_const(index) function pointer
    WholeBodyTrajectory__rosidl_typesupport_introspection_c__get_function__WholeBodyTrajectoryPoint__trajectory_points,  // get(index) function pointer
    WholeBodyTrajectory__rosidl_typesupport_introspection_c__resize_function__WholeBodyTrajectoryPoint__trajectory_points  // resize(index) function pointer
  }
};

static const rosidl_typesupport_introspection_c__MessageMembers WholeBodyTrajectory__rosidl_typesupport_introspection_c__WholeBodyTrajectory_message_members = {
  "halodi_msgs__msg",  // message namespace
  "WholeBodyTrajectory",  // message name
  6,  // number of fields
  sizeof(halodi_msgs__msg__WholeBodyTrajectory),
  WholeBodyTrajectory__rosidl_typesupport_introspection_c__WholeBodyTrajectory_message_member_array,  // message members
  WholeBodyTrajectory__rosidl_typesupport_introspection_c__WholeBodyTrajectory_init_function,  // function to initialize message memory (memory has to be allocated)
  WholeBodyTrajectory__rosidl_typesupport_introspection_c__WholeBodyTrajectory_fini_function  // function to terminate message instance (will not free memory)
};

// this is not const since it must be initialized on first access
// since C does not allow non-integral compile-time constants
static rosidl_message_type_support_t WholeBodyTrajectory__rosidl_typesupport_introspection_c__WholeBodyTrajectory_message_type_support_handle = {
  0,
  &WholeBodyTrajectory__rosidl_typesupport_introspection_c__WholeBodyTrajectory_message_members,
  get_message_typesupport_handle_function,
};

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, WholeBodyTrajectory)() {
  WholeBodyTrajectory__rosidl_typesupport_introspection_c__WholeBodyTrajectory_message_member_array[0].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, unique_identifier_msgs, msg, UUID)();
  WholeBodyTrajectory__rosidl_typesupport_introspection_c__WholeBodyTrajectory_message_member_array[1].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, builtin_interfaces, msg, Time)();
  WholeBodyTrajectory__rosidl_typesupport_introspection_c__WholeBodyTrajectory_message_member_array[2].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, BalanceMode)();
  WholeBodyTrajectory__rosidl_typesupport_introspection_c__WholeBodyTrajectory_message_member_array[4].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, TrajectoryInterpolation)();
  WholeBodyTrajectory__rosidl_typesupport_introspection_c__WholeBodyTrajectory_message_member_array[5].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, WholeBodyTrajectoryPoint)();
  if (!WholeBodyTrajectory__rosidl_typesupport_introspection_c__WholeBodyTrajectory_message_type_support_handle.typesupport_identifier) {
    WholeBodyTrajectory__rosidl_typesupport_introspection_c__WholeBodyTrajectory_message_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  return &WholeBodyTrajectory__rosidl_typesupport_introspection_c__WholeBodyTrajectory_message_type_support_handle;
}
#ifdef __cplusplus
}
#endif
