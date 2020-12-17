// generated from rosidl_typesupport_introspection_c/resource/idl__type_support.c.em
// with input from halodi_msgs:msg/RobotStatus.idl
// generated code does not contain a copyright notice

#include <stddef.h>
#include "halodi_msgs/msg/robot_status__rosidl_typesupport_introspection_c.h"
#include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
#include "rosidl_typesupport_introspection_c/field_types.h"
#include "rosidl_typesupport_introspection_c/identifier.h"
#include "rosidl_typesupport_introspection_c/message_introspection.h"
#include "halodi_msgs/msg/robot_status__functions.h"
#include "halodi_msgs/msg/robot_status__struct.h"


// Include directives for member types
// Member `header`
#include "std_msgs/msg/header.h"
// Member `header`
#include "std_msgs/msg/header__rosidl_typesupport_introspection_c.h"
// Member `battery_status`
#include "halodi_msgs/msg/battery_status.h"
// Member `battery_status`
#include "halodi_msgs/msg/battery_status__rosidl_typesupport_introspection_c.h"
// Member `joint_status`
#include "halodi_msgs/msg/joint_status.h"
// Member `joint_status`
#include "halodi_msgs/msg/joint_status__rosidl_typesupport_introspection_c.h"
// Member `motor_status`
#include "halodi_msgs/msg/motor_status.h"
// Member `motor_status`
#include "halodi_msgs/msg/motor_status__rosidl_typesupport_introspection_c.h"

#ifdef __cplusplus
extern "C"
{
#endif

void RobotStatus__rosidl_typesupport_introspection_c__RobotStatus_init_function(
  void * message_memory, enum rosidl_runtime_c_message_initialization _init)
{
  // TODO(karsten1987): initializers are not yet implemented for typesupport c
  // see https://github.com/ros2/ros2/issues/397
  (void) _init;
  halodi_msgs__msg__RobotStatus__init(message_memory);
}

void RobotStatus__rosidl_typesupport_introspection_c__RobotStatus_fini_function(void * message_memory)
{
  halodi_msgs__msg__RobotStatus__fini(message_memory);
}

size_t RobotStatus__rosidl_typesupport_introspection_c__size_function__JointStatus__joint_status(
  const void * untyped_member)
{
  const halodi_msgs__msg__JointStatus__Sequence * member =
    (const halodi_msgs__msg__JointStatus__Sequence *)(untyped_member);
  return member->size;
}

const void * RobotStatus__rosidl_typesupport_introspection_c__get_const_function__JointStatus__joint_status(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__JointStatus__Sequence * member =
    (const halodi_msgs__msg__JointStatus__Sequence *)(untyped_member);
  return &member->data[index];
}

void * RobotStatus__rosidl_typesupport_introspection_c__get_function__JointStatus__joint_status(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__JointStatus__Sequence * member =
    (halodi_msgs__msg__JointStatus__Sequence *)(untyped_member);
  return &member->data[index];
}

bool RobotStatus__rosidl_typesupport_introspection_c__resize_function__JointStatus__joint_status(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__JointStatus__Sequence * member =
    (halodi_msgs__msg__JointStatus__Sequence *)(untyped_member);
  halodi_msgs__msg__JointStatus__Sequence__fini(member);
  return halodi_msgs__msg__JointStatus__Sequence__init(member, size);
}

size_t RobotStatus__rosidl_typesupport_introspection_c__size_function__MotorStatus__motor_status(
  const void * untyped_member)
{
  const halodi_msgs__msg__MotorStatus__Sequence * member =
    (const halodi_msgs__msg__MotorStatus__Sequence *)(untyped_member);
  return member->size;
}

const void * RobotStatus__rosidl_typesupport_introspection_c__get_const_function__MotorStatus__motor_status(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__MotorStatus__Sequence * member =
    (const halodi_msgs__msg__MotorStatus__Sequence *)(untyped_member);
  return &member->data[index];
}

void * RobotStatus__rosidl_typesupport_introspection_c__get_function__MotorStatus__motor_status(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__MotorStatus__Sequence * member =
    (halodi_msgs__msg__MotorStatus__Sequence *)(untyped_member);
  return &member->data[index];
}

bool RobotStatus__rosidl_typesupport_introspection_c__resize_function__MotorStatus__motor_status(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__MotorStatus__Sequence * member =
    (halodi_msgs__msg__MotorStatus__Sequence *)(untyped_member);
  halodi_msgs__msg__MotorStatus__Sequence__fini(member);
  return halodi_msgs__msg__MotorStatus__Sequence__init(member, size);
}

static rosidl_typesupport_introspection_c__MessageMember RobotStatus__rosidl_typesupport_introspection_c__RobotStatus_message_member_array[12] = {
  {
    "header",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__RobotStatus, header),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "robot_status_level",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_OCTET,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__RobotStatus, robot_status_level),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "battery_status",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__RobotStatus, battery_status),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "backpack_estop_enabled",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__RobotStatus, backpack_estop_enabled),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "wireless_estop_enabled",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__RobotStatus, wireless_estop_enabled),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "over_temperature",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__RobotStatus, over_temperature),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "driving_disabled",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__RobotStatus, driving_disabled),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "joint_status",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    30,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__RobotStatus, joint_status),  // bytes offset in struct
    NULL,  // default value
    RobotStatus__rosidl_typesupport_introspection_c__size_function__JointStatus__joint_status,  // size() function pointer
    RobotStatus__rosidl_typesupport_introspection_c__get_const_function__JointStatus__joint_status,  // get_const(index) function pointer
    RobotStatus__rosidl_typesupport_introspection_c__get_function__JointStatus__joint_status,  // get(index) function pointer
    RobotStatus__rosidl_typesupport_introspection_c__resize_function__JointStatus__joint_status  // resize(index) function pointer
  },
  {
    "motor_status",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    30,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__RobotStatus, motor_status),  // bytes offset in struct
    NULL,  // default value
    RobotStatus__rosidl_typesupport_introspection_c__size_function__MotorStatus__motor_status,  // size() function pointer
    RobotStatus__rosidl_typesupport_introspection_c__get_const_function__MotorStatus__motor_status,  // get_const(index) function pointer
    RobotStatus__rosidl_typesupport_introspection_c__get_function__MotorStatus__motor_status,  // get(index) function pointer
    RobotStatus__rosidl_typesupport_introspection_c__resize_function__MotorStatus__motor_status  // resize(index) function pointer
  },
  {
    "runtime_since_start",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_UINT32,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__RobotStatus, runtime_since_start),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "total_runtime",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_UINT32,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__RobotStatus, total_runtime),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "numberOfRuns",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_UINT32,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__RobotStatus, numberOfRuns),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  }
};

static const rosidl_typesupport_introspection_c__MessageMembers RobotStatus__rosidl_typesupport_introspection_c__RobotStatus_message_members = {
  "halodi_msgs__msg",  // message namespace
  "RobotStatus",  // message name
  12,  // number of fields
  sizeof(halodi_msgs__msg__RobotStatus),
  RobotStatus__rosidl_typesupport_introspection_c__RobotStatus_message_member_array,  // message members
  RobotStatus__rosidl_typesupport_introspection_c__RobotStatus_init_function,  // function to initialize message memory (memory has to be allocated)
  RobotStatus__rosidl_typesupport_introspection_c__RobotStatus_fini_function  // function to terminate message instance (will not free memory)
};

// this is not const since it must be initialized on first access
// since C does not allow non-integral compile-time constants
static rosidl_message_type_support_t RobotStatus__rosidl_typesupport_introspection_c__RobotStatus_message_type_support_handle = {
  0,
  &RobotStatus__rosidl_typesupport_introspection_c__RobotStatus_message_members,
  get_message_typesupport_handle_function,
};

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, RobotStatus)() {
  RobotStatus__rosidl_typesupport_introspection_c__RobotStatus_message_member_array[0].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, std_msgs, msg, Header)();
  RobotStatus__rosidl_typesupport_introspection_c__RobotStatus_message_member_array[2].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, BatteryStatus)();
  RobotStatus__rosidl_typesupport_introspection_c__RobotStatus_message_member_array[7].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, JointStatus)();
  RobotStatus__rosidl_typesupport_introspection_c__RobotStatus_message_member_array[8].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, MotorStatus)();
  if (!RobotStatus__rosidl_typesupport_introspection_c__RobotStatus_message_type_support_handle.typesupport_identifier) {
    RobotStatus__rosidl_typesupport_introspection_c__RobotStatus_message_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  return &RobotStatus__rosidl_typesupport_introspection_c__RobotStatus_message_type_support_handle;
}
#ifdef __cplusplus
}
#endif
