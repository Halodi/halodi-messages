// generated from rosidl_typesupport_introspection_cpp/resource/idl__type_support.cpp.em
// with input from halodi_msgs:msg/JointMeasurement.idl
// generated code does not contain a copyright notice

#include "array"
#include "cstddef"
#include "string"
#include "vector"
#include "rosidl_generator_c/message_type_support_struct.h"
#include "rosidl_typesupport_cpp/message_type_support.hpp"
#include "rosidl_typesupport_interface/macros.h"
#include "halodi_msgs/msg/joint_measurement__struct.hpp"
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

void JointMeasurement_init_function(
  void * message_memory, rosidl_generator_cpp::MessageInitialization _init)
{
  new (message_memory) halodi_msgs::msg::JointMeasurement(_init);
}

void JointMeasurement_fini_function(void * message_memory)
{
  auto typed_message = static_cast<halodi_msgs::msg::JointMeasurement *>(message_memory);
  typed_message->~JointMeasurement();
}

static const ::rosidl_typesupport_introspection_cpp::MessageMember JointMeasurement_message_member_array[5] = {
  {
    "joint",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::JointName>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::JointMeasurement, joint),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "position",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::JointMeasurement, position),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "velocity",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::JointMeasurement, velocity),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "measuredEffort",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::JointMeasurement, measuredEffort),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "desiredEffort",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::JointMeasurement, desiredEffort),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  }
};

static const ::rosidl_typesupport_introspection_cpp::MessageMembers JointMeasurement_message_members = {
  "halodi_msgs::msg",  // message namespace
  "JointMeasurement",  // message name
  5,  // number of fields
  sizeof(halodi_msgs::msg::JointMeasurement),
  JointMeasurement_message_member_array,  // message members
  JointMeasurement_init_function,  // function to initialize message memory (memory has to be allocated)
  JointMeasurement_fini_function  // function to terminate message instance (will not free memory)
};

static const rosidl_message_type_support_t JointMeasurement_message_type_support_handle = {
  ::rosidl_typesupport_introspection_cpp::typesupport_identifier,
  &JointMeasurement_message_members,
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
get_message_type_support_handle<halodi_msgs::msg::JointMeasurement>()
{
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::JointMeasurement_message_type_support_handle;
}

}  // namespace rosidl_typesupport_introspection_cpp

#ifdef __cplusplus
extern "C"
{
#endif

ROSIDL_TYPESUPPORT_INTROSPECTION_CPP_PUBLIC
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_cpp, halodi_msgs, msg, JointMeasurement)() {
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::JointMeasurement_message_type_support_handle;
}

#ifdef __cplusplus
}
#endif
