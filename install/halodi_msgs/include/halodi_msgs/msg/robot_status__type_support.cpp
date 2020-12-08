// generated from rosidl_typesupport_introspection_cpp/resource/idl__type_support.cpp.em
// with input from halodi_msgs:msg/RobotStatus.idl
// generated code does not contain a copyright notice

#include "array"
#include "cstddef"
#include "string"
#include "vector"
#include "rosidl_generator_c/message_type_support_struct.h"
#include "rosidl_typesupport_cpp/message_type_support.hpp"
#include "rosidl_typesupport_interface/macros.h"
#include "halodi_msgs/msg/robot_status__struct.hpp"
#include "rosidl_typesupport_introspection_cpp/field_types.hpp"
#include "rosidl_typesupport_introspection_cpp/identifier.hpp"
#include "rosidl_typesupport_introspection_cpp/message_introspection.hpp"
#include "rosidl_typesupport_introspection_cpp/message_type_support_decl.hpp"
#include "rosidl_typesupport_introspection_cpp/visibility_control.h"

namespace halodi_msgs
{

namespace msg
{

namespace rosidl_typesupport_introspection_cpp
{

void RobotStatus_init_function(
  void * message_memory, rosidl_generator_cpp::MessageInitialization _init)
{
  new (message_memory) halodi_msgs::msg::RobotStatus(_init);
}

void RobotStatus_fini_function(void * message_memory)
{
  auto typed_message = static_cast<halodi_msgs::msg::RobotStatus *>(message_memory);
  typed_message->~RobotStatus();
}

size_t size_function__RobotStatus__joint_status(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<halodi_msgs::msg::JointStatus> *>(untyped_member);
  return member->size();
}

const void * get_const_function__RobotStatus__joint_status(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<halodi_msgs::msg::JointStatus> *>(untyped_member);
  return &member[index];
}

void * get_function__RobotStatus__joint_status(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<halodi_msgs::msg::JointStatus> *>(untyped_member);
  return &member[index];
}

void resize_function__RobotStatus__joint_status(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<halodi_msgs::msg::JointStatus> *>(untyped_member);
  member->resize(size);
}

size_t size_function__RobotStatus__motor_status(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<halodi_msgs::msg::MotorStatus> *>(untyped_member);
  return member->size();
}

const void * get_const_function__RobotStatus__motor_status(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<halodi_msgs::msg::MotorStatus> *>(untyped_member);
  return &member[index];
}

void * get_function__RobotStatus__motor_status(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<halodi_msgs::msg::MotorStatus> *>(untyped_member);
  return &member[index];
}

void resize_function__RobotStatus__motor_status(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<halodi_msgs::msg::MotorStatus> *>(untyped_member);
  member->resize(size);
}

static const ::rosidl_typesupport_introspection_cpp::MessageMember RobotStatus_message_member_array[12] = {
  {
    "header",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<std_msgs::msg::Header>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::RobotStatus, header),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "robot_status_level",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_OCTET,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::RobotStatus, robot_status_level),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "battery_status",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::BatteryStatus>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::RobotStatus, battery_status),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "backpack_estop_enabled",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::RobotStatus, backpack_estop_enabled),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "wireless_estop_enabled",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::RobotStatus, wireless_estop_enabled),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "over_temperature",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::RobotStatus, over_temperature),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "driving_disabled",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::RobotStatus, driving_disabled),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "joint_status",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::JointStatus>(),  // members of sub message
    true,  // is array
    30,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::RobotStatus, joint_status),  // bytes offset in struct
    nullptr,  // default value
    size_function__RobotStatus__joint_status,  // size() function pointer
    get_const_function__RobotStatus__joint_status,  // get_const(index) function pointer
    get_function__RobotStatus__joint_status,  // get(index) function pointer
    resize_function__RobotStatus__joint_status  // resize(index) function pointer
  },
  {
    "motor_status",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::MotorStatus>(),  // members of sub message
    true,  // is array
    30,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::RobotStatus, motor_status),  // bytes offset in struct
    nullptr,  // default value
    size_function__RobotStatus__motor_status,  // size() function pointer
    get_const_function__RobotStatus__motor_status,  // get_const(index) function pointer
    get_function__RobotStatus__motor_status,  // get(index) function pointer
    resize_function__RobotStatus__motor_status  // resize(index) function pointer
  },
  {
    "runtime_since_start",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_UINT32,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::RobotStatus, runtime_since_start),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "total_runtime",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_UINT32,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::RobotStatus, total_runtime),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "numberOfRuns",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_UINT32,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::RobotStatus, numberOfRuns),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  }
};

static const ::rosidl_typesupport_introspection_cpp::MessageMembers RobotStatus_message_members = {
  "halodi_msgs::msg",  // message namespace
  "RobotStatus",  // message name
  12,  // number of fields
  sizeof(halodi_msgs::msg::RobotStatus),
  RobotStatus_message_member_array,  // message members
  RobotStatus_init_function,  // function to initialize message memory (memory has to be allocated)
  RobotStatus_fini_function  // function to terminate message instance (will not free memory)
};

static const rosidl_message_type_support_t RobotStatus_message_type_support_handle = {
  ::rosidl_typesupport_introspection_cpp::typesupport_identifier,
  &RobotStatus_message_members,
  get_message_typesupport_handle_function,
};

}  // namespace rosidl_typesupport_introspection_cpp

}  // namespace msg

}  // namespace halodi_msgs


namespace rosidl_typesupport_introspection_cpp
{

template<>
ROSIDL_TYPESUPPORT_INTROSPECTION_CPP_PUBLIC
const rosidl_message_type_support_t *
get_message_type_support_handle<halodi_msgs::msg::RobotStatus>()
{
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::RobotStatus_message_type_support_handle;
}

}  // namespace rosidl_typesupport_introspection_cpp

#ifdef __cplusplus
extern "C"
{
#endif

ROSIDL_TYPESUPPORT_INTROSPECTION_CPP_PUBLIC
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_cpp, halodi_msgs, msg, RobotStatus)() {
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::RobotStatus_message_type_support_handle;
}

#ifdef __cplusplus
}
#endif
