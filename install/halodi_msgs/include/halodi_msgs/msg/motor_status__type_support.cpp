// generated from rosidl_typesupport_introspection_cpp/resource/idl__type_support.cpp.em
// with input from halodi_msgs:msg/MotorStatus.idl
// generated code does not contain a copyright notice

#include "array"
#include "cstddef"
#include "string"
#include "vector"
#include "rosidl_generator_c/message_type_support_struct.h"
#include "rosidl_typesupport_cpp/message_type_support.hpp"
#include "rosidl_typesupport_interface/macros.h"
#include "halodi_msgs/msg/motor_status__struct.hpp"
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

void MotorStatus_init_function(
  void * message_memory, rosidl_generator_cpp::MessageInitialization _init)
{
  new (message_memory) halodi_msgs::msg::MotorStatus(_init);
}

void MotorStatus_fini_function(void * message_memory)
{
  auto typed_message = static_cast<halodi_msgs::msg::MotorStatus *>(message_memory);
  typed_message->~MotorStatus();
}

size_t size_function__MotorStatus__joints(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<halodi_msgs::msg::JointName> *>(untyped_member);
  return member->size();
}

const void * get_const_function__MotorStatus__joints(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<halodi_msgs::msg::JointName> *>(untyped_member);
  return &member[index];
}

void * get_function__MotorStatus__joints(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<halodi_msgs::msg::JointName> *>(untyped_member);
  return &member[index];
}

void resize_function__MotorStatus__joints(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<halodi_msgs::msg::JointName> *>(untyped_member);
  member->resize(size);
}

static const ::rosidl_typesupport_introspection_cpp::MessageMember MotorStatus_message_member_array[11] = {
  {
    "status_level",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_OCTET,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::MotorStatus, status_level),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "joints",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::JointName>(),  // members of sub message
    true,  // is array
    2,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::MotorStatus, joints),  // bytes offset in struct
    nullptr,  // default value
    size_function__MotorStatus__joints,  // size() function pointer
    get_const_function__MotorStatus__joints,  // get_const(index) function pointer
    get_function__MotorStatus__joints,  // get(index) function pointer
    resize_function__MotorStatus__joints  // resize(index) function pointer
  },
  {
    "motor_id",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_OCTET,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::MotorStatus, motor_id),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "sto_enabled",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::MotorStatus, sto_enabled),  // bytes offset in struct
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
    offsetof(halodi_msgs::msg::MotorStatus, over_temperature),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "motor_serial_number",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_UINT32,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::MotorStatus, motor_serial_number),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "driver_serial_number",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_UINT32,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::MotorStatus, driver_serial_number),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "motor_initialized",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::MotorStatus, motor_initialized),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "motor_temperature",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::MotorStatus, motor_temperature),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "driver_temperature",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::MotorStatus, driver_temperature),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "motor_error",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_OCTET,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::MotorStatus, motor_error),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  }
};

static const ::rosidl_typesupport_introspection_cpp::MessageMembers MotorStatus_message_members = {
  "halodi_msgs::msg",  // message namespace
  "MotorStatus",  // message name
  11,  // number of fields
  sizeof(halodi_msgs::msg::MotorStatus),
  MotorStatus_message_member_array,  // message members
  MotorStatus_init_function,  // function to initialize message memory (memory has to be allocated)
  MotorStatus_fini_function  // function to terminate message instance (will not free memory)
};

static const rosidl_message_type_support_t MotorStatus_message_type_support_handle = {
  ::rosidl_typesupport_introspection_cpp::typesupport_identifier,
  &MotorStatus_message_members,
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
get_message_type_support_handle<halodi_msgs::msg::MotorStatus>()
{
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::MotorStatus_message_type_support_handle;
}

}  // namespace rosidl_typesupport_introspection_cpp

#ifdef __cplusplus
extern "C"
{
#endif

ROSIDL_TYPESUPPORT_INTROSPECTION_CPP_PUBLIC
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_cpp, halodi_msgs, msg, MotorStatus)() {
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::MotorStatus_message_type_support_handle;
}

#ifdef __cplusplus
}
#endif
