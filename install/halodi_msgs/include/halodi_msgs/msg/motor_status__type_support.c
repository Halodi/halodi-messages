// generated from rosidl_typesupport_introspection_c/resource/idl__type_support.c.em
// with input from halodi_msgs:msg/MotorStatus.idl
// generated code does not contain a copyright notice

#include <stddef.h>
#include "halodi_msgs/msg/motor_status__rosidl_typesupport_introspection_c.h"
#include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
#include "rosidl_typesupport_introspection_c/field_types.h"
#include "rosidl_typesupport_introspection_c/identifier.h"
#include "rosidl_typesupport_introspection_c/message_introspection.h"
#include "halodi_msgs/msg/motor_status__functions.h"
#include "halodi_msgs/msg/motor_status__struct.h"


// Include directives for member types
// Member `joints`
#include "halodi_msgs/msg/joint_name.h"
// Member `joints`
#include "halodi_msgs/msg/joint_name__rosidl_typesupport_introspection_c.h"

#ifdef __cplusplus
extern "C"
{
#endif

void MotorStatus__rosidl_typesupport_introspection_c__MotorStatus_init_function(
  void * message_memory, enum rosidl_runtime_c_message_initialization _init)
{
  // TODO(karsten1987): initializers are not yet implemented for typesupport c
  // see https://github.com/ros2/ros2/issues/397
  (void) _init;
  halodi_msgs__msg__MotorStatus__init(message_memory);
}

void MotorStatus__rosidl_typesupport_introspection_c__MotorStatus_fini_function(void * message_memory)
{
  halodi_msgs__msg__MotorStatus__fini(message_memory);
}

size_t MotorStatus__rosidl_typesupport_introspection_c__size_function__JointName__joints(
  const void * untyped_member)
{
  const halodi_msgs__msg__JointName__Sequence * member =
    (const halodi_msgs__msg__JointName__Sequence *)(untyped_member);
  return member->size;
}

const void * MotorStatus__rosidl_typesupport_introspection_c__get_const_function__JointName__joints(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__JointName__Sequence * member =
    (const halodi_msgs__msg__JointName__Sequence *)(untyped_member);
  return &member->data[index];
}

void * MotorStatus__rosidl_typesupport_introspection_c__get_function__JointName__joints(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__JointName__Sequence * member =
    (halodi_msgs__msg__JointName__Sequence *)(untyped_member);
  return &member->data[index];
}

bool MotorStatus__rosidl_typesupport_introspection_c__resize_function__JointName__joints(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__JointName__Sequence * member =
    (halodi_msgs__msg__JointName__Sequence *)(untyped_member);
  halodi_msgs__msg__JointName__Sequence__fini(member);
  return halodi_msgs__msg__JointName__Sequence__init(member, size);
}

static rosidl_typesupport_introspection_c__MessageMember MotorStatus__rosidl_typesupport_introspection_c__MotorStatus_message_member_array[11] = {
  {
    "status_level",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_OCTET,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__MotorStatus, status_level),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "joints",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    2,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__MotorStatus, joints),  // bytes offset in struct
    NULL,  // default value
    MotorStatus__rosidl_typesupport_introspection_c__size_function__JointName__joints,  // size() function pointer
    MotorStatus__rosidl_typesupport_introspection_c__get_const_function__JointName__joints,  // get_const(index) function pointer
    MotorStatus__rosidl_typesupport_introspection_c__get_function__JointName__joints,  // get(index) function pointer
    MotorStatus__rosidl_typesupport_introspection_c__resize_function__JointName__joints  // resize(index) function pointer
  },
  {
    "motor_id",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_OCTET,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__MotorStatus, motor_id),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "sto_enabled",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__MotorStatus, sto_enabled),  // bytes offset in struct
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
    offsetof(halodi_msgs__msg__MotorStatus, over_temperature),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "motor_serial_number",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_UINT32,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__MotorStatus, motor_serial_number),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "driver_serial_number",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_UINT32,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__MotorStatus, driver_serial_number),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "motor_initialized",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__MotorStatus, motor_initialized),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "motor_temperature",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__MotorStatus, motor_temperature),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "driver_temperature",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__MotorStatus, driver_temperature),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "motor_error",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_OCTET,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__MotorStatus, motor_error),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  }
};

static const rosidl_typesupport_introspection_c__MessageMembers MotorStatus__rosidl_typesupport_introspection_c__MotorStatus_message_members = {
  "halodi_msgs__msg",  // message namespace
  "MotorStatus",  // message name
  11,  // number of fields
  sizeof(halodi_msgs__msg__MotorStatus),
  MotorStatus__rosidl_typesupport_introspection_c__MotorStatus_message_member_array,  // message members
  MotorStatus__rosidl_typesupport_introspection_c__MotorStatus_init_function,  // function to initialize message memory (memory has to be allocated)
  MotorStatus__rosidl_typesupport_introspection_c__MotorStatus_fini_function  // function to terminate message instance (will not free memory)
};

// this is not const since it must be initialized on first access
// since C does not allow non-integral compile-time constants
static rosidl_message_type_support_t MotorStatus__rosidl_typesupport_introspection_c__MotorStatus_message_type_support_handle = {
  0,
  &MotorStatus__rosidl_typesupport_introspection_c__MotorStatus_message_members,
  get_message_typesupport_handle_function,
};

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, MotorStatus)() {
  MotorStatus__rosidl_typesupport_introspection_c__MotorStatus_message_member_array[1].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, JointName)();
  if (!MotorStatus__rosidl_typesupport_introspection_c__MotorStatus_message_type_support_handle.typesupport_identifier) {
    MotorStatus__rosidl_typesupport_introspection_c__MotorStatus_message_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  return &MotorStatus__rosidl_typesupport_introspection_c__MotorStatus_message_type_support_handle;
}
#ifdef __cplusplus
}
#endif
